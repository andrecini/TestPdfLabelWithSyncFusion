using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Barcode;
using System.Drawing;
using Syncfusion.XPS;
using Brush = System.Drawing.Brush;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace TesteCriarPdfEmRuntimeWithSyncFusion
{
    public class EtiquetaCreator
    {
        #region Variáveis Locais

        private static PdfQRBarcode barcode = new PdfQRBarcode();
        private static PdfDocument doc;
        private static PdfGraphics graphics;
        private static PdfPage page;
        private static PdfFont font1 = new PdfStandardFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Bold);
        private static PdfFont font2 = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

        #endregion
        
        /// <summary>
        /// Cria PDF da Etiqueta 
        /// </summary>
        /// <param name="etiqueta"></param>
        public static void CriaPDF(Etiqueta etiqueta)
        {
            doc = new PdfDocument();

            doc.PageSettings.Size = new SizeF(ConvertMmForPx(50), ConvertMmForPx(25));

            SetMargin(ConvertMmForPx(1), ConvertMmForPx(1));

            doc.PageSettings.Orientation = PdfPageOrientation.Landscape;

            page = doc.Pages.Add();

            graphics = page.Graphics;

            SetImage(etiqueta.Logo);

            SetQrCode(etiqueta.ID, etiqueta.Function, etiqueta.Tag, etiqueta.Date, etiqueta.Validity, etiqueta.Executor);

            SetLabels(etiqueta.Tag, etiqueta.Date, etiqueta.Validity, etiqueta.Executor);

            SetTitle(etiqueta.Function, PdfBrushes.DarkBlue);

            //Saves and closes the document.
            doc.Save("Etiqueta.pdf");
            doc.Close(true);

        }

        #region Métodos de configuração da Etiqueta

        /// <summary>
        /// Configura a Margem do PDF
        /// </summary>
        /// <param name="x">Margens verticais (px)</param>
        /// <param name="y">Margens horizontais (px)</param>
        private static void SetMargin(float x, float y)
        {
            PdfMargins margin = new PdfMargins();

            margin.Left = x;
            margin.Right = x;
            margin.Bottom = y;
            margin.Top = y;
           
            doc.PageSettings.Margins = margin;
        }

        /// <summary>
        /// Insere o logo da empresa
        /// </summary>
        /// <param name="imageName">EX: "logo.jpg"</param>
        private static void SetImage(string imageName)
        {
            //Load the image from the disk
            Image logo = Image.FromFile(imageName);

            PdfBitmap image = new PdfBitmap(logo);

            //Draw the image
            graphics.DrawImage(image, ConvertMmForPx(2), 0, ConvertMmForPx(20.00), ConvertMmForPx(6.00));

            logo.Dispose();
        }

        /// <summary>
        /// Insere o QrCOde
        /// </summary>
        /// <param name="ID">ID da etiqueta</param>
        /// <param name="title">Função do intrumento</param>
        /// <param name="tag">Tag do intrumento</param>
        /// <param name="date">Data do intrumento</param>
        /// <param name="validiy">Validade do intrumento</param>
        /// <param name="executor">Executor do intrumento</param>
        private static void SetQrCode(int ID, string title, string tag, string date, string validiy, string executor)
        {
            float qrcodeHeight = ConvertMmForPx(15);
            float qrcodeWidth = ConvertMmForPx(15);

            barcode.XDimension = 7;
            barcode.Size = new SizeF(qrcodeWidth, qrcodeHeight);

            //Call QRCode's Information
            StringBuilder qrCodeText = new StringBuilder();
            qrCodeText.AppendLine(title);
            qrCodeText.AppendLine(tag);
            qrCodeText.AppendLine(date);
            qrCodeText.AppendLine(validiy);
            qrCodeText.AppendLine(executor);
            qrCodeText.AppendLine("{id:" + ID.ToString() + "}");
            barcode.Text = qrCodeText.ToString();
                        
            //Define QRCode Position
            barcode.Draw(page, new PointF(ConvertMmForPx(2), ConvertMmForPx(7)));
        }

        /// <summary>
        /// Insere o Corpo da etiqueta
        /// </summary>
        /// <param name="tag">Tag do intrumento</param>
        /// <param name="date">Data do intrumento</param>
        /// <param name="validiy">Validade do intrumento</param>
        /// <param name="executor">Executor do intrumento</param>
        private static void SetLabels(string tag, string date, string validiy, string executor)
        {
            RectangleF labels = new RectangleF(new PointF(ConvertMmForPx(20), ConvertMmForPx(7)), new SizeF(ConvertMmForPx(32), ConvertMmForPx(15)));

            PdfStringFormat format = new PdfStringFormat();
            format.LineAlignment = PdfVerticalAlignment.Middle;
            format.Alignment = PdfTextAlignment.Left;

            format.LineSpacing = 1;

            var labelText = new StringBuilder();
            labelText.AppendLine("TAG: " + tag);
            labelText.AppendLine("DATA: " + date);
            labelText.AppendLine("VALID.: " + validiy);
            labelText.AppendLine("EXEC.: " + executor);

            graphics.DrawString(labelText.ToString(), font2, PdfBrushes.Black, labels, format);
        }

        /// <summary>
        /// Insere o título da etiqueta.
        /// </summary>
        /// <param name="function">Função do intrumento</param>
        /// <param name="fontColor">Cor do Título</param>
        private static void SetTitle(string function, PdfBrush fontColor)
        {
            RectangleF title = new RectangleF(new PointF(ConvertMmForPx(22), ConvertMmForPx(0)), new SizeF(ConvertMmForPx(25), ConvertMmForPx(6)));

            
            Color rgb = new Color();
            rgb = Color.FromArgb(100, 30, 100);

            PdfStringFormat format = new PdfStringFormat();

            format.LineAlignment = PdfVerticalAlignment.Middle;

            format.Alignment = PdfTextAlignment.Center;

            PdfSolidBrush brush = new PdfSolidBrush(rgb);

            graphics.DrawString(function, font1, brush, title, format);
        }

        

        private static void SetTitle(string function)
        {
            RectangleF title = new RectangleF(new PointF(ConvertMmForPx(20), ConvertMmForPx(0)), new SizeF(ConvertMmForPx(27), ConvertMmForPx(6)));

            PdfStringFormat format = new PdfStringFormat();

            format.LineAlignment = PdfVerticalAlignment.Middle;

            format.Alignment = PdfTextAlignment.Center;

            graphics.DrawString(function, font1, PdfBrushes.Black, title, format);
        }

        #endregion

        #region Transformação mm para px
        
        /// <summary>
        /// Converte mm para Point
        /// </summary>
        /// <param name="mm">Tamanho em milímetros</param>
        /// <returns>Float</returns>
        private static float ConvertMmForPx(double mm)
        {
            return (float)(mm * 2.83465);
        }

        /// <summary>
        /// Converte mm para Point
        /// </summary>
        /// <param name="mm">Tamanho em milímetros</param>
        /// <returns>Inteiro</returns>
        private static int ConvertMmForPx(int mm)
        {
            return (int)(mm * 2.83465);
        }

        #endregion
        
    }
}
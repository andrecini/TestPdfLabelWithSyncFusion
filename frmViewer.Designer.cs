
namespace TesteCriarPdfEmRuntimeWithSyncFusion
{
    partial class frmViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewer));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.Viewer = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.EnableContextMenu = true;
            this.Viewer.EnableNotificationBar = true;
            this.Viewer.HorizontalScrollOffset = 0;
            this.Viewer.IsBookmarkEnabled = true;
            this.Viewer.IsTextSearchEnabled = true;
            this.Viewer.IsTextSelectionEnabled = true;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            messageBoxSettings1.EnableNotification = true;
            this.Viewer.MessageBoxSettings = messageBoxSettings1;
            this.Viewer.MinimumZoomPercentage = 50;
            this.Viewer.Name = "Viewer";
            this.Viewer.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            this.Viewer.PrinterSettings = pdfViewerPrinterSettings1;
            this.Viewer.ReferencePath = null;
            this.Viewer.ScrollDisplacementValue = 0;
            this.Viewer.ShowHorizontalScrollBar = true;
            this.Viewer.ShowToolBar = true;
            this.Viewer.ShowVerticalScrollBar = true;
            this.Viewer.Size = new System.Drawing.Size(800, 450);
            this.Viewer.SpaceBetweenPages = 8;
            this.Viewer.TabIndex = 0;
            this.Viewer.Text = "pdfViewerControl1";
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Viewer.TextSearchSettings = textSearchSettings1;
            this.Viewer.ThemeName = "Default";
            this.Viewer.VerticalScrollOffset = 0;
            this.Viewer.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.Viewer.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Viewer);
            this.Name = "frmViewer";
            this.Text = "Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl Viewer;
    }
}
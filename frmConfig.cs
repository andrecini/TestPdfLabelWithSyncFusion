using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TesteCriarPdfEmRuntimeWithSyncFusion
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            VerifyIdControlFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            try
            {
                Etiqueta etiqueta = Etiqueta.GetSingleInstance();

                etiqueta.ID = GetCurrentID();
                etiqueta.Function = txtFunctions.Text;
                etiqueta.Tag = txtTag.Text;
                etiqueta.Date = txtDate.Text;
                etiqueta.Validity = txtValidity.Text;
                etiqueta.Executor = txtExecutor.Text;
                etiqueta.Logo = txtLogoPath.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd.Multiselect = false;
            this.ofd.Title = "Selecionar Logo";
            ofd.InitialDirectory = @"C:\Users";
            //filtra para exibir somente arquivos de imagens
            ofd.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            DialogResult dr = this.ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtLogoPath.Text = ofd.FileName;
                    
                try
                {
                    Image logo = Image.FromFile(ofd.FileName);
                    picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    picLogo.Image = logo;
                }
                catch (SecurityException ex)
                {
                     MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetCurrentID()
        {
            var sr = new StreamReader("IDControl.txt");
            int id = int.Parse(sr.ReadLine()) + 1;
            sr.Close();
            sr.Dispose();

            var sw = new StreamWriter("IDControl.txt");
            sw.WriteLine(id.ToString());
            sw.Close();
            sw.Dispose();

            return id;
        }

        private void VerifyIdControlFile()
        {
            if (!File.Exists("IDControl.txt"))
            {
                File.WriteAllText("IDControl.txt", "0");
            }            
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            try
            {
                Image logo = Image.FromFile(txtLogoPath.Text);
                picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                picLogo.Image = logo;
            }
            catch
            {

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                EtiquetaCreator.CriaPDF(VerifyEtiquetaExistence());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            frmViewer viewer = new frmViewer();
            viewer.ShowDialog();
        }

        private Etiqueta VerifyEtiquetaExistence()
        {
            if (!Etiqueta.CheckIfAnInstanceExists())
            {
                return Etiqueta.GetSingleInstance(1, "Calibração", "Tag-00", DateTime.Now.ToString("dd/MM/yy"), "30/12/2030", "André Cini", "presys-logo.jpg");
            }
            else
            {
                return Etiqueta.GetSingleInstance();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteCriarPdfEmRuntimeWithSyncFusion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var frm = new frmConfig();
            frm.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
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
            if(!Etiqueta.CheckIfAnInstanceExists())
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

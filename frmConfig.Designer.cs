
namespace TesteCriarPdfEmRuntimeWithSyncFusion
{
    partial class frmConfig
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
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtValidity = new System.Windows.Forms.MaskedTextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtExecutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFunctions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLogoPath = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnPreview = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtValidity);
            this.gbData.Controls.Add(this.txtDate);
            this.gbData.Controls.Add(this.txtExecutor);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.txtTag);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.txtFunctions);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Location = new System.Drawing.Point(8, 85);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(356, 242);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Dados";
            // 
            // txtValidity
            // 
            this.txtValidity.Location = new System.Drawing.Point(9, 162);
            this.txtValidity.Mask = "00/00";
            this.txtValidity.Name = "txtValidity";
            this.txtValidity.Size = new System.Drawing.Size(341, 20);
            this.txtValidity.TabIndex = 11;
            this.txtValidity.Text = "0522";
            this.txtValidity.ValidatingType = typeof(System.DateTime);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(9, 121);
            this.txtDate.Mask = "00/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(341, 20);
            this.txtDate.TabIndex = 10;
            this.txtDate.Text = "110521";
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtExecutor
            // 
            this.txtExecutor.Location = new System.Drawing.Point(9, 202);
            this.txtExecutor.MaxLength = 15;
            this.txtExecutor.Name = "txtExecutor";
            this.txtExecutor.Size = new System.Drawing.Size(341, 20);
            this.txtExecutor.TabIndex = 9;
            this.txtExecutor.Tag = "TagData";
            this.txtExecutor.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Executor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Validade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(9, 79);
            this.txtTag.MaxLength = 15;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(341, 20);
            this.txtTag.TabIndex = 3;
            this.txtTag.Tag = "TagData";
            this.txtTag.Text = "CP-0001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tag:";
            // 
            // txtFunctions
            // 
            this.txtFunctions.Location = new System.Drawing.Point(9, 38);
            this.txtFunctions.MaxLength = 15;
            this.txtFunctions.Name = "txtFunctions";
            this.txtFunctions.Size = new System.Drawing.Size(341, 20);
            this.txtFunctions.TabIndex = 1;
            this.txtFunctions.Tag = "TagData";
            this.txtFunctions.Text = "Calibração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Função:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(289, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtLogoPath);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logo";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(241, 31);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(94, 26);
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(147, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLogoPath
            // 
            this.txtLogoPath.Location = new System.Drawing.Point(9, 19);
            this.txtLogoPath.Name = "txtLogoPath";
            this.txtLogoPath.ReadOnly = true;
            this.txtLogoPath.Size = new System.Drawing.Size(213, 20);
            this.txtLogoPath.TabIndex = 2;
            this.txtLogoPath.Tag = "TagLogo";
            this.txtLogoPath.Text = "logo-cliente.png";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(138, 333);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(145, 23);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Visualizar Impressão";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 363);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbData);
            this.Name = "frmConfig";
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtExecutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFunctions;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLogoPath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MaskedTextBox txtValidity;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Button btnPreview;
    }
}
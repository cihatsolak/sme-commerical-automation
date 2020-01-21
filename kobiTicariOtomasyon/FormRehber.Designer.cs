namespace kobiTicariOtomasyon
{
    partial class FormRehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRehber));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.rehberMusteriler = new DevExpress.XtraGrid.GridControl();
            this.rehberMusteriler1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.rehberFirmalar = new DevExpress.XtraGrid.GridControl();
            this.rehberFirmalar1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rehberMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberMusteriler1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rehberFirmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberFirmalar1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1364, 546);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.rehberMusteriler);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1358, 515);
            this.xtraTabPage1.Text = "MÜŞTERİLER";
            // 
            // rehberMusteriler
            // 
            this.rehberMusteriler.Location = new System.Drawing.Point(0, 3);
            this.rehberMusteriler.MainView = this.rehberMusteriler1;
            this.rehberMusteriler.Name = "rehberMusteriler";
            this.rehberMusteriler.Size = new System.Drawing.Size(1358, 515);
            this.rehberMusteriler.TabIndex = 16;
            this.rehberMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rehberMusteriler1});
            // 
            // rehberMusteriler1
            // 
            this.rehberMusteriler1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rehberMusteriler1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rehberMusteriler1.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.rehberMusteriler1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rehberMusteriler1.Appearance.Row.Options.UseBackColor = true;
            this.rehberMusteriler1.Appearance.Row.Options.UseBorderColor = true;
            this.rehberMusteriler1.Appearance.Row.Options.UseFont = true;
            this.rehberMusteriler1.GridControl = this.rehberMusteriler;
            this.rehberMusteriler1.Name = "rehberMusteriler1";
            this.rehberMusteriler1.OptionsView.ShowGroupPanel = false;
            this.rehberMusteriler1.DoubleClick += new System.EventHandler(this.rehberMusteriler1_DoubleClick);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.rehberFirmalar);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1358, 515);
            this.xtraTabPage2.Text = "FİRMALAR";
            // 
            // rehberFirmalar
            // 
            this.rehberFirmalar.Location = new System.Drawing.Point(0, 4);
            this.rehberFirmalar.MainView = this.rehberFirmalar1;
            this.rehberFirmalar.Name = "rehberFirmalar";
            this.rehberFirmalar.Size = new System.Drawing.Size(1359, 511);
            this.rehberFirmalar.TabIndex = 17;
            this.rehberFirmalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rehberFirmalar1});
            // 
            // rehberFirmalar1
            // 
            this.rehberFirmalar1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rehberFirmalar1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rehberFirmalar1.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.rehberFirmalar1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rehberFirmalar1.Appearance.Row.Options.UseBackColor = true;
            this.rehberFirmalar1.Appearance.Row.Options.UseBorderColor = true;
            this.rehberFirmalar1.Appearance.Row.Options.UseFont = true;
            this.rehberFirmalar1.GridControl = this.rehberFirmalar;
            this.rehberFirmalar1.Name = "rehberFirmalar1";
            this.rehberFirmalar1.OptionsView.ShowGroupPanel = false;
            this.rehberFirmalar1.DoubleClick += new System.EventHandler(this.rehberFirmalar1_DoubleClick);
            // 
            // FormRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 546);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FormRehber";
            this.Text = "REHBER";
            this.Load += new System.EventHandler(this.formRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rehberMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberMusteriler1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rehberFirmalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberFirmalar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl rehberMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView rehberMusteriler1;
        private DevExpress.XtraGrid.GridControl rehberFirmalar;
        private DevExpress.XtraGrid.Views.Grid.GridView rehberFirmalar1;
    }
}
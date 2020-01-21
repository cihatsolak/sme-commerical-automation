namespace kobiTicariOtomasyon
{
    partial class FormHareketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHareketler));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.hareketMusteriler = new DevExpress.XtraGrid.GridControl();
            this.hareketMusteriler1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.hareketFirmalar = new DevExpress.XtraGrid.GridControl();
            this.hareketFirmalar1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.hareketStoklar = new DevExpress.XtraGrid.GridControl();
            this.hareketStoklar1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hareketMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketMusteriler1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hareketFirmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketFirmalar1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hareketStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketStoklar1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1364, 546);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.hareketMusteriler);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1358, 515);
            this.xtraTabPage1.Text = "Müşteri Hareketleri";
            // 
            // hareketMusteriler
            // 
            this.hareketMusteriler.Location = new System.Drawing.Point(0, 3);
            this.hareketMusteriler.MainView = this.hareketMusteriler1;
            this.hareketMusteriler.Name = "hareketMusteriler";
            this.hareketMusteriler.Size = new System.Drawing.Size(1358, 512);
            this.hareketMusteriler.TabIndex = 16;
            this.hareketMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hareketMusteriler1});
            // 
            // hareketMusteriler1
            // 
            this.hareketMusteriler1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hareketMusteriler1.Appearance.Row.BackColor2 = System.Drawing.Color.NavajoWhite;
            this.hareketMusteriler1.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.hareketMusteriler1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hareketMusteriler1.Appearance.Row.Options.UseBackColor = true;
            this.hareketMusteriler1.Appearance.Row.Options.UseBorderColor = true;
            this.hareketMusteriler1.Appearance.Row.Options.UseFont = true;
            this.hareketMusteriler1.GridControl = this.hareketMusteriler;
            this.hareketMusteriler1.Name = "hareketMusteriler1";
            this.hareketMusteriler1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.hareketFirmalar);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1358, 515);
            this.xtraTabPage2.Text = "Firma Hareketleri";
            // 
            // hareketFirmalar
            // 
            this.hareketFirmalar.Location = new System.Drawing.Point(0, 4);
            this.hareketFirmalar.MainView = this.hareketFirmalar1;
            this.hareketFirmalar.Name = "hareketFirmalar";
            this.hareketFirmalar.Size = new System.Drawing.Size(1359, 511);
            this.hareketFirmalar.TabIndex = 17;
            this.hareketFirmalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hareketFirmalar1});
            // 
            // hareketFirmalar1
            // 
            this.hareketFirmalar1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.hareketFirmalar1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hareketFirmalar1.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.hareketFirmalar1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hareketFirmalar1.Appearance.Row.Options.UseBackColor = true;
            this.hareketFirmalar1.Appearance.Row.Options.UseBorderColor = true;
            this.hareketFirmalar1.Appearance.Row.Options.UseFont = true;
            this.hareketFirmalar1.GridControl = this.hareketFirmalar;
            this.hareketFirmalar1.Name = "hareketFirmalar1";
            this.hareketFirmalar1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.hareketStoklar);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1358, 515);
            this.xtraTabPage3.Text = "Stok Hareketleri";
            // 
            // hareketStoklar
            // 
            this.hareketStoklar.Location = new System.Drawing.Point(0, 1);
            this.hareketStoklar.MainView = this.hareketStoklar1;
            this.hareketStoklar.Name = "hareketStoklar";
            this.hareketStoklar.Size = new System.Drawing.Size(1359, 514);
            this.hareketStoklar.TabIndex = 18;
            this.hareketStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hareketStoklar1});
            // 
            // hareketStoklar1
            // 
            this.hareketStoklar1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hareketStoklar1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hareketStoklar1.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.hareketStoklar1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hareketStoklar1.Appearance.Row.Options.UseBackColor = true;
            this.hareketStoklar1.Appearance.Row.Options.UseBorderColor = true;
            this.hareketStoklar1.Appearance.Row.Options.UseFont = true;
            this.hareketStoklar1.GridControl = this.hareketStoklar;
            this.hareketStoklar1.Name = "hareketStoklar1";
            this.hareketStoklar1.OptionsView.ShowGroupPanel = false;
            // 
            // FormHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 546);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FormHareketler";
            this.Text = "HAREKETLER";
            this.Load += new System.EventHandler(this.FormHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hareketMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketMusteriler1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hareketFirmalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketFirmalar1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hareketStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketStoklar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl hareketMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView hareketMusteriler1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl hareketFirmalar;
        private DevExpress.XtraGrid.Views.Grid.GridView hareketFirmalar1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl hareketStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView hareketStoklar1;
    }
}
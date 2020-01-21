namespace kobiTicariOtomasyon
{
    partial class FormFaturaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturaDetay));
            this.gridFaturaDetay = new DevExpress.XtraGrid.GridControl();
            this.gridFaturaDetay1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturaDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturaDetay1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFaturaDetay
            // 
            this.gridFaturaDetay.Location = new System.Drawing.Point(0, 29);
            this.gridFaturaDetay.MainView = this.gridFaturaDetay1;
            this.gridFaturaDetay.Name = "gridFaturaDetay";
            this.gridFaturaDetay.Size = new System.Drawing.Size(1125, 453);
            this.gridFaturaDetay.TabIndex = 0;
            this.gridFaturaDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFaturaDetay1});
            // 
            // gridFaturaDetay1
            // 
            this.gridFaturaDetay1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridFaturaDetay1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridFaturaDetay1.Appearance.Row.Options.UseBackColor = true;
            this.gridFaturaDetay1.GridControl = this.gridFaturaDetay;
            this.gridFaturaDetay1.Name = "gridFaturaDetay1";
            this.gridFaturaDetay1.OptionsView.ShowGroupPanel = false;
            this.gridFaturaDetay1.DoubleClick += new System.EventHandler(this.gridFaturaDetay1_DoubleClick);
            // 
            // btnExcel
            // 
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(4, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 23);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "EXCEL\'E AKTAR";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xls";
            // 
            // btnYazdir
            // 
            this.btnYazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.ImageOptions.Image")));
            this.btnYazdir.Location = new System.Drawing.Point(115, 3);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(105, 23);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "YAZDIR";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // FormFaturaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1125, 483);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gridFaturaDetay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFaturaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA DETAY";
            this.Load += new System.EventHandler(this.FormFaturaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturaDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturaDetay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridFaturaDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFaturaDetay1;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
    }
}
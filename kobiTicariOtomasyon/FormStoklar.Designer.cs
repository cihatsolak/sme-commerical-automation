namespace kobiTicariOtomasyon
{
    partial class FormStoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoklar));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.stokControl = new DevExpress.XtraGrid.GridControl();
            this.stokControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grafikKontrol = new DevExpress.XtraCharts.ChartControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.sehirGrafikKontrol = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.stokControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafikKontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehirGrafikKontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stokControl
            // 
            this.stokControl.Location = new System.Drawing.Point(0, 1);
            this.stokControl.MainView = this.stokControl1;
            this.stokControl.Name = "stokControl";
            this.stokControl.Size = new System.Drawing.Size(328, 546);
            this.stokControl.TabIndex = 0;
            this.stokControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.stokControl1});
            // 
            // stokControl1
            // 
            this.stokControl1.GridControl = this.stokControl;
            this.stokControl1.Name = "stokControl1";
            this.stokControl1.OptionsView.ShowGroupPanel = false;
            this.stokControl1.DoubleClick += new System.EventHandler(this.stokControl1_DoubleClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(334, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1030, 546);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grafikKontrol);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1024, 515);
            this.xtraTabPage1.Text = "Ürün Miktar";
            // 
            // grafikKontrol
            // 
            this.grafikKontrol.Legend.Name = "Default Legend";
            this.grafikKontrol.Location = new System.Drawing.Point(1, 0);
            this.grafikKontrol.Name = "grafikKontrol";
            series1.LegendTextPattern = "{A}";
            series1.Name = "pastaDilimi";
            series1.View = pieSeriesView1;
            this.grafikKontrol.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.grafikKontrol.Size = new System.Drawing.Size(1024, 517);
            this.grafikKontrol.TabIndex = 2;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.sehirGrafikKontrol);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1024, 522);
            this.xtraTabPage2.Text = "Firma - Şehir";
            // 
            // sehirGrafikKontrol
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.sehirGrafikKontrol.Diagram = simpleDiagram3D1;
            this.sehirGrafikKontrol.Legend.Name = "Default Legend";
            this.sehirGrafikKontrol.Location = new System.Drawing.Point(7, 6);
            this.sehirGrafikKontrol.Name = "sehirGrafikKontrol";
            series2.LegendTextPattern = "{A}";
            series2.Name = "sehirDilimi";
            series2.View = pie3DSeriesView1;
            this.sehirGrafikKontrol.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.sehirGrafikKontrol.Size = new System.Drawing.Size(1017, 528);
            this.sehirGrafikKontrol.TabIndex = 3;
            // 
            // FormStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 546);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.stokControl);
            this.Name = "FormStoklar";
            this.Text = "STOKLAR";
            this.Load += new System.EventHandler(this.FormStoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikKontrol)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirGrafikKontrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl stokControl;
        private DevExpress.XtraGrid.Views.Grid.GridView stokControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraCharts.ChartControl grafikKontrol;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraCharts.ChartControl sehirGrafikKontrol;
    }
}
namespace kobiTicariOtomasyon
{
    partial class FormAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyarlar));
            this.gridKullanicilar = new DevExpress.XtraGrid.GridControl();
            this.gridKullanicilar1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.btnIslem = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKullanicilar
            // 
            this.gridKullanicilar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridKullanicilar.Location = new System.Drawing.Point(0, 0);
            this.gridKullanicilar.MainView = this.gridKullanicilar1;
            this.gridKullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.gridKullanicilar.Name = "gridKullanicilar";
            this.gridKullanicilar.Size = new System.Drawing.Size(564, 278);
            this.gridKullanicilar.TabIndex = 4;
            this.gridKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKullanicilar1});
            // 
            // gridKullanicilar1
            // 
            this.gridKullanicilar1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridKullanicilar1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridKullanicilar1.Appearance.Row.Options.UseBackColor = true;
            this.gridKullanicilar1.DetailHeight = 485;
            this.gridKullanicilar1.FixedLineWidth = 3;
            this.gridKullanicilar1.GridControl = this.gridKullanicilar;
            this.gridKullanicilar1.Name = "gridKullanicilar1";
            this.gridKullanicilar1.OptionsView.ShowGroupPanel = false;
            this.gridKullanicilar1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(134, 318);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Properties.MaxLength = 10;
            this.txtKullanici.Size = new System.Drawing.Size(160, 26);
            this.txtKullanici.TabIndex = 1;
            this.txtKullanici.EditValueChanged += new System.EventHandler(this.txtKullanici_EditValueChanged);
            // 
            // btnIslem
            // 
            this.btnIslem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslem.Appearance.Options.UseFont = true;
            this.btnIslem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIslem.ImageOptions.Image")));
            this.btnIslem.Location = new System.Drawing.Point(134, 434);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(160, 39);
            this.btnIslem.TabIndex = 4;
            this.btnIslem.Text = "Kaydet";
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(134, 359);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.MaxLength = 10;
            this.txtSifre.Size = new System.Drawing.Size(160, 26);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.EditValueChanged += new System.EventHandler(this.txtSifre_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ŞİFRE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "KOD:";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(134, 398);
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.Properties.Appearance.Options.UseFont = true;
            this.txtKod.Properties.MaxLength = 5;
            this.txtKod.Size = new System.Drawing.Size(160, 26);
            this.txtKod.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 446);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(10, 20);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // FormAyarlar
            // 
            this.AcceptButton = this.btnIslem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 497);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.gridKullanicilar);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYARLAR";
            this.Load += new System.EventHandler(this.FormAyarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKullanicilar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKullanicilar1;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.SimpleButton btnIslem;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.TextEdit txtId;
    }
}
namespace kobiTicariOtomasyon
{
    partial class FormBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBankalar));
            this.cmbBoxILCE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbBoxIL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSube = new DevExpress.XtraEditors.TextEdit();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridBankalar1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridBankalar = new DevExpress.XtraGrid.GridControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.grupKontrol = new DevExpress.XtraEditors.GroupControl();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.lookUpFirma = new DevExpress.XtraEditors.LookUpEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapTur = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbBankaAdi = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxILCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxIL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankalar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupKontrol)).BeginInit();
            this.grupKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankaAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxILCE
            // 
            this.cmbBoxILCE.Location = new System.Drawing.Point(113, 103);
            this.cmbBoxILCE.Name = "cmbBoxILCE";
            this.cmbBoxILCE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxILCE.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxILCE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxILCE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBoxILCE.Size = new System.Drawing.Size(195, 24);
            this.cmbBoxILCE.TabIndex = 4;
            // 
            // cmbBoxIL
            // 
            this.cmbBoxIL.Location = new System.Drawing.Point(113, 67);
            this.cmbBoxIL.Name = "cmbBoxIL";
            this.cmbBoxIL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxIL.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxIL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxIL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBoxIL.Size = new System.Drawing.Size(195, 24);
            this.cmbBoxIL.TabIndex = 3;
            this.cmbBoxIL.SelectedIndexChanged += new System.EventHandler(this.cmbBoxIL_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(68, 140);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 18);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "ŞUBE:";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(113, 137);
            this.txtSube.Name = "txtSube";
            this.txtSube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSube.Properties.Appearance.Options.UseFont = true;
            this.txtSube.Properties.MaxLength = 30;
            this.txtSube.Size = new System.Drawing.Size(195, 24);
            this.txtSube.TabIndex = 5;
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(113, 308);
            this.txtTarih.Mask = "00/00/0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(195, 26);
            this.txtTarih.TabIndex = 10;
            this.txtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(113, 272);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(195, 26);
            this.txtTelefon.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(73, 106);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 18);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "İLÇE:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(90, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 18);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "İL:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(41, 275);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 18);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "TELEFON:";
            // 
            // gridBankalar1
            // 
            this.gridBankalar1.Appearance.Row.BackColor = System.Drawing.Color.LightBlue;
            this.gridBankalar1.Appearance.Row.BackColor2 = System.Drawing.Color.MistyRose;
            this.gridBankalar1.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gridBankalar1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridBankalar1.Appearance.Row.Options.UseBackColor = true;
            this.gridBankalar1.Appearance.Row.Options.UseBorderColor = true;
            this.gridBankalar1.Appearance.Row.Options.UseFont = true;
            this.gridBankalar1.GridControl = this.gridBankalar;
            this.gridBankalar1.Name = "gridBankalar1";
            this.gridBankalar1.OptionsView.ShowGroupPanel = false;
            this.gridBankalar1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridBankalar1_FocusedRowChanged);
            // 
            // gridBankalar
            // 
            this.gridBankalar.Location = new System.Drawing.Point(-1, 1);
            this.gridBankalar.MainView = this.gridBankalar1;
            this.gridBankalar.Name = "gridBankalar";
            this.gridBankalar.Size = new System.Drawing.Size(1036, 546);
            this.gridBankalar.TabIndex = 17;
            this.gridBankalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBankalar1});
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(69, 175);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 18);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "IBAN:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 18);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "BANKA ADI:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(16, 509);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(10, 24);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // grupKontrol
            // 
            this.grupKontrol.Controls.Add(this.txtIban);
            this.grupKontrol.Controls.Add(this.lookUpFirma);
            this.grupKontrol.Controls.Add(this.btnTemizle);
            this.grupKontrol.Controls.Add(this.btnSil);
            this.grupKontrol.Controls.Add(this.btnGuncelle);
            this.grupKontrol.Controls.Add(this.btnKaydet);
            this.grupKontrol.Controls.Add(this.labelControl9);
            this.grupKontrol.Controls.Add(this.labelControl6);
            this.grupKontrol.Controls.Add(this.txtHesapTur);
            this.grupKontrol.Controls.Add(this.labelControl4);
            this.grupKontrol.Controls.Add(this.labelControl13);
            this.grupKontrol.Controls.Add(this.txtYetkili);
            this.grupKontrol.Controls.Add(this.labelControl12);
            this.grupKontrol.Controls.Add(this.txtHesapNo);
            this.grupKontrol.Controls.Add(this.cmbBankaAdi);
            this.grupKontrol.Controls.Add(this.cmbBoxILCE);
            this.grupKontrol.Controls.Add(this.cmbBoxIL);
            this.grupKontrol.Controls.Add(this.labelControl10);
            this.grupKontrol.Controls.Add(this.txtSube);
            this.grupKontrol.Controls.Add(this.txtTarih);
            this.grupKontrol.Controls.Add(this.txtTelefon);
            this.grupKontrol.Controls.Add(this.labelControl8);
            this.grupKontrol.Controls.Add(this.labelControl7);
            this.grupKontrol.Controls.Add(this.labelControl5);
            this.grupKontrol.Controls.Add(this.labelControl3);
            this.grupKontrol.Controls.Add(this.labelControl2);
            this.grupKontrol.Controls.Add(this.txtId);
            this.grupKontrol.Location = new System.Drawing.Point(1035, 1);
            this.grupKontrol.Name = "grupKontrol";
            this.grupKontrol.Size = new System.Drawing.Size(330, 546);
            this.grupKontrol.TabIndex = 16;
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(113, 172);
            this.txtIban.Name = "txtIban";
            this.txtIban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIban.Properties.Appearance.Options.UseFont = true;
            this.txtIban.Properties.MaxLength = 24;
            this.txtIban.Size = new System.Drawing.Size(196, 24);
            this.txtIban.TabIndex = 6;
            // 
            // lookUpFirma
            // 
            this.lookUpFirma.Location = new System.Drawing.Point(113, 376);
            this.lookUpFirma.Name = "lookUpFirma";
            this.lookUpFirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpFirma.Properties.Appearance.Options.UseFont = true;
            this.lookUpFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFirma.Size = new System.Drawing.Size(196, 24);
            this.lookUpFirma.TabIndex = 12;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(174, 466);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(134, 36);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(25, 424);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 36);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(27, 466);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(134, 36);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(172, 424);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(136, 36);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(59, 379);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 18);
            this.labelControl9.TabIndex = 37;
            this.labelControl9.Text = "FİRMA:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(16, 345);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 18);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "HESAP TÜRÜ:";
            // 
            // txtHesapTur
            // 
            this.txtHesapTur.Location = new System.Drawing.Point(113, 342);
            this.txtHesapTur.Name = "txtHesapTur";
            this.txtHesapTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapTur.Properties.Appearance.Options.UseFont = true;
            this.txtHesapTur.Properties.MaxLength = 20;
            this.txtHesapTur.Size = new System.Drawing.Size(195, 24);
            this.txtHesapTur.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(59, 311);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 18);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "TARİH:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(47, 241);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(61, 18);
            this.labelControl13.TabIndex = 32;
            this.labelControl13.Text = "YETKİLİ:";
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(113, 238);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkili.Properties.Appearance.Options.UseFont = true;
            this.txtYetkili.Properties.MaxLength = 30;
            this.txtYetkili.Size = new System.Drawing.Size(195, 24);
            this.txtYetkili.TabIndex = 8;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(34, 209);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(74, 18);
            this.labelControl12.TabIndex = 30;
            this.labelControl12.Text = "HESAP NO:";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(113, 206);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapNo.Properties.Appearance.Options.UseFont = true;
            this.txtHesapNo.Properties.MaxLength = 20;
            this.txtHesapNo.Size = new System.Drawing.Size(195, 24);
            this.txtHesapNo.TabIndex = 7;
            // 
            // cmbBankaAdi
            // 
            this.cmbBankaAdi.Location = new System.Drawing.Point(113, 34);
            this.cmbBankaAdi.Name = "cmbBankaAdi";
            this.cmbBankaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBankaAdi.Properties.Appearance.Options.UseFont = true;
            this.cmbBankaAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBankaAdi.Properties.Items.AddRange(new object[] {
            "ZİRAAT BANKASI",
            "HALKBANK",
            "VAKIFBANK",
            "ALBARAKA TÜRK",
            "KUVEYT TÜRK",
            "TÜRKİYE FİNANS",
            "TEB",
            "AKBANK",
            "ŞEKERBANK",
            "İŞ BANKASI",
            "YAPI KIREDİ",
            "FİBABANKA",
            "GARANTİ ",
            "ING BANK",
            "QNB FİNANSBANK",
            "HSBC",
            "DENİZBANK",
            "ODEABANK",
            "A BANK"});
            this.cmbBankaAdi.Properties.MaxLength = 30;
            this.cmbBankaAdi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBankaAdi.Size = new System.Drawing.Size(195, 24);
            this.cmbBankaAdi.TabIndex = 2;
            // 
            // FormBankalar
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTemizle;
            this.ClientSize = new System.Drawing.Size(1364, 546);
            this.Controls.Add(this.grupKontrol);
            this.Controls.Add(this.gridBankalar);
            this.Name = "FormBankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.formBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxILCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxIL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankalar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupKontrol)).EndInit();
            this.grupKontrol.ResumeLayout(false);
            this.grupKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankaAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxILCE;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxIL;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private System.Windows.Forms.MaskedTextBox txtTarih;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBankalar1;
        private DevExpress.XtraGrid.GridControl gridBankalar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.GroupControl grupKontrol;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBankaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtHesapTur;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LookUpEdit lookUpFirma;
        private DevExpress.XtraEditors.TextEdit txtIban;
    }
}
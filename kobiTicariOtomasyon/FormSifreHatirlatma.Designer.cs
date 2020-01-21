namespace kobiTicariOtomasyon
{
    partial class FormSifreHatirlatma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSifreHatirlatma));
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.btnSifreBul = new DevExpress.XtraEditors.SimpleButton();
            this.chcGoster = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcGoster.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(145, 19);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Size = new System.Drawing.Size(140, 24);
            this.txtKullanici.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "GÜVENLİK KODU:";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(145, 49);
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.Properties.Appearance.Options.UseFont = true;
            this.txtKod.Size = new System.Drawing.Size(140, 24);
            this.txtKod.TabIndex = 2;
            // 
            // btnSifreBul
            // 
            this.btnSifreBul.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreBul.Appearance.Options.UseFont = true;
            this.btnSifreBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSifreBul.ImageOptions.Image")));
            this.btnSifreBul.Location = new System.Drawing.Point(145, 79);
            this.btnSifreBul.Name = "btnSifreBul";
            this.btnSifreBul.Size = new System.Drawing.Size(140, 28);
            this.btnSifreBul.TabIndex = 3;
            this.btnSifreBul.Text = "Şifreyi Bul";
            this.btnSifreBul.Click += new System.EventHandler(this.btnSifreBul_Click);
            // 
            // chcGoster
            // 
            this.chcGoster.Location = new System.Drawing.Point(291, 53);
            this.chcGoster.Name = "chcGoster";
            this.chcGoster.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcGoster.Properties.Appearance.Options.UseFont = true;
            this.chcGoster.Properties.Caption = "Gizle";
            this.chcGoster.Size = new System.Drawing.Size(75, 20);
            this.chcGoster.TabIndex = 4;
            this.chcGoster.CheckedChanged += new System.EventHandler(this.chcGoster_CheckedChanged);
            // 
            // FormSifreHatirlatma
            // 
            this.AcceptButton = this.btnSifreBul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(368, 124);
            this.Controls.Add(this.chcGoster);
            this.Controls.Add(this.btnSifreBul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSifreHatirlatma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞİFREMİ UNUTTUM";
            this.Load += new System.EventHandler(this.FormSifreHatirlatma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcGoster.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.SimpleButton btnSifreBul;
        private DevExpress.XtraEditors.CheckEdit chcGoster;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kobiTicariOtomasyon
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        FormUrunler urunForm; FormMusteriler musteriForm; FormFirmalar firmaForm; FormPersoneller personelForm;
        FormRehber rehberForm; FormGiderler giderForm; FormBankalar bankaForm; FormFaturalar faturaForm;
        FormNotlar notlarForm; FormHareketler hareketlerForm; FormStoklar stoklarForm; FormKasa kasaForm;
        FormAyarlar ayarlarForm; FormMdiAnasayfa anasayfaForm; FormRaporlar raporlarForm;

        internetBaglantisi internetbaglan = new internetBaglantisi();

        public string KullAdi;

        //ÜRÜNLER
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //form nesnesi açık değilse veya açılmış ama kapatılmışsa
            if (urunForm == null || urunForm.IsDisposed)
            {
                //ürünler modülünü form'a çekme
                urunForm = new FormUrunler();
                urunForm.MdiParent = this;
                urunForm.Show();
            }
        }

        //MÜŞTERİLER
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //form nesnesi açık değilse veya açılmış ama kapatılmışsa
            if (musteriForm == null || musteriForm.IsDisposed)
            {
                //müşteriler modülünü form'a çekme
                musteriForm = new FormMusteriler();
                musteriForm.MdiParent = this;
                musteriForm.Show();
            }
        }

        //FİRMALAR
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firmaForm == null || firmaForm.IsDisposed)
            {
                firmaForm = new FormFirmalar();
                firmaForm.MdiParent = this;
                firmaForm.Show();
            }
        }

        //PERSONELLER
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelForm == null || personelForm.IsDisposed)
            {
                personelForm = new FormPersoneller();
                personelForm.MdiParent = this;
                personelForm.Show();
            }
        }

        //REHBER
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehberForm == null || rehberForm.IsDisposed)
            {
                rehberForm = new FormRehber();
                rehberForm.MdiParent = this;
                rehberForm.Show();
            }
        }

        //GİDERLER
        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (giderForm == null || giderForm.IsDisposed)
            {
                giderForm = new FormGiderler();
                giderForm.MdiParent = this;
                giderForm.Show();
            }
        }

        //BANKALAR
        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankaForm == null || bankaForm.IsDisposed)
            {
                bankaForm = new FormBankalar();
                bankaForm.MdiParent = this;
                bankaForm.Show();
            }
        }

        //FATURALAR
        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (faturaForm == null || faturaForm.IsDisposed)
            {
                faturaForm = new FormFaturalar();
                faturaForm.MdiParent = this;
                faturaForm.Show();
            }
        }

        //NOTLAR
        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notlarForm == null || notlarForm.IsDisposed)
            {
                notlarForm = new FormNotlar();
                notlarForm.MdiParent = this;
                notlarForm.Show();
            }
        }

        //HAREKETLER
        private void btnHaraketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareketlerForm == null || hareketlerForm.IsDisposed)
            {
                hareketlerForm = new FormHareketler();
                hareketlerForm.MdiParent = this;
                hareketlerForm.Show();
            }
        }

        //RAPORLAR
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (raporlarForm == null || raporlarForm.IsDisposed)
            {
                raporlarForm = new FormRaporlar();
                raporlarForm.MdiParent = this;
                raporlarForm.Show();
            }
        }

        //STOKLAR
        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stoklarForm == null || stoklarForm.IsDisposed)
            {
                stoklarForm = new FormStoklar();
                stoklarForm.MdiParent = this;
                stoklarForm.Show();
            }
        }

        //AYARLAR
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ayarlarForm == null || ayarlarForm.IsDisposed)
            {
                ayarlarForm = new FormAyarlar();
                ayarlarForm.Show();
            }
        }

        //KASA
        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasaForm == null || kasaForm.IsDisposed)
            {
                kasaForm = new FormKasa();
                kasaForm.isim = KullAdi;
                kasaForm.MdiParent = this;
                kasaForm.Show();
            }
        }

        //ANASAYFA
        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasayfaForm==null || anasayfaForm.IsDisposed)
            {
                anasayfaForm = new FormMdiAnasayfa();
                anasayfaForm.MdiParent = this;
                anasayfaForm.Show();
            }
        }

        //FORM LOAD
        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            anasayfaForm = new FormMdiAnasayfa();
            anasayfaForm.MdiParent = this;
            anasayfaForm.Show();
            barisimSoyisim.Caption = KullAdi;

            if (internetbaglan.internet()==false)
                barBaglanti.Caption = "Bağlantı YOK";
            else
                barBaglanti.Caption = "Bağlı";

        }

        //Form Çıkış
        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

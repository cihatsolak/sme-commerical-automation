using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kobiTicariOtomasyon
{
    public partial class FormFaturalar : Form
    {
        public FormFaturalar()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        sqlBaglantisi database = new sqlBaglantisi();

        //Veri Listeleme
        void listele()
        {
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM TBLFATURABILGI", database.baglanti());
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            gridFaturalar.DataSource = tablo;
        }
        //Form Temizle
        void temizle()
        {
            TxtId.Text = ""; TxtSeri.Text = ""; TxtSira.Text = ""; TxtTeslimAlan.Text = ""; lookUpTeslimEden.EditValue = null; TxtTarih.Text = ""; TxtSaat.Text = ""; lookUpAlici.EditValue = null;
            TxtVergiDaire.Text = ""; TxtUrunAd.Text = ""; TxtAdet.Text = ""; TxtFiyat.Text = ""; TxtTutar.Text = ""; TxtFaturaId.Text = ""; cariTuru.Text = ""; TxtUrunId.Text = "";
            lookUpPersonel.EditValue = null; lookUpDegisken.EditValue = null;
        }
        
        // ------------- LOOKUP ----------
        //lookUp'a firma / Firma adı'na göre id çekme
        void firmalistesi()
        {
            SqlDataAdapter firma = new SqlDataAdapter("SELECT ID,AD AS 'FIRMA' FROM TBLFIRMALAR", database.baglanti());
            DataTable tablo = new DataTable();
            firma.Fill(tablo);
            lookUpDegisken.Properties.NullText = "Lütfen firma seçiniz.";
            lookUpDegisken.Properties.ValueMember = "ID";
            lookUpDegisken.Properties.DisplayMember = "FIRMA";
            lookUpDegisken.Properties.DataSource = tablo;

            lookUpAlici.Properties.NullText = "Lütfen firma seçiniz.";
            lookUpAlici.Properties.ValueMember = "ID";
            lookUpAlici.Properties.DisplayMember = "FIRMA";
            lookUpAlici.Properties.DataSource = tablo;
        }

        //lookUp'a firma / Firma adı'na göre id çekme
        void musterilistesi()
        {
            SqlDataAdapter firma = new SqlDataAdapter("SELECT ID,(AD+' '+SOYAD) AS 'MUSTERI' FROM TBLMUSTERILER", database.baglanti());
            DataTable tablo = new DataTable();
            firma.Fill(tablo);
            lookUpDegisken.Properties.NullText = "Lütfen müşteri seçiniz.";
            lookUpDegisken.Properties.ValueMember = "ID";
            lookUpDegisken.Properties.DisplayMember = "MUSTERI";
            lookUpDegisken.Properties.DataSource = tablo;

            lookUpAlici.Properties.NullText = "Lütfen müşteri seçiniz.";
            lookUpAlici.Properties.ValueMember = "ID";
            lookUpAlici.Properties.DisplayMember = "MUSTERI";
            lookUpAlici.Properties.DataSource = tablo;
        }
        void personellistesi()
        {
            SqlDataAdapter firma = new SqlDataAdapter("SELECT ID,(AD+' '+SOYAD) AS 'PERSONEL' FROM TBLPERSONELLER", database.baglanti());
            DataTable tablo = new DataTable();
            firma.Fill(tablo);

            lookUpPersonel.Properties.NullText = "Lütfen personel seçiniz.";
            lookUpPersonel.Properties.ValueMember = "ID";
            lookUpPersonel.Properties.DisplayMember = "PERSONEL";
            lookUpPersonel.Properties.DataSource = tablo;

            lookUpTeslimEden.Properties.NullText = "Lütfen personel seçiniz.";
            lookUpTeslimEden.Properties.ValueMember = "ID";
            lookUpTeslimEden.Properties.DisplayMember = "PERSONEL";
            lookUpTeslimEden.Properties.DataSource = tablo;
        }
        // ------------- LOOKUP ----------
        
        //FORM LOAD
        private void FormFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            personellistesi();
            gridFaturalar1.OptionsBehavior.Editable = false;
            gridFaturalar1.Columns["FATURABILGIID"].Visible = false;
        }

        //Grid'den kontrollere veri aktarma
        private void gridFaturalar1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow satir = gridFaturalar1.GetDataRow(gridFaturalar1.FocusedRowHandle);
            if (satir != null)
            {
                TxtFaturaId.Text = satir["FATURABILGIID"].ToString();
                TxtId.Text = satir["FATURABILGIID"].ToString();
                TxtSeri.Text = satir["SERI"].ToString();
                TxtSira.Text = satir["SIRANO"].ToString();
                TxtTarih.Text = satir["TARIH"].ToString();
                TxtSaat.Text = satir["SAAT"].ToString();
                TxtVergiDaire.Text = satir["VERGIDAIRE"].ToString();
                lookUpAlici.Text = satir["ALICI"].ToString();
                lookUpTeslimEden.Text = satir["TESLIMEDEN"].ToString();
                TxtTeslimAlan.Text = satir["TESLIMALAN"].ToString();

                if (satir["SERI"].ToString() == "A")
                    cariTuru.Text = "FİRMA";
                else if (satir["SERI"].ToString() == "B")
                    cariTuru.Text = "MÜŞTERİ";
            }
        }

        //Form Temizleme
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        //Fatura Kaydetme
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bilgiler kaydediliyor, emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (TxtFaturaId.Text == "")
                {
                    //Girilen fatura daha önce eklenmiş mi ?
                    SqlCommand siraKontrol = new SqlCommand("SELECT COUNT(SIRANO) FROM TBLFATURABILGI WHERE SIRANO='" + TxtSira.Text + "'", database.baglanti());
                    int sonuc = int.Parse(siraKontrol.ExecuteScalar().ToString());
                    if (sonuc < 1)
                    {
                        SqlCommand faturaKaydet = new SqlCommand("INSERT INTO TBLFATURABILGI(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", database.baglanti());
                        faturaKaydet.Parameters.AddWithValue("@p1", TxtSeri.Text.ToUpper());
                        faturaKaydet.Parameters.AddWithValue("@p2", TxtSira.Text.ToUpper());
                        faturaKaydet.Parameters.AddWithValue("@p3", TxtTarih.Text);
                        faturaKaydet.Parameters.AddWithValue("@p4", TxtSaat.Text);
                        faturaKaydet.Parameters.AddWithValue("@p5", TxtVergiDaire.Text.ToUpper());
                        faturaKaydet.Parameters.AddWithValue("@p6", lookUpAlici.Text);
                        faturaKaydet.Parameters.AddWithValue("@p7", lookUpTeslimEden.Text);
                        faturaKaydet.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text.ToUpper());
                        try
                        {
                            faturaKaydet.ExecuteNonQuery();
                            listele();
                            temizle();
                            MessageBox.Show("Fatura kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            database.baglanti().Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hata ** Fatura KAYDEDİLEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            database.baglanti().Close();
                        }
                    }
                    else
                        MessageBox.Show("Girelen sıra numarasına ait fatura mevcut!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Firma Carisi
                if (TxtFaturaId.Text != "" && cariTuru.Text == "FİRMA")
                {
                    double adet, tutar, fiyat;
                    fiyat = Convert.ToDouble(TxtFiyat.Text);
                    adet = Convert.ToDouble(TxtAdet.Text);
                    tutar = fiyat * adet;
                    TxtTutar.Text = tutar.ToString();

                    SqlCommand faturaUrunKaydet = new SqlCommand("INSERT INTO TBLFATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@p1,@p2,@p3,@p4,@p5)", database.baglanti());
                    faturaUrunKaydet.Parameters.AddWithValue("@p1", TxtUrunAd.Text.ToUpper());
                    faturaUrunKaydet.Parameters.AddWithValue("@p2", TxtAdet.Text);
                    faturaUrunKaydet.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                    faturaUrunKaydet.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                    faturaUrunKaydet.Parameters.AddWithValue("@p5", TxtFaturaId.Text);

                    //HAREKET TABLOSUNA VERİ GİRİŞİ
                    SqlCommand hareketEkle = new SqlCommand("INSERT INTO TBLFIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) VALUES (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", database.baglanti());
                    hareketEkle.Parameters.AddWithValue("@h1", TxtUrunId.Text);
                    hareketEkle.Parameters.AddWithValue("@h2", TxtAdet.Text);
                    hareketEkle.Parameters.AddWithValue("@h3", lookUpPersonel.EditValue);
                    hareketEkle.Parameters.AddWithValue("@h4", lookUpDegisken.EditValue);
                    hareketEkle.Parameters.AddWithValue("@h5", decimal.Parse(TxtFiyat.Text));
                    hareketEkle.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
                    hareketEkle.Parameters.AddWithValue("@h7", TxtFaturaId.Text);
                    hareketEkle.Parameters.AddWithValue("@h8", TxtTarih.Text);


                    //STOK AZALTMA
                    SqlCommand StokAzalt = new SqlCommand("UPDATE TBLURUNLER SET ADET=ADET-@p1 WHERE ID=@p2", database.baglanti());
                    StokAzalt.Parameters.AddWithValue("@p1", TxtAdet.Text);
                    StokAzalt.Parameters.AddWithValue("@p2", TxtUrunId.Text);

                    try
                    {
                        faturaUrunKaydet.ExecuteNonQuery();
                        hareketEkle.ExecuteNonQuery();
                        StokAzalt.ExecuteNonQuery();
                        listele();
                        temizle();
                        MessageBox.Show("Faturaya ait ürün kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        database.baglanti().Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata ** Faturaya ait ürün KAYDEDİLEMEDİ!" + hata, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        database.baglanti().Close();
                    }
                }
                //Müşteri Carisi
                if (TxtFaturaId.Text != "" && cariTuru.Text == "MÜŞTERİ")
                {
                    double adet, tutar, fiyat;
                    fiyat = Convert.ToDouble(TxtFiyat.Text);
                    adet = Convert.ToDouble(TxtAdet.Text);
                    tutar = fiyat * adet;
                    TxtTutar.Text = tutar.ToString();

                    SqlCommand faturaUrunKaydet = new SqlCommand("INSERT INTO TBLFATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@p1,@p2,@p3,@p4,@p5)", database.baglanti());
                    faturaUrunKaydet.Parameters.AddWithValue("@p1", TxtUrunAd.Text.ToUpper());
                    faturaUrunKaydet.Parameters.AddWithValue("@p2", TxtAdet.Text);
                    faturaUrunKaydet.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                    faturaUrunKaydet.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                    faturaUrunKaydet.Parameters.AddWithValue("@p5", TxtFaturaId.Text);

                    //HAREKET TABLOSUNA VERİ GİRİŞİ
                    SqlCommand hareketEkle = new SqlCommand("INSERT INTO TBLMUSTERIHAREKETLER (URUNID,ADET,PERSONEL,MUSTERI,FIYAT,TOPLAM,FATURAID,TARIH) VALUES (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", database.baglanti());
                    hareketEkle.Parameters.AddWithValue("@h1", TxtUrunId.Text);
                    hareketEkle.Parameters.AddWithValue("@h2", TxtAdet.Text);
                    hareketEkle.Parameters.AddWithValue("@h3", lookUpPersonel.EditValue);
                    hareketEkle.Parameters.AddWithValue("@h4", lookUpDegisken.EditValue);
                    hareketEkle.Parameters.AddWithValue("@h5", decimal.Parse(TxtFiyat.Text));
                    hareketEkle.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
                    hareketEkle.Parameters.AddWithValue("@h7", TxtFaturaId.Text);
                    hareketEkle.Parameters.AddWithValue("@h8", TxtTarih.Text);
                    database.baglanti().Close();

                    //STOK AZALTMA
                    SqlCommand StokAzalt = new SqlCommand("UPDATE TBLURUNLER SET ADET=ADET-@p1 WHERE ID=@p2", database.baglanti());
                    StokAzalt.Parameters.AddWithValue("@p1", TxtAdet.Text);
                    StokAzalt.Parameters.AddWithValue("@p2", TxtUrunId.Text);
                    StokAzalt.ExecuteNonQuery();
                    database.baglanti().Close();

                    try
                    {
                        faturaUrunKaydet.ExecuteNonQuery();
                        hareketEkle.ExecuteNonQuery();
                        listele();
                        temizle();
                        MessageBox.Show("Faturaya ait ürün kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        database.baglanti().Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata ** Faturaya ait ürün KAYDEDİLEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        database.baglanti().Close();
                    }
                }
            }
        }

        //Fatura Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Belirtilen fatura siliniyor, emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                SqlCommand faturaSil = new SqlCommand("DELETE FROM TBLFATURABILGI WHERE FATURABILGIID=@p1", database.baglanti());
                faturaSil.Parameters.AddWithValue("@p1", TxtId.Text);
                faturaSil.ExecuteNonQuery();
                listele();
                temizle();
                MessageBox.Show("Fatura silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.baglanti().Close();
                /*try
                {
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Fatura SİLİNEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    database.baglanti().Close();
                }*/
            }
        }

        //Fatura Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Belirtilen fatura güncelleniyor, emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                SqlCommand faturaGuncelle = new SqlCommand("UPDATE TBLFATURABILGI SET SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 WHERE FATURABILGIID=@p9", database.baglanti());
                faturaGuncelle.Parameters.AddWithValue("@p1", TxtSeri.Text.ToUpper());
                faturaGuncelle.Parameters.AddWithValue("@p2", TxtSira.Text.ToUpper());
                faturaGuncelle.Parameters.AddWithValue("@p3", TxtTarih.Text);
                faturaGuncelle.Parameters.AddWithValue("@p4", TxtSaat.Text);
                faturaGuncelle.Parameters.AddWithValue("@p5", TxtVergiDaire.Text.ToUpper());
                faturaGuncelle.Parameters.AddWithValue("@p6", lookUpAlici.Text);
                faturaGuncelle.Parameters.AddWithValue("@p7", lookUpTeslimEden.Text);
                faturaGuncelle.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text.ToUpper());
                faturaGuncelle.Parameters.AddWithValue("@p9", TxtId.Text);
                try
                {
                    faturaGuncelle.ExecuteNonQuery();
                    listele();
                    temizle();
                    MessageBox.Show("Fatura güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.baglanti().Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata ** Fatura GÜNCELLENEMEDİ!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    database.baglanti().Close();
                }
            }
        }

        //Faturadetay formuna id taşıma
        private void gridFaturalar1_DoubleClick(object sender, EventArgs e)
        {
            DataRow satir = gridFaturalar1.GetDataRow(gridFaturalar1.FocusedRowHandle);
            if (satir != null)
            {
                FormFaturaDetay detay = new FormFaturaDetay();
                detay.id = satir["FATURABILGIID"].ToString();
                detay.isim = satir["ALICI"].ToString();
                detay.Show();
            }
        }

        private void gridFaturalar_Click(object sender, EventArgs e)
        {

        }

        //Fatura Arama
        private void btnFaturaAra_Click(object sender, EventArgs e)
        {
            if (TxtSira.Text != "")
            {
                SqlCommand fatura = new SqlCommand("SELECT * FROM TBLFATURABILGI WHERE SIRANO='" + TxtSira.Text + "'", database.baglanti());
                SqlDataReader oku = fatura.ExecuteReader();
                if (oku.Read())
                {
                    TxtId.Text = oku["FATURABILGIID"].ToString();
                    TxtSeri.Text = oku["SERI"].ToString();
                    TxtSira.Text = oku["SIRANO"].ToString();
                    TxtTarih.Text = oku["TARIH"].ToString();
                    TxtSaat.Text = oku["SAAT"].ToString();
                    TxtVergiDaire.Text = oku["VERGIDAIRE"].ToString();
                    lookUpAlici.Text = oku["ALICI"].ToString();
                    lookUpTeslimEden.Text = oku["TESLIMEDEN"].ToString();
                    TxtTeslimAlan.Text = oku["TESLIMALAN"].ToString();
                    TxtFaturaId.Text = oku["FATURABILGIID"].ToString();
                }
                else
                    MessageBox.Show("Girilen numaraya ait fatura bulunamamaktadır!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen seri numarasını giriniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Ürün id ye göre kontrollere bilgi çekme
        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            SqlCommand urunBul = new SqlCommand("SELECT URUNAD, SATISFIYAT FROM TBLURUNLER WHERE ID='" + TxtUrunId.Text + "'", database.baglanti());
            SqlDataReader oku = urunBul.ExecuteReader();
            if (oku.Read())
            {
                TxtUrunAd.Text = oku["URUNAD"].ToString();
                TxtFiyat.Text = oku["SATISFIYAT"].ToString();
            }
            else
                MessageBox.Show("Ürün Bulunamadı!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            database.baglanti().Close();
        }

        private void cariTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cariTuru.Text == "MÜŞTERİ")
            {
                TxtSeri.Text = "B";
                lblDegisken.Text = "MÜŞTERİ:";
                lookUpAlici.Properties.Columns.Clear();
                lookUpDegisken.Properties.Columns.Clear();
                musterilistesi();
            }
            if (cariTuru.Text == "FİRMA")
            {
                TxtSeri.Text = "A";
                lblDegisken.Text = "FİRMA:";
                lookUpAlici.Properties.Columns.Clear();
                lookUpDegisken.Properties.Columns.Clear();
                firmalistesi();
            }
        }
    }
}

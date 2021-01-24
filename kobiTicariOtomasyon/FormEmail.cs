using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kobiTicariOtomasyon
{
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        public string mailAdresi;
        internetBaglantisi dataConnection = new internetBaglantisi();

        private void formEmail_Load(object sender, EventArgs e)
        {
            txtMailAdres.Text = mailAdresi;
            txtKonu.Focus();

            //İnternet Kontrolü
            
            if (dataConnection.internet()==false)
            {
                lblbaglanti.Text = "KAPALI";
                lblbaglanti.ForeColor = Color.Red;
            }
        }

        //MAİL GÖNDERME
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (dataConnection.internet())
            {
               if (txtKonu.Text != "" && txtIcerik.Text != "")
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient istemci = new SmtpClient();
                    istemci.Credentials = new System.Net.NetworkCredential("*****", "****");
                    istemci.Port = 587;
                    istemci.Host = "smtp.live.com";
                    istemci.EnableSsl = true;
                    mail.To.Add(txtMailAdres.Text);
                    mail.From = new MailAddress("kobiticariotomasyon@hotmail.com");
                    mail.Subject = txtKonu.Text;
                    mail.Body = txtIcerik.Text;

                    try
                    {
                        istemci.Send(mail);
                        MessageBox.Show("Mail Gönderildi!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("SMTP posta sunucusunda problem var!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Lütfen boş alanları doldurunuz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("İnternet baglantınızı kontrol ediniz!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace mail
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofdAttachment;
        String fileName = ""; //Attachment1'in encode edilip sting değerinin yazılacağı degisken

        OpenFileDialog ofdAttachment2;
        String fileName2 = ""; //Attachment2'in encode edilip string değerinin yazılacağı degisken


        public Form1()
        {
            InitializeComponent();
        }

        private void AttachmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf"; /* uygulmaya dosya yüklerken uygualan filtre sde resim ve pdf dosyaları kabul edilecek
                                                                                           whitelist mantığı*/
                ofdAttachment.Multiselect = false; //bu butonu kullanarak kullanıcı uygulamaya 1 adet attachment ekleyebilecek.  
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofdAttachment.FileName;
                        attachmentFileOutput1.Text = fileName.ToString(); //seçtiğimiz ekin yolunu ekrana yazdıran kod
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void attachmentButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment2 = new OpenFileDialog();
                ofdAttachment2.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf"; //uygulmaya dosya yüklerken uygualan filtre sde resim ve pdf dosyaları kabul edilecek
                ofdAttachment2.Multiselect = false;
                if (ofdAttachment2.ShowDialog() == DialogResult.OK)
                    {
                        fileName2 = ofdAttachment2.FileName;
                        attachmentFileOutput2.Text = fileName2.ToString();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void EnableMailList_CheckedChanged(object sender, EventArgs e)
        {
            if (enableMailList.Checked == true)
                {
                chooseFileButton.Visible = true; //True ise buton görünür hale gelir.
                chooseFileComment.Visible = true; //True ise yönlendirme metni görünür hale gelir.
                chooseFileOutput.Visible = true; //True ise dosya seçtiğimizde seçilen dosya görünür hale gelir.
                recipientMail.Visible = false; //false ise label görünmez hale gelir.
                recipientBox.Visible = false; //false ise textbox görünmez hale gelir.
                }
            else if (enableMailList.Checked == false)
                {
                chooseFileButton.Visible = false; //True ise buton görünür hale gelir.
                chooseFileComment.Visible = false; //True ise yönlendirme metni görünür hale gelir.
                chooseFileOutput.Visible = false; //True ise dosya seçtiğimizde seçilen dosya görünür hale gelir.
                recipientMail.Visible = true; //false ise label görünmez hale gelir.
                recipientBox.Visible = true; //false ise textbox görünmez hale gelir.
                }
            
        }

        private void SenderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Smpt client bilgileri
                //gmail >> smtp server : smtp.gmail.com, port : 587
                //yahoo >> smtp server : smtp.mail.yahoo.com, port : 587
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(portBox.Text.Trim()); // port numarasını stringe çeviriyor.
                clientDetails.Host = smtpBox.Text.Trim(); //hangi smtp serveri kullanacakrsak onu tanımladığımız alan
                clientDetails.EnableSsl = sslBox.Checked; // mail gönderirken ssl kullanmalıyız. Bu yüzden bu seçeneğin aktif olması gerekiyor.
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network; /* Mailin ağ üzerinden smtp sunucusuna göndermek için kulandığıız kod.
                                                                             farklı metodlar için 
                https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.smtpdeliverymethod?source=recommendations&view=net-7.0 ziyaret edebilirsiniz */
                clientDetails.UseDefaultCredentials = false; /* smtp sunucusuna bağlanırken kimlik bilgilerini bizim uygulamada ayarladığımız değerler olsun diye false yaptık.
                                                              https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient.usedefaultcredentials?view=net-7.0 
                daha detaylı bilgi için ziyaret edebilirsiniz.*/
                clientDetails.Credentials = new NetworkCredential(mailBox.Text.Trim(), passwordBox.Text.Trim()); //yukarıda bahsettiğim credential bilgilerinin tanımlamasnı yaptığımız alan

                //Mesaj detayları
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(mailBox.Text.Trim()); //mail kimden gönderilecek
                mailDetails.To.Add(recipientBox.Text.Trim()); //mail kime gönderilecek.

                mailDetails.Subject = mailSubjectBox.Text.Trim(); //mail konusu
                mailDetails.Body = messageBox.Text.Trim(); // mailin body kısmı (ne yazılacaksa..)


                //Mail eki
                if (fileName.Length > 0)
                    {
                        Attachment attachment = new Attachment(fileName);
                        mailDetails.Attachments.Add(attachment);
                        Attachment attachment2 = new Attachment(fileName2);
                        mailDetails.Attachments.Add(attachment2);
                }

                clientDetails.Send(mailDetails);
                MessageBox.Show("Mail gönderildi."); //mail gönderildikten sonra bize gösterilecek mesaj
                fileName = "";
                fileName2 = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //herhangi bir sorunla karşıaşılırsa bize hata mesajını gösterek
            }
        }

        private void chooseFileButton_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.Show(); //Birden çok kişiye mail göndermek istediğimizde diğer form uygulamasına geçmek için kullanıyoruz.
            this.Hide();
        }


    }
}

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
    public partial class Form2 : Form
    {

        OpenFileDialog ofdAttachment3;
        string fileName3 = ""; //Attachment3'ü encode edilip string değerinin yazılacağı degisken

        OpenFileDialog ofdAttachment4;
        string fileName4 = ""; //Attachment4'ü encode edilip string değerinin yazılacağı degisken

        public Form2()
        {
            InitializeComponent();
        }

        private void attachmentButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment3 = new OpenFileDialog();
                ofdAttachment3.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf"; /* uygulmaya dosya yüklerken uygualan filtre sde resim ve pdf dosyaları kabul edilecek
                                                                                           whitelist mantığı*/
                ofdAttachment3.Multiselect = false; //bu butonu kullanarak kullanıcı uygulamaya 1 adet attachment ekleyebilecek.
                if (ofdAttachment3.ShowDialog() == DialogResult.OK)
                {
                    fileName3 = ofdAttachment3.FileName;
                    attachmentFileOutput3.Text = fileName3.ToString(); //seçtiğimiz ekin yolunu ekrana yazdıran kod
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void attachmentButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment4 = new OpenFileDialog();
                ofdAttachment4.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf"; /* uygulmaya dosya yüklerken uygualan filtre sde resim ve pdf dosyaları kabul edilecek
                                                                                           whitelist mantığı*/
                ofdAttachment4.Multiselect = false; //bu butonu kullanarak kullanıcı uygulamaya 1 adet attachment ekleyebilecek.
                if (ofdAttachment4.ShowDialog() == DialogResult.OK)
                {
                    fileName4 = ofdAttachment4.FileName;
                    attachmentFileOutput4.Text = fileName4.ToString(); //seçtiğimiz ekin yolunu ekrana yazdıran kod
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openMailList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;

            DialogResult dr = openFile.ShowDialog();
            if (dr == DialogResult.OK)
                {
                System.IO.StreamReader file = new System.IO.StreamReader(openFile.FileName);
                string line;
                while ((line = file.ReadLine()) != null) //içerisinde mailler bulunan mail listi uygulamaın içine aktatan döngü
                {
                    varMailList.Items.Add(line); 
                    }
                file.Close();     
                }
        }

        private void clear_Click(object sender, EventArgs e) //uygulamanın içerisine aktardığımız mailleri temizlemek istediğimizde kullanacağımız buton
        {
            varMailList.Items.Clear(); 
        }

        private void okay_Click(object sender, EventArgs e) //arkaplanda çalışması için tanımladığımız workeri çalıştıran buton
        {
            okay.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }



        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) //worker başarıyla çalışıp sonlandığında bize gösterilecek mesaj.
        {
            okay.Enabled = true;
                                MessageBox.Show("Mail gönderildi.");
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            try
            {
                /*
                 * Bu kısımda smtp sunucusuyla ilgili yapılandırmamız gereken işlemlerin tanımlandığı alan
                 */
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(portBox2.Text.Trim()); // port numarasını stringe çeviriyor.
                clientDetails.Host = smtpBox2.Text.Trim(); //hangi smtp serveri kullanacakrsak onu tanımladığımız alan
                clientDetails.EnableSsl = sslBox2.Checked; // mail gönderirken ssl kullanmalıyız. Bu yüzden bu seçeneğin aktif olması gerekiyor.
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network; /* Mailin ağ üzerinden smtp sunucusuna göndermek için kulandığıız kod.
                                                                             farklı metodlar için 
                https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.smtpdeliverymethod?source=recommendations&view=net-7.0 ziyaret edebilirsiniz */
                clientDetails.UseDefaultCredentials = false; /* smtp sunucusuna bağlanırken kimlik bilgilerini bizim uygulamada ayarladığımız değerler olsun diye false yaptık.
                                                              https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient.usedefaultcredentials?view=net-7.0 
                daha detaylı bilgi için ziyaret edebilirsiniz.*/
                clientDetails.Credentials = new NetworkCredential(mailBox2.Text.Trim(), passwordBox2.Text.Trim());  //yukarıda bahsettiğim credential bilgilerinin tanımlamasnı yaptığımız alan

                //Mesaj detayları
                MailMessage mailDetails = new MailMessage(); 
                mailDetails.From = new MailAddress(mailBox2.Text.Trim()); //mail kimden gönderilecek

                mailDetails.Subject = mailSubjectBox2.Text.Trim(); //meajın konusunu tanımladığımız alan
                mailDetails.Body = messageBox2.Text.Trim(); // mail body kısmı (ne yazılacaksa artık..)

                foreach (string mail in varMailList.Items) //uygulama içerisine aktardığımız maillere sırayla mailleri gönderen döngü 
                {
                    mailDetails.To.Add(new MailAddress(mail));                 
                }

                string[] attachments = {fileName3, fileName4 };

                foreach (string attachment in attachments) //uygulama içerisine aktardığımız mail eklerini gönderen döngü 
                {
                    mailDetails.Attachments.Add(new Attachment(attachment));
                }

                clientDetails.Send(mailDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//herhangi bir sorunla karşıaşılırsa bize hata mesajını gösterecek
            }
        }

        private void App1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //Tek kişiye mail göndermek istediğimizde diğer form uygulamasına geçmek için kullanıyoruz.
            this.Hide();
        }
    }
}

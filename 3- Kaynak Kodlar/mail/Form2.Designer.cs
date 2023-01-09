
namespace mail
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.varMailList = new System.Windows.Forms.ListBox();
            this.openMailList = new System.Windows.Forms.Button();
            this.okay = new System.Windows.Forms.Button();
            this.senderDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sslBox2 = new System.Windows.Forms.CheckBox();
            this.portComment = new System.Windows.Forms.Label();
            this.smtpComment = new System.Windows.Forms.Label();
            this.passwordComment = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.Label();
            this.smtpServer = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.senderMail = new System.Windows.Forms.Label();
            this.portBox2 = new System.Windows.Forms.TextBox();
            this.smtpBox2 = new System.Windows.Forms.TextBox();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.mailBox2 = new System.Windows.Forms.TextBox();
            this.mailDetails = new System.Windows.Forms.GroupBox();
            this.attachmentFileOutput4 = new System.Windows.Forms.Label();
            this.attachmentButton4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.attachmentFileOutput3 = new System.Windows.Forms.Label();
            this.attachment = new System.Windows.Forms.Label();
            this.attachmentButton3 = new System.Windows.Forms.Button();
            this.mailSubject = new System.Windows.Forms.Label();
            this.mailSubjectBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.messageBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clear = new System.Windows.Forms.Button();
            this.App1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.senderDetails.SuspendLayout();
            this.mailDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.varMailList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcı Listesi";
            // 
            // varMailList
            // 
            this.varMailList.FormattingEnabled = true;
            this.varMailList.ItemHeight = 16;
            this.varMailList.Location = new System.Drawing.Point(10, 25);
            this.varMailList.Name = "varMailList";
            this.varMailList.Size = new System.Drawing.Size(352, 308);
            this.varMailList.TabIndex = 0;
            // 
            // openMailList
            // 
            this.openMailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.openMailList.Location = new System.Drawing.Point(421, 460);
            this.openMailList.Name = "openMailList";
            this.openMailList.Size = new System.Drawing.Size(173, 57);
            this.openMailList.TabIndex = 1;
            this.openMailList.Text = "İçe Aktar";
            this.openMailList.UseVisualStyleBackColor = true;
            this.openMailList.Click += new System.EventHandler(this.openMailList_Click);
            // 
            // okay
            // 
            this.okay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okay.Location = new System.Drawing.Point(421, 625);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(173, 57);
            this.okay.TabIndex = 2;
            this.okay.Text = "Gönder";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // senderDetails
            // 
            this.senderDetails.Controls.Add(this.label4);
            this.senderDetails.Controls.Add(this.label3);
            this.senderDetails.Controls.Add(this.label1);
            this.senderDetails.Controls.Add(this.sslBox2);
            this.senderDetails.Controls.Add(this.portComment);
            this.senderDetails.Controls.Add(this.smtpComment);
            this.senderDetails.Controls.Add(this.passwordComment);
            this.senderDetails.Controls.Add(this.portNumber);
            this.senderDetails.Controls.Add(this.smtpServer);
            this.senderDetails.Controls.Add(this.password);
            this.senderDetails.Controls.Add(this.senderMail);
            this.senderDetails.Controls.Add(this.portBox2);
            this.senderDetails.Controls.Add(this.smtpBox2);
            this.senderDetails.Controls.Add(this.passwordBox2);
            this.senderDetails.Controls.Add(this.mailBox2);
            this.senderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.senderDetails.Location = new System.Drawing.Point(13, 13);
            this.senderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.senderDetails.Name = "senderDetails";
            this.senderDetails.Padding = new System.Windows.Forms.Padding(4);
            this.senderDetails.Size = new System.Drawing.Size(559, 330);
            this.senderDetails.TabIndex = 3;
            this.senderDetails.TabStop = false;
            this.senderDetails.Text = "Gönderici Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(278, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Örn: 587  ya da 465";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(238, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Örn: smtp.gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(278, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "* Gerekli";
            // 
            // sslBox2
            // 
            this.sslBox2.AutoSize = true;
            this.sslBox2.Location = new System.Drawing.Point(268, 287);
            this.sslBox2.Name = "sslBox2";
            this.sslBox2.Size = new System.Drawing.Size(114, 20);
            this.sslBox2.TabIndex = 11;
            this.sslBox2.Text = "SSL Kullanılsın";
            this.sslBox2.UseVisualStyleBackColor = true;
            // 
            // portComment
            // 
            this.portComment.AutoSize = true;
            this.portComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portComment.ForeColor = System.Drawing.Color.Teal;
            this.portComment.Location = new System.Drawing.Point(132, 250);
            this.portComment.Name = "portComment";
            this.portComment.Size = new System.Drawing.Size(184, 30);
            this.portComment.TabIndex = 10;
            this.portComment.Text = "* Kullanılan SMTP sunucusunun\r\nport numarası yazılacaktır.\r\n";
            // 
            // smtpComment
            // 
            this.smtpComment.AutoSize = true;
            this.smtpComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smtpComment.ForeColor = System.Drawing.Color.Teal;
            this.smtpComment.Location = new System.Drawing.Point(132, 179);
            this.smtpComment.Name = "smtpComment";
            this.smtpComment.Size = new System.Drawing.Size(187, 30);
            this.smtpComment.TabIndex = 9;
            this.smtpComment.Text = "* Kullanılan SMTP sunucusunun \r\nadresi yazılacaktır.";
            // 
            // passwordComment
            // 
            this.passwordComment.AutoSize = true;
            this.passwordComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordComment.ForeColor = System.Drawing.Color.Teal;
            this.passwordComment.Location = new System.Drawing.Point(132, 113);
            this.passwordComment.Name = "passwordComment";
            this.passwordComment.Size = new System.Drawing.Size(131, 15);
            this.passwordComment.TabIndex = 8;
            this.passwordComment.Text = "* Gmailden alınacaktır.";
            // 
            // portNumber
            // 
            this.portNumber.AutoSize = true;
            this.portNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portNumber.Location = new System.Drawing.Point(132, 227);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(116, 18);
            this.portNumber.TabIndex = 7;
            this.portNumber.Text = "Port Numarası  :";
            // 
            // smtpServer
            // 
            this.smtpServer.AutoSize = true;
            this.smtpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smtpServer.Location = new System.Drawing.Point(116, 155);
            this.smtpServer.Name = "smtpServer";
            this.smtpServer.Size = new System.Drawing.Size(132, 18);
            this.smtpServer.TabIndex = 6;
            this.smtpServer.Text = "SMTP Sunucusu  :";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(119, 91);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(129, 18);
            this.password.TabIndex = 5;
            this.password.Text = "Uygulama şifresi  :";
            // 
            // senderMail
            // 
            this.senderMail.AutoSize = true;
            this.senderMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.senderMail.Location = new System.Drawing.Point(108, 30);
            this.senderMail.Name = "senderMail";
            this.senderMail.Size = new System.Drawing.Size(140, 18);
            this.senderMail.TabIndex = 4;
            this.senderMail.Text = "Gönderici E-posta  :";
            // 
            // portBox2
            // 
            this.portBox2.Location = new System.Drawing.Point(268, 225);
            this.portBox2.Name = "portBox2";
            this.portBox2.Size = new System.Drawing.Size(272, 22);
            this.portBox2.TabIndex = 3;
            // 
            // smtpBox2
            // 
            this.smtpBox2.Location = new System.Drawing.Point(268, 154);
            this.smtpBox2.Name = "smtpBox2";
            this.smtpBox2.Size = new System.Drawing.Size(272, 22);
            this.smtpBox2.TabIndex = 2;
            // 
            // passwordBox2
            // 
            this.passwordBox2.Location = new System.Drawing.Point(268, 90);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.PasswordChar = '*';
            this.passwordBox2.Size = new System.Drawing.Size(272, 22);
            this.passwordBox2.TabIndex = 1;
            this.passwordBox2.UseSystemPasswordChar = true;
            // 
            // mailBox2
            // 
            this.mailBox2.Location = new System.Drawing.Point(268, 29);
            this.mailBox2.Name = "mailBox2";
            this.mailBox2.Size = new System.Drawing.Size(272, 22);
            this.mailBox2.TabIndex = 0;
            // 
            // mailDetails
            // 
            this.mailDetails.Controls.Add(this.attachmentFileOutput4);
            this.mailDetails.Controls.Add(this.attachmentButton4);
            this.mailDetails.Controls.Add(this.label2);
            this.mailDetails.Controls.Add(this.attachmentFileOutput3);
            this.mailDetails.Controls.Add(this.attachment);
            this.mailDetails.Controls.Add(this.attachmentButton3);
            this.mailDetails.Controls.Add(this.mailSubject);
            this.mailDetails.Controls.Add(this.mailSubjectBox2);
            this.mailDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailDetails.Location = new System.Drawing.Point(623, 13);
            this.mailDetails.Margin = new System.Windows.Forms.Padding(4);
            this.mailDetails.Name = "mailDetails";
            this.mailDetails.Padding = new System.Windows.Forms.Padding(4);
            this.mailDetails.Size = new System.Drawing.Size(714, 242);
            this.mailDetails.TabIndex = 4;
            this.mailDetails.TabStop = false;
            this.mailDetails.Text = "E-Posta Detayları";
            // 
            // attachmentFileOutput4
            // 
            this.attachmentFileOutput4.AutoSize = true;
            this.attachmentFileOutput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentFileOutput4.ForeColor = System.Drawing.Color.Teal;
            this.attachmentFileOutput4.Location = new System.Drawing.Point(53, 219);
            this.attachmentFileOutput4.Name = "attachmentFileOutput4";
            this.attachmentFileOutput4.Size = new System.Drawing.Size(0, 13);
            this.attachmentFileOutput4.TabIndex = 7;
            // 
            // attachmentButton4
            // 
            this.attachmentButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentButton4.Location = new System.Drawing.Point(305, 134);
            this.attachmentButton4.Name = "attachmentButton4";
            this.attachmentButton4.Size = new System.Drawing.Size(207, 60);
            this.attachmentButton4.TabIndex = 6;
            this.attachmentButton4.Text = "Dosya Seçiniz";
            this.attachmentButton4.UseVisualStyleBackColor = true;
            this.attachmentButton4.Click += new System.EventHandler(this.attachmentButton4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-posta eki seçiniz  :";
            // 
            // attachmentFileOutput3
            // 
            this.attachmentFileOutput3.AutoSize = true;
            this.attachmentFileOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentFileOutput3.ForeColor = System.Drawing.Color.Teal;
            this.attachmentFileOutput3.Location = new System.Drawing.Point(53, 200);
            this.attachmentFileOutput3.Name = "attachmentFileOutput3";
            this.attachmentFileOutput3.Size = new System.Drawing.Size(0, 13);
            this.attachmentFileOutput3.TabIndex = 4;
            // 
            // attachment
            // 
            this.attachment.AutoSize = true;
            this.attachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachment.Location = new System.Drawing.Point(118, 83);
            this.attachment.Name = "attachment";
            this.attachment.Size = new System.Drawing.Size(145, 18);
            this.attachment.TabIndex = 3;
            this.attachment.Text = "E-posta eki seçiniz  :";
            // 
            // attachmentButton3
            // 
            this.attachmentButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentButton3.Location = new System.Drawing.Point(305, 62);
            this.attachmentButton3.Name = "attachmentButton3";
            this.attachmentButton3.Size = new System.Drawing.Size(207, 60);
            this.attachmentButton3.TabIndex = 2;
            this.attachmentButton3.Text = "Dosya Seçiniz";
            this.attachmentButton3.UseVisualStyleBackColor = true;
            this.attachmentButton3.Click += new System.EventHandler(this.attachmentButton3_Click);
            // 
            // mailSubject
            // 
            this.mailSubject.AutoSize = true;
            this.mailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailSubject.Location = new System.Drawing.Point(118, 23);
            this.mailSubject.Name = "mailSubject";
            this.mailSubject.Size = new System.Drawing.Size(127, 18);
            this.mailSubject.TabIndex = 1;
            this.mailSubject.Text = "E-posta Konusu  :";
            // 
            // mailSubjectBox2
            // 
            this.mailSubjectBox2.Location = new System.Drawing.Point(268, 22);
            this.mailSubjectBox2.Name = "mailSubjectBox2";
            this.mailSubjectBox2.Size = new System.Drawing.Size(272, 22);
            this.mailSubjectBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(623, 263);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(714, 435);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mesaj";
            // 
            // messageBox2
            // 
            this.messageBox2.Location = new System.Drawing.Point(8, 22);
            this.messageBox2.Multiline = true;
            this.messageBox2.Name = "messageBox2";
            this.messageBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.messageBox2.Size = new System.Drawing.Size(698, 397);
            this.messageBox2.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear.Location = new System.Drawing.Point(421, 525);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(173, 57);
            this.clear.TabIndex = 6;
            this.clear.Text = "Temizle";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // App1
            // 
            this.App1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.App1.Location = new System.Drawing.Point(421, 360);
            this.App1.Name = "App1";
            this.App1.Size = new System.Drawing.Size(173, 57);
            this.App1.TabIndex = 7;
            this.App1.Text = "Uygulama 1";
            this.App1.UseVisualStyleBackColor = true;
            this.App1.Click += new System.EventHandler(this.App1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.App1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mailDetails);
            this.Controls.Add(this.senderDetails);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.openMailList);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Otomatik E-posta Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.senderDetails.ResumeLayout(false);
            this.senderDetails.PerformLayout();
            this.mailDetails.ResumeLayout(false);
            this.mailDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openMailList;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.ListBox varMailList;
        private System.Windows.Forms.GroupBox senderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sslBox2;
        private System.Windows.Forms.Label portComment;
        private System.Windows.Forms.Label smtpComment;
        private System.Windows.Forms.Label passwordComment;
        private System.Windows.Forms.Label portNumber;
        private System.Windows.Forms.Label smtpServer;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label senderMail;
        private System.Windows.Forms.TextBox portBox2;
        private System.Windows.Forms.TextBox smtpBox2;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.TextBox mailBox2;
        private System.Windows.Forms.GroupBox mailDetails;
        private System.Windows.Forms.Label attachmentFileOutput3;
        private System.Windows.Forms.Label attachment;
        private System.Windows.Forms.Button attachmentButton3;
        private System.Windows.Forms.Label mailSubject;
        private System.Windows.Forms.TextBox mailSubjectBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label attachmentFileOutput4;
        private System.Windows.Forms.Button attachmentButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button App1;
    }
}
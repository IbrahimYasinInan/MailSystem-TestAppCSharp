namespace mail
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.senderDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sslBox = new System.Windows.Forms.CheckBox();
            this.portComment = new System.Windows.Forms.Label();
            this.smtpComment = new System.Windows.Forms.Label();
            this.passwordComment = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.Label();
            this.smtpServer = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.senderMail = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.smtpBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.recipientList = new System.Windows.Forms.GroupBox();
            this.enableMailList = new System.Windows.Forms.CheckBox();
            this.recipientMail = new System.Windows.Forms.Label();
            this.recipientBox = new System.Windows.Forms.TextBox();
            this.chooseFileOutput = new System.Windows.Forms.Label();
            this.chooseFileComment = new System.Windows.Forms.Label();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.mailDetails = new System.Windows.Forms.GroupBox();
            this.attachmentButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.attachmentFileOutput2 = new System.Windows.Forms.Label();
            this.attachmentFileOutput1 = new System.Windows.Forms.Label();
            this.attachment = new System.Windows.Forms.Label();
            this.attachmentButton = new System.Windows.Forms.Button();
            this.mailSubject = new System.Windows.Forms.Label();
            this.mailSubjectBox = new System.Windows.Forms.TextBox();
            this.SenderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.senderDetails.SuspendLayout();
            this.recipientList.SuspendLayout();
            this.mailDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // senderDetails
            // 
            this.senderDetails.Controls.Add(this.label4);
            this.senderDetails.Controls.Add(this.label2);
            this.senderDetails.Controls.Add(this.label1);
            this.senderDetails.Controls.Add(this.sslBox);
            this.senderDetails.Controls.Add(this.portComment);
            this.senderDetails.Controls.Add(this.smtpComment);
            this.senderDetails.Controls.Add(this.passwordComment);
            this.senderDetails.Controls.Add(this.portNumber);
            this.senderDetails.Controls.Add(this.smtpServer);
            this.senderDetails.Controls.Add(this.password);
            this.senderDetails.Controls.Add(this.senderMail);
            this.senderDetails.Controls.Add(this.portBox);
            this.senderDetails.Controls.Add(this.smtpBox);
            this.senderDetails.Controls.Add(this.passwordBox);
            this.senderDetails.Controls.Add(this.mailBox);
            this.senderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.senderDetails.Location = new System.Drawing.Point(16, 15);
            this.senderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.senderDetails.Name = "senderDetails";
            this.senderDetails.Padding = new System.Windows.Forms.Padding(4);
            this.senderDetails.Size = new System.Drawing.Size(559, 330);
            this.senderDetails.TabIndex = 0;
            this.senderDetails.TabStop = false;
            this.senderDetails.Text = "Gönderici Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(281, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Örn: 587  ya da 465";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(240, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Örn: smtp.gmail.com";
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
            // sslBox
            // 
            this.sslBox.AutoSize = true;
            this.sslBox.Location = new System.Drawing.Point(268, 287);
            this.sslBox.Name = "sslBox";
            this.sslBox.Size = new System.Drawing.Size(114, 20);
            this.sslBox.TabIndex = 11;
            this.sslBox.Text = "SSL Kullanılsın";
            this.sslBox.UseVisualStyleBackColor = true;
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
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(268, 225);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(272, 22);
            this.portBox.TabIndex = 3;
            // 
            // smtpBox
            // 
            this.smtpBox.Location = new System.Drawing.Point(268, 154);
            this.smtpBox.Name = "smtpBox";
            this.smtpBox.Size = new System.Drawing.Size(272, 22);
            this.smtpBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(268, 90);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(272, 22);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(268, 29);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(272, 22);
            this.mailBox.TabIndex = 0;
            // 
            // recipientList
            // 
            this.recipientList.Controls.Add(this.enableMailList);
            this.recipientList.Controls.Add(this.recipientMail);
            this.recipientList.Controls.Add(this.recipientBox);
            this.recipientList.Controls.Add(this.chooseFileOutput);
            this.recipientList.Controls.Add(this.chooseFileComment);
            this.recipientList.Controls.Add(this.chooseFileButton);
            this.recipientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipientList.Location = new System.Drawing.Point(16, 429);
            this.recipientList.Margin = new System.Windows.Forms.Padding(4);
            this.recipientList.Name = "recipientList";
            this.recipientList.Padding = new System.Windows.Forms.Padding(4);
            this.recipientList.Size = new System.Drawing.Size(559, 166);
            this.recipientList.TabIndex = 1;
            this.recipientList.TabStop = false;
            this.recipientList.Text = "Alıcı Listesi";
            // 
            // enableMailList
            // 
            this.enableMailList.AutoSize = true;
            this.enableMailList.Location = new System.Drawing.Point(7, 22);
            this.enableMailList.Name = "enableMailList";
            this.enableMailList.Size = new System.Drawing.Size(310, 20);
            this.enableMailList.TabIndex = 7;
            this.enableMailList.Text = "Birden çok kişiye E-posta göndermek istiyorum.";
            this.enableMailList.UseVisualStyleBackColor = true;
            this.enableMailList.CheckedChanged += new System.EventHandler(this.EnableMailList_CheckedChanged);
            // 
            // recipientMail
            // 
            this.recipientMail.AutoSize = true;
            this.recipientMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipientMail.Location = new System.Drawing.Point(101, 56);
            this.recipientMail.Name = "recipientMail";
            this.recipientMail.Size = new System.Drawing.Size(147, 18);
            this.recipientMail.TabIndex = 5;
            this.recipientMail.Text = "Alıcı E-posta Adresi  :";
            // 
            // recipientBox
            // 
            this.recipientBox.Location = new System.Drawing.Point(268, 55);
            this.recipientBox.Name = "recipientBox";
            this.recipientBox.Size = new System.Drawing.Size(272, 22);
            this.recipientBox.TabIndex = 4;
            // 
            // chooseFileOutput
            // 
            this.chooseFileOutput.AutoSize = true;
            this.chooseFileOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chooseFileOutput.ForeColor = System.Drawing.Color.Teal;
            this.chooseFileOutput.Location = new System.Drawing.Point(37, 135);
            this.chooseFileOutput.Name = "chooseFileOutput";
            this.chooseFileOutput.Size = new System.Drawing.Size(0, 13);
            this.chooseFileOutput.TabIndex = 2;
            // 
            // chooseFileComment
            // 
            this.chooseFileComment.AutoSize = true;
            this.chooseFileComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chooseFileComment.ForeColor = System.Drawing.Color.Teal;
            this.chooseFileComment.Location = new System.Drawing.Point(119, 95);
            this.chooseFileComment.Name = "chooseFileComment";
            this.chooseFileComment.Size = new System.Drawing.Size(130, 15);
            this.chooseFileComment.TabIndex = 1;
            this.chooseFileComment.Text = "* Uygulama 2\'yi açınız.";
            this.chooseFileComment.Visible = false;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chooseFileButton.Location = new System.Drawing.Point(319, 72);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(207, 60);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Uygulama 2";
            this.chooseFileButton.UseMnemonic = false;
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Visible = false;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click_1);
            // 
            // mailDetails
            // 
            this.mailDetails.Controls.Add(this.attachmentButton2);
            this.mailDetails.Controls.Add(this.label3);
            this.mailDetails.Controls.Add(this.attachmentFileOutput2);
            this.mailDetails.Controls.Add(this.attachmentFileOutput1);
            this.mailDetails.Controls.Add(this.attachment);
            this.mailDetails.Controls.Add(this.attachmentButton);
            this.mailDetails.Controls.Add(this.mailSubject);
            this.mailDetails.Controls.Add(this.mailSubjectBox);
            this.mailDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailDetails.Location = new System.Drawing.Point(623, 15);
            this.mailDetails.Margin = new System.Windows.Forms.Padding(4);
            this.mailDetails.Name = "mailDetails";
            this.mailDetails.Padding = new System.Windows.Forms.Padding(4);
            this.mailDetails.Size = new System.Drawing.Size(714, 234);
            this.mailDetails.TabIndex = 2;
            this.mailDetails.TabStop = false;
            this.mailDetails.Text = "E-Posta Detayları";
            // 
            // attachmentButton2
            // 
            this.attachmentButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentButton2.Location = new System.Drawing.Point(300, 128);
            this.attachmentButton2.Name = "attachmentButton2";
            this.attachmentButton2.Size = new System.Drawing.Size(207, 60);
            this.attachmentButton2.TabIndex = 7;
            this.attachmentButton2.Text = "Dosya Seçiniz";
            this.attachmentButton2.UseVisualStyleBackColor = true;
            this.attachmentButton2.Click += new System.EventHandler(this.attachmentButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(118, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-posta eki seçiniz  :";
            // 
            // attachmentFileOutput2
            // 
            this.attachmentFileOutput2.AutoSize = true;
            this.attachmentFileOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentFileOutput2.ForeColor = System.Drawing.Color.Teal;
            this.attachmentFileOutput2.Location = new System.Drawing.Point(55, 210);
            this.attachmentFileOutput2.Name = "attachmentFileOutput2";
            this.attachmentFileOutput2.Size = new System.Drawing.Size(0, 13);
            this.attachmentFileOutput2.TabIndex = 5;
            // 
            // attachmentFileOutput1
            // 
            this.attachmentFileOutput1.AutoSize = true;
            this.attachmentFileOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentFileOutput1.ForeColor = System.Drawing.Color.Teal;
            this.attachmentFileOutput1.Location = new System.Drawing.Point(55, 191);
            this.attachmentFileOutput1.Name = "attachmentFileOutput1";
            this.attachmentFileOutput1.Size = new System.Drawing.Size(0, 13);
            this.attachmentFileOutput1.TabIndex = 4;
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
            // attachmentButton
            // 
            this.attachmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attachmentButton.Location = new System.Drawing.Point(300, 62);
            this.attachmentButton.Name = "attachmentButton";
            this.attachmentButton.Size = new System.Drawing.Size(207, 60);
            this.attachmentButton.TabIndex = 2;
            this.attachmentButton.Text = "Dosya Seçiniz";
            this.attachmentButton.UseVisualStyleBackColor = true;
            this.attachmentButton.Click += new System.EventHandler(this.AttachmentButton_Click);
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
            // mailSubjectBox
            // 
            this.mailSubjectBox.Location = new System.Drawing.Point(268, 22);
            this.mailSubjectBox.Name = "mailSubjectBox";
            this.mailSubjectBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mailSubjectBox.Size = new System.Drawing.Size(272, 22);
            this.mailSubjectBox.TabIndex = 0;
            // 
            // SenderButton
            // 
            this.SenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SenderButton.Location = new System.Drawing.Point(1108, 642);
            this.SenderButton.Margin = new System.Windows.Forms.Padding(4);
            this.SenderButton.Name = "SenderButton";
            this.SenderButton.Size = new System.Drawing.Size(207, 60);
            this.SenderButton.TabIndex = 3;
            this.SenderButton.Text = "Gönder";
            this.SenderButton.UseVisualStyleBackColor = true;
            this.SenderButton.Click += new System.EventHandler(this.SenderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(623, 257);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(714, 377);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesaj";
            // 
            // messageBox
            // 
            this.messageBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.messageBox.Location = new System.Drawing.Point(8, 23);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageBox.Size = new System.Drawing.Size(698, 346);
            this.messageBox.TabIndex = 0;
            this.messageBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SenderButton);
            this.Controls.Add(this.mailDetails);
            this.Controls.Add(this.recipientList);
            this.Controls.Add(this.senderDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Otomatik E-posta Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.senderDetails.ResumeLayout(false);
            this.senderDetails.PerformLayout();
            this.recipientList.ResumeLayout(false);
            this.recipientList.PerformLayout();
            this.mailDetails.ResumeLayout(false);
            this.mailDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox senderDetails;
        private System.Windows.Forms.GroupBox recipientList;
        private System.Windows.Forms.GroupBox mailDetails;
        private System.Windows.Forms.Button SenderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label portNumber;
        private System.Windows.Forms.Label smtpServer;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label senderMail;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox smtpBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label passwordComment;
        private System.Windows.Forms.Label portComment;
        private System.Windows.Forms.Label smtpComment;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label chooseFileOutput;
        private System.Windows.Forms.Label chooseFileComment;
        private System.Windows.Forms.Label attachmentFileOutput1;
        private System.Windows.Forms.Label attachment;
        private System.Windows.Forms.Button attachmentButton;
        private System.Windows.Forms.Label mailSubject;
        private System.Windows.Forms.TextBox mailSubjectBox;
        private System.Windows.Forms.Label recipientMail;
        private System.Windows.Forms.TextBox recipientBox;
        private System.Windows.Forms.CheckBox enableMailList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sslBox;
        private System.Windows.Forms.Button attachmentButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label attachmentFileOutput2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}


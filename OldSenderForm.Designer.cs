namespace MailSender
{
    partial class OldSenderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldSenderForm));
            addMailButon = new Button();
            changeListTextBox = new TextBox();
            mailLabel = new Label();
            mailCheckedListBox = new CheckedListBox();
            removeMailButton = new Button();
            changeListLabel = new Label();
            addressPasswordTextBox = new TextBox();
            MailSeparatorPanel = new Panel();
            optionsSeparatorPanel = new Panel();
            hostPortTextBox = new TextBox();
            senderAddressTextBox = new TextBox();
            senderAddressLabel = new Label();
            addressPasswordLabel = new Label();
            hostAddressTextBox = new TextBox();
            hostAddressLabel = new Label();
            hostPortLabel = new Label();
            inputTextBox = new TextBox();
            bodyTextBox = new TextBox();
            sendMailButton = new Button();
            subjectTextBox = new TextBox();
            bodyLabel = new Label();
            subjectLabel = new Label();
            openMailFileDialog = new OpenFileDialog();
            FileTextBox = new TextBox();
            fileUploadButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // addMailButon
            // 
            addMailButon.Font = new Font("Segoe UI", 11F);
            addMailButon.Location = new Point(12, 413);
            addMailButon.Name = "addMailButon";
            addMailButon.Size = new Size(98, 25);
            addMailButon.TabIndex = 1;
            addMailButon.Text = "Adicionar";
            addMailButon.UseVisualStyleBackColor = true;
            addMailButon.Click += addMailButon_Click;
            // 
            // changeListTextBox
            // 
            changeListTextBox.Location = new Point(12, 384);
            changeListTextBox.Name = "changeListTextBox";
            changeListTextBox.Size = new Size(206, 23);
            changeListTextBox.TabIndex = 2;
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new Font("Times New Roman", 13F);
            mailLabel.Location = new Point(22, 11);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(185, 20);
            mailLabel.TabIndex = 4;
            mailLabel.Text = "E-mail(s) Destinatário(s)";
            mailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mailCheckedListBox
            // 
            mailCheckedListBox.FormattingEnabled = true;
            mailCheckedListBox.Location = new Point(12, 34);
            mailCheckedListBox.Name = "mailCheckedListBox";
            mailCheckedListBox.Size = new Size(206, 310);
            mailCheckedListBox.TabIndex = 5;
            // 
            // removeMailButton
            // 
            removeMailButton.Font = new Font("Segoe UI", 11F);
            removeMailButton.Location = new Point(116, 413);
            removeMailButton.Name = "removeMailButton";
            removeMailButton.Size = new Size(102, 25);
            removeMailButton.TabIndex = 6;
            removeMailButton.Text = "Remover";
            removeMailButton.UseVisualStyleBackColor = true;
            removeMailButton.Click += removeMailButton_Click;
            // 
            // changeListLabel
            // 
            changeListLabel.AutoSize = true;
            changeListLabel.Font = new Font("Times New Roman", 10F);
            changeListLabel.Location = new Point(71, 365);
            changeListLabel.Name = "changeListLabel";
            changeListLabel.Size = new Size(75, 16);
            changeListLabel.TabIndex = 7;
            changeListLabel.Text = "Mudar Lista";
            changeListLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addressPasswordTextBox
            // 
            addressPasswordTextBox.Location = new Point(260, 415);
            addressPasswordTextBox.Name = "addressPasswordTextBox";
            addressPasswordTextBox.Size = new Size(196, 23);
            addressPasswordTextBox.TabIndex = 10;
            addressPasswordTextBox.TextAlign = HorizontalAlignment.Center;
            addressPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // MailSeparatorPanel
            // 
            MailSeparatorPanel.BackColor = SystemColors.ControlDark;
            MailSeparatorPanel.BorderStyle = BorderStyle.FixedSingle;
            MailSeparatorPanel.Cursor = Cursors.No;
            MailSeparatorPanel.Location = new Point(233, 9);
            MailSeparatorPanel.Name = "MailSeparatorPanel";
            MailSeparatorPanel.Size = new Size(10, 429);
            MailSeparatorPanel.TabIndex = 11;
            // 
            // optionsSeparatorPanel
            // 
            optionsSeparatorPanel.BackColor = SystemColors.ControlDark;
            optionsSeparatorPanel.BorderStyle = BorderStyle.FixedSingle;
            optionsSeparatorPanel.Cursor = Cursors.No;
            optionsSeparatorPanel.Location = new Point(249, 334);
            optionsSeparatorPanel.Name = "optionsSeparatorPanel";
            optionsSeparatorPanel.Size = new Size(539, 10);
            optionsSeparatorPanel.TabIndex = 12;
            // 
            // hostPortTextBox
            // 
            hostPortTextBox.Location = new Point(583, 413);
            hostPortTextBox.Name = "hostPortTextBox";
            hostPortTextBox.Size = new Size(196, 23);
            hostPortTextBox.TabIndex = 13;
            hostPortTextBox.Text = "587";
            hostPortTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // senderAddressTextBox
            // 
            senderAddressTextBox.Location = new Point(260, 370);
            senderAddressTextBox.Name = "senderAddressTextBox";
            senderAddressTextBox.Size = new Size(196, 23);
            senderAddressTextBox.TabIndex = 15;
            senderAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // senderAddressLabel
            // 
            senderAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            senderAddressLabel.AutoSize = true;
            senderAddressLabel.Font = new Font("Times New Roman", 10F);
            senderAddressLabel.Location = new Point(304, 351);
            senderAddressLabel.Name = "senderAddressLabel";
            senderAddressLabel.Size = new Size(106, 16);
            senderAddressLabel.TabIndex = 16;
            senderAddressLabel.Text = "E-mail Remetente";
            senderAddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addressPasswordLabel
            // 
            addressPasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addressPasswordLabel.AutoSize = true;
            addressPasswordLabel.Font = new Font("Times New Roman", 10F);
            addressPasswordLabel.Location = new Point(283, 396);
            addressPasswordLabel.Name = "addressPasswordLabel";
            addressPasswordLabel.Size = new Size(137, 16);
            addressPasswordLabel.TabIndex = 17;
            addressPasswordLabel.Text = "Password de Aplicação";
            addressPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hostAddressTextBox
            // 
            hostAddressTextBox.Location = new Point(583, 370);
            hostAddressTextBox.Name = "hostAddressTextBox";
            hostAddressTextBox.Size = new Size(196, 23);
            hostAddressTextBox.TabIndex = 18;
            hostAddressTextBox.Text = "smtp-mail.outlook.com";
            hostAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // hostAddressLabel
            // 
            hostAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            hostAddressLabel.AutoSize = true;
            hostAddressLabel.Font = new Font("Times New Roman", 10F);
            hostAddressLabel.Location = new Point(665, 351);
            hostAddressLabel.Name = "hostAddressLabel";
            hostAddressLabel.Size = new Size(33, 16);
            hostAddressLabel.TabIndex = 19;
            hostAddressLabel.Text = "Host";
            hostAddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hostPortLabel
            // 
            hostPortLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            hostPortLabel.AutoSize = true;
            hostPortLabel.Font = new Font("Times New Roman", 10F);
            hostPortLabel.Location = new Point(661, 396);
            hostPortLabel.Name = "hostPortLabel";
            hostPortLabel.Size = new Size(37, 16);
            hostPortLabel.TabIndex = 20;
            hostPortLabel.Text = "Porta";
            hostPortLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = SystemColors.Menu;
            inputTextBox.BorderStyle = BorderStyle.None;
            inputTextBox.Font = new Font("Segoe UI", 10F);
            inputTextBox.ForeColor = SystemColors.ControlDarkDark;
            inputTextBox.Location = new Point(260, 12);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ReadOnly = true;
            inputTextBox.Size = new Size(519, 57);
            inputTextBox.TabIndex = 21;
            inputTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // bodyTextBox
            // 
            bodyTextBox.Location = new Point(304, 136);
            bodyTextBox.Multiline = true;
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.Size = new Size(442, 105);
            bodyTextBox.TabIndex = 23;
            // 
            // sendMailButton
            // 
            sendMailButton.Font = new Font("Segoe UI", 11F);
            sendMailButton.Location = new Point(304, 304);
            sendMailButton.Name = "sendMailButton";
            sendMailButton.Size = new Size(196, 36);
            sendMailButton.TabIndex = 24;
            sendMailButton.Text = "Enviar Mail";
            sendMailButton.UseVisualStyleBackColor = true;
            sendMailButton.Click += sendMailButton_Click;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(304, 91);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(442, 23);
            subjectTextBox.TabIndex = 25;
            // 
            // bodyLabel
            // 
            bodyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bodyLabel.AutoSize = true;
            bodyLabel.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bodyLabel.Location = new Point(481, 117);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(79, 19);
            bodyLabel.TabIndex = 26;
            bodyLabel.Text = "Descrição";
            bodyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subjectLabel
            // 
            subjectLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectLabel.Location = new Point(493, 72);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(50, 19);
            subjectLabel.TabIndex = 27;
            subjectLabel.Text = "Título";
            subjectLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openMailFileDialog
            // 
            openMailFileDialog.FileName = "openMailFileDialog";
            // 
            // FileTextBox
            // 
            FileTextBox.ForeColor = SystemColors.ControlDarkDark;
            FileTextBox.Location = new Point(562, 283);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.Size = new Size(152, 23);
            FileTextBox.TabIndex = 29;
            // 
            // fileUploadButton
            // 
            fileUploadButton.Font = new Font("Segoe UI", 11F);
            fileUploadButton.Location = new Point(550, 304);
            fileUploadButton.Name = "fileUploadButton";
            fileUploadButton.Size = new Size(196, 36);
            fileUploadButton.TabIndex = 28;
            fileUploadButton.Text = "Anexar Ficheiro";
            fileUploadButton.UseVisualStyleBackColor = true;
            fileUploadButton.Click += fileUploadButton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(712, 283);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 30;
            button1.Text = "⌦";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OldSenderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(optionsSeparatorPanel);
            Controls.Add(fileUploadButton);
            Controls.Add(button1);
            Controls.Add(FileTextBox);
            Controls.Add(subjectLabel);
            Controls.Add(bodyLabel);
            Controls.Add(subjectTextBox);
            Controls.Add(sendMailButton);
            Controls.Add(bodyTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(hostPortLabel);
            Controls.Add(hostAddressLabel);
            Controls.Add(hostAddressTextBox);
            Controls.Add(addressPasswordLabel);
            Controls.Add(senderAddressLabel);
            Controls.Add(senderAddressTextBox);
            Controls.Add(MailSeparatorPanel);
            Controls.Add(hostPortTextBox);
            Controls.Add(addressPasswordTextBox);
            Controls.Add(changeListLabel);
            Controls.Add(removeMailButton);
            Controls.Add(mailCheckedListBox);
            Controls.Add(mailLabel);
            Controls.Add(changeListTextBox);
            Controls.Add(addMailButon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OldSenderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Versão Antiga do Remetente de E-mail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addMailButon;
        private TextBox changeListTextBox;
        private Label mailLabel;
        private CheckedListBox mailCheckedListBox;
        private Button removeMailButton;
        private Label changeListLabel;
        private TextBox addressPasswordTextBox;
        private Panel MailSeparatorPanel;
        private Panel optionsSeparatorPanel;
        private TextBox hostPortTextBox;
        private TextBox senderAddressTextBox;
        internal Label senderAddressLabel;
        internal Label addressPasswordLabel;
        private TextBox hostAddressTextBox;
        internal Label hostAddressLabel;
        internal Label hostPortLabel;
        private TextBox inputTextBox;
        private TextBox bodyTextBox;
        private Button sendMailButton;
        private TextBox subjectTextBox;
        internal Label bodyLabel;
        internal Label subjectLabel;
        private OpenFileDialog openMailFileDialog;
        private TextBox FileTextBox;
        private Button fileUploadButton;
        private Button button1;
    }
}

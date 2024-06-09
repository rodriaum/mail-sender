namespace MailSender
{
    partial class SenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            attachmentTextBox = new TextBox();
            button2 = new Button();
            button3 = new Button();
            recipientListButton = new Button();
            mailServerButton = new Button();
            oldVersionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 386);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(33, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(409, 386);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(33, 370);
            button1.Name = "button1";
            button1.Size = new Size(409, 47);
            button1.TabIndex = 3;
            button1.Text = "Enviar E-mail aos Destinatários";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 140);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 141);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(140, 46);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 6;
            label1.Text = "REMETENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 81);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 125);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Descrição";
            // 
            // attachmentTextBox
            // 
            attachmentTextBox.BorderStyle = BorderStyle.None;
            attachmentTextBox.Location = new Point(182, 331);
            attachmentTextBox.Name = "attachmentTextBox";
            attachmentTextBox.ReadOnly = true;
            attachmentTextBox.Size = new Size(115, 16);
            attachmentTextBox.TabIndex = 9;
            attachmentTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(277, 351);
            button2.Name = "button2";
            button2.Size = new Size(20, 23);
            button2.TabIndex = 10;
            button2.Text = "⌦";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(182, 351);
            button3.Name = "button3";
            button3.Size = new Size(98, 23);
            button3.TabIndex = 11;
            button3.Text = "Anexar Ficheiro";
            button3.UseVisualStyleBackColor = true;
            // 
            // recipientListButton
            // 
            recipientListButton.Location = new Point(71, 351);
            recipientListButton.Name = "recipientListButton";
            recipientListButton.Size = new Size(83, 23);
            recipientListButton.TabIndex = 12;
            recipientListButton.Text = "Destinatários";
            recipientListButton.UseVisualStyleBackColor = true;
            // 
            // mailServerButton
            // 
            mailServerButton.Location = new Point(319, 351);
            mailServerButton.Name = "mailServerButton";
            mailServerButton.Size = new Size(83, 23);
            mailServerButton.TabIndex = 13;
            mailServerButton.Text = "Servidor";
            mailServerButton.UseVisualStyleBackColor = true;
            // 
            // oldVersionButton
            // 
            oldVersionButton.Location = new Point(172, 12);
            oldVersionButton.Name = "oldVersionButton";
            oldVersionButton.Size = new Size(125, 23);
            oldVersionButton.TabIndex = 14;
            oldVersionButton.Text = "Usar Versão Antiga";
            oldVersionButton.UseVisualStyleBackColor = true;
            oldVersionButton.Click += oldVersionButton_Click;
            // 
            // SenderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(473, 450);
            Controls.Add(button1);
            Controls.Add(mailServerButton);
            Controls.Add(recipientListButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(attachmentTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(oldVersionButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SenderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remetente de E-mail";
            Load += SenderForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox attachmentTextBox;
        private Button button2;
        private Button button3;
        private Button recipientListButton;
        private Button mailServerButton;
        private Button oldVersionButton;
    }
}
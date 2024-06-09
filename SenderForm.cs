using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class SenderForm : Form
    {
        public SenderForm()
        {
            InitializeComponent();
        }

        private void SenderForm_Load(object sender, EventArgs e)
        {
            attachmentTextBox.Text = "buceta";
        }

        private void oldVersionButton_Click(object sender, EventArgs e)
        {
            new OldSenderForm().Show();
            this.Hide();
        }
    }
}

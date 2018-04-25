using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikeMachine
{
    public partial class CaptchaForm : Form
    {
        public string CaptchaKey { get; private set; }

        public CaptchaForm(string url)
        {
            InitializeComponent();

            this.CenterToScreen();


            webBrowser1.Navigate(url);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            CaptchaKey = textBoxCaptchaKey.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }



        private void textBoxCaptchaKey_Enter(object sender, EventArgs e)
        {
            buttonOK_Click(null, null);
        }

        private void textBoxCaptchaKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOK_Click(this, new EventArgs());
        }

        private void CaptchaForm_Load(object sender, EventArgs e)
        {
            textBoxCaptchaKey.Select();
        }
    }
}

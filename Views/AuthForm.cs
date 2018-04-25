using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LikeMachine
{
    public partial class AuthForm : Form
    {
        string _url;
        public string AccessToken = null;

        public AuthForm(string url)
        {
            InitializeComponent();

            _url = url;

            this.Load += AuthForm_Load;
            webBrowser1.Navigated += webBrowser1_Navigated;
        }

        void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string authToken = _getToken(webBrowser1.Url.ToString());

            if (authToken != null && authToken != string.Empty)
            {
                AccessToken = authToken;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private string _getToken(string url)
        {
            string res = null;

            try
            {
                string pattern = @"(access_token=).*?(&|$)";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(url);

                res = match.Value.Replace("access_token=", "").Replace("&", "").Trim();
            }
            catch { }

            return res;
        }

        void AuthForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(_url);
        }
    }
}

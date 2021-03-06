﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.BO;

namespace WindowsFormsApplication2.GUI
{
    public partial class Auth : Form
    {                                   
        public const string clientId = "697224350748-70gb6ot5p6ptlj248dnophhlqa0pq6ra.apps.googleusercontent.com";
        public const string clientSecret = "wGAX0o68kboMJD4p_5ypVs7o";      
        public const string redirectURI = "urn:ietf:wg:oauth:2.0:oob";
      
        public AuthResponse access;

        private DialogResult result = DialogResult.Cancel;

        public Auth()
        {
            InitializeComponent();
            webBrowser1.Navigate(AuthResponse.GetAutenticationURI(clientId, redirectURI));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string Mytitle = ((WebBrowser)sender).DocumentTitle.ToLower();
            if (Mytitle.IndexOf("success code=") > -1)
            {
                webBrowser1.Visible = false;
                // searching the body for our code
                string AuthCode = webBrowser1.DocumentTitle.Replace("Success code=", "").Split('&')[0];
                string authCode = AuthCode; 
                    //Exchange the code for Access token and refreshtoken.
                access = AuthResponse.Exchange(authCode, clientId, clientSecret, redirectURI);
                processAccess();
       
            }
        }
        /// <summary>
        /// revisa que el Access_token no este vacio
        /// </summary>
        public void processAccess()
        {
            if (access.Access_token != null)
            {
                this.result = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}

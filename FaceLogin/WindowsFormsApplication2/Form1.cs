using System;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string appId = "804819252966453";
        private Uri _loginUrl;
        private const string _ExtendedPermissions = "user_about_me, publish_actions";
        FacebookClient fbcliente = new FacebookClient();



        private void Form1_Load(object sender, EventArgs e)
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = appId;
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";
            //parameters.redirect_url = "https://www.facebook.com/connect/login_success.html";
            parameters.response_type = "token";
            parameters.display = "popup";

            if (!string.IsNullOrWhiteSpace(_ExtendedPermissions))
            {
                parameters.scope = _ExtendedPermissions;


                var fb = new FacebookClient();
                _loginUrl = fb.GetLoginUrl(parameters);

                wbFace.Navigate(_loginUrl.AbsoluteUri);
            }
        }
    }
}

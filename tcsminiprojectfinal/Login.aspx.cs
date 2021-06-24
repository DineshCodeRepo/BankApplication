using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BankTypes;
using BankBLL;

namespace UI
{
    public partial class WebForm35 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = (Login1.UserName);
            string password = (Login1.Password);
            List<Ilogin> user = new List<Ilogin>();
            ILoginBLL loginbll = new LoginBLL();
            user = loginbll.retriveuser(username);
            
            if (user.Count == 0)
            {
                e.Authenticated = false;

                Login1.FailureText = "Invalid UserName/Password";
                
            }
            else
            {
                if (user[0].Password == password)
                {
                    if (user[0].Type == 0)
                    {
                        e.Authenticated = true;
                        FormsAuthentication.SetAuthCookie(username, Login1.RememberMeSet);
                        Response.Redirect("AccountExeHomePage.aspx");
                    }
                    else
                    {

                        e.Authenticated = true;

                        FormsAuthentication.SetAuthCookie(username, Login1.RememberMeSet);
                        Response.Redirect("CashierHomepage.aspx");

                    }
                }
                else
                {
                    e.Authenticated = false;
                    Login1.FailureText = "Invalid UserName/Password";
                        
                }
            }
        }
    }
}
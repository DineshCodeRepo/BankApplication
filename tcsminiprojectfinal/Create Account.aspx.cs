using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankBLL;
using BankTypes;

namespace UI
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long customerid;
            string accounttype;
            long amount;

            customerid = long.Parse(txtcusid.Text);
            accounttype = ddlacctype.Text;
            amount = long.Parse(txtamt.Text);

            IAccountBLL accountbll = new AccountBLL();
            int res = accountbll.createAccount(customerid, 0, accounttype, "Active", "Account created Successfully", amount, DateTime.Now.Date);
           

           // Operations ob = new Operations();

           // int res;

          //  res = ob.addAccount(customerid, accounttype, amount);

            if (res == 1)
                Response.Write("<script type=\"text/javascript\">alert('Account created Successfully');</script>");
            else
                Response.Write("<script type=\"text/javascript\">alert('Failed');</script>");

        }
    }
}
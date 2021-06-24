using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankTypes;
using BankDAL;
using BankBLL;

namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long accountid = Convert.ToInt64((string)Session["accountid"]);
            List<Iaccount> accounts = new List<Iaccount>();
            IAccountBLL accbll = new AccountBLL();
            accounts = accbll.retriveaccount(accountid);

            Label1.Text = accounts[0].Customerid.ToString();
            Label2.Text = accounts[0].Accountid.ToString();
            Label3.Text = accounts[0].Type.ToString();
            Label4.Text = accounts[0].Balance.ToString();
            Session["customerid"] = accounts[0].Customerid.ToString();
            Session["accountid"] = accounts[0].Accountid.ToString();
            Session["type"] = accounts[0].Type.ToString();
            Session["balance"] = accounts[0].Balance.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deposit Money.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Withdraw Money.aspx");
                    
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transfer Money.aspx");
        }
    }
}
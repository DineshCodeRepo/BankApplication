using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankTypes;
using BankBLL;

namespace UI
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string customerid = (string)Session["customerid"];
            string accountid = (string)Session["accountid"];
            string type = (string)Session["type"];
            string balance = (string)Session["balance"];
            Label1.Text = customerid;
            Label2.Text = accountid;
            Label3.Text = type;
            Label4.Text = balance;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long Accountid = Convert.ToInt64(Label2.Text);
            long Toaccountid = 0;
            DateTime Date = DateTime.Now.Date;
            string Description = "credit";
            long Amount = Convert.ToInt64(TextBox1.Text);
            if (Amount<=0)
            {
                Response.Write("<script type=\"text/javascript\">alert('Enter Proper Amount');window.location.href='Deposit Money.aspx';</script>");
                
            }
            else
            {
                ITransactionBLL transbll = new TransactionBLL();
                long transid = transbll.withdrawdeposit(Accountid, Date, Description, Amount, Toaccountid);
                if (transid == 0)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Transaction UnSuccessfull');window.location.href='Deposit Money.aspx';</script>");

                }
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Transaction Successfull');window.location.href='Deposit Money.aspx';</script>");

                }
            }
        }
    }
}
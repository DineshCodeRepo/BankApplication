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
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string customerid = (string)Session["customerid"];
                string accountid = (string)Session["accountid"];
                string type = (string)Session["type"];
                string balance = (string)Session["balance"];
                TextBox1.Text = customerid;
                TextBox3.Text = accountid;
                DropDownList1.Items.Insert(0, new ListItem("Select", "NA"));
                DropDownList1.Items.Insert(1, new ListItem(type, type));
                
                List<Iaccount> accounts = new List<Iaccount>();
                IAccountBLL accbll = new AccountBLL();
                accounts = accbll.retrivealldetials();
                DropDownList2.DataSource = accounts;
                DropDownList2.DataTextField = "accountid";
                DropDownList2.DataValueField = "accountid";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Select", "NA"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            long Accountid =Convert.ToInt64(TextBox3.Text);
            long Toaccountid = Convert.ToInt64(DropDownList2.Text);
            DateTime Date = DateTime.Now.Date;
            string Description = "Transfer";
            
            long Amount =Convert.ToInt64(TextBox2.Text);
            if (Amount <= 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('Enter Proper Amount');window.location.href='Deposit Money.aspx';</script>");

            }
            else
            {
                ITransactionBLL transbll = new TransactionBLL();
                long transid = transbll.withdrawdeposit(Accountid, Date, Description, Amount, Toaccountid);

                if (transid != 0)
                {
                    Response.Write("<script>alert('Transaction Successfull');window.location.href='Transfer Money.aspx';</script>");


                }
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Transaction UnSuccessfull');window.location.href='Transfer Money.aspx';</script>");


                }
            }        
        }

        
    }
}
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
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                DropDownList1.Items.Clear();
                DropDownList1.Items.Insert(0, "Select");
                DropDownList1.Visible = true;
                DropDownList1.Items.Insert(1, new ListItem("1", "1"));
                DropDownList1.Items.Insert(2, new ListItem("2", "2"));
                DropDownList1.Items.Insert(3, new ListItem("3", "3"));
                DropDownList1.Items.Insert(4, new ListItem("4", "4"));
                DropDownList1.Items.Insert(5, new ListItem("5", "5"));
                DropDownList1.Items.Insert(6, new ListItem("6", "6"));
                DropDownList1.Items.Insert(7, new ListItem("7", "7"));
                DropDownList1.Items.Insert(8, new ListItem("8", "8"));
                DropDownList1.Items.Insert(9, new ListItem("9", "9"));
            }
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            long accountid = Convert.ToInt64(TextBox1.Text);
            List<Iaccount> accounts = new List<Iaccount>();
            IAccountBLL accbll = new AccountBLL();
            accounts = accbll.retriveaccount(accountid);

            if (accounts.Count == 0)
            {
                string jscript = "<script>alert('Account Id doesnot exsist');window.location.href='View Statement by No of transactions .aspx';</script>";
                System.Type t = this.GetType();
                ClientScript.RegisterStartupScript(t, "k", jscript);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool s1= (TextBox1.Text.Length > 0);
            

            if (s1)
            {
                long accountid = Convert.ToInt64(TextBox1.Text);
                List<Iaccount> accounts = new List<Iaccount>();
                IAccountBLL accbll = new AccountBLL();
                accounts = accbll.retriveaccount(accountid);
                if (accounts.Count==0)
                {
                    string jscript = "<script>alert('Account Id doesnot exsist');window.location.href='View Statement by No of transactions .aspx';</script>";
                    System.Type t = this.GetType();
                    ClientScript.RegisterStartupScript(t, "k", jscript);
                }
                else if (RadioButton2.Checked && DropDownList1.Text != "Select")
                {

                    int nooftrans = Convert.ToInt32(DropDownList1.Text);
                    List<Itransaction> transacs = new List<Itransaction>();
                    ITransactionBLL transbll = new TransactionBLL();
                    transacs = transbll.retrivetrans(accountid, nooftrans);
                    
                    Grid.DataSource = transacs;
                    Grid.DataBind();
                    Button2.Visible = true;
                    Button3.Visible = true;
                }
                else if (RadioButton1.Checked)
                {
                    Session["accountid"] = accountid;
                    Response.Redirect("View Statement by Start and End Page.aspx");
                }
            }
            else
            {
                string jscript = "<script>alert('Please Enter Account ID');window.location.href='View Statement by No of transactions .aspx';</script>";
                System.Type t = this.GetType();
                ClientScript.RegisterStartupScript(t, "k", jscript);
            }
        }

        protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                DropDownList1.Visible = false;

            }
        }
    }
}
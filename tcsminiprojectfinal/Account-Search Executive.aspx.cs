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
    public partial class WebForm46 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            if (TextBox2.Text.Length > 0)
            {
                IAccountBLL accbll = new AccountBLL();
                long customerid = Convert.ToInt64(TextBox2.Text);
                List<Iaccount> daccounts = new List<Iaccount>();

                daccounts = accbll.retriveaccounts(customerid);
                DropDownList1.DataSource = daccounts;
                DropDownList1.DataTextField = "accountid";
                DropDownList1.DataValueField = "accountid";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("Select", "NA"));
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool s1 = (TextBox1.Text.Length > 0);
            bool s2 = (TextBox2.Text.Length > 0);

            if (s1 && s2)
            {
                Response.Write("<script type=\"text/javascript\">alert('Fill Either One');window.location.href='Account-Search Executive.aspx'; </script>");

            }
            else if (s1)
            {

                IAccountBLL accbll = new AccountBLL();
                long accounid = Convert.ToInt64(TextBox1.Text);
                List<Iaccount> accounts = new List<Iaccount>();
                accounts = accbll.retriveaccount(accounid);
                if (accounts.Count == 0)
                {

                    Response.Redirect("<script>alert('Account Id doesnot exsist');window.location.href='Account-Search Executive.aspx';</script>");
                    


                }
                else
                {

                    Session["accountid"] = TextBox1.Text;
                    Response.Redirect("AccountDetials.aspx");
                    
                   


                }
            }
            else if (s2)
            {
                IAccountBLL accbll = new AccountBLL();
                long customerid = Convert.ToInt64(TextBox2.Text);
                List<Iaccount> daccounts = new List<Iaccount>();
                daccounts = accbll.retriveaccounts(customerid);

                if (daccounts.Count == 0)
                {

                    Response.Write("<script type=\"text/javascript\">alert('Customer Doesnot Exists');window.location.href='Account-Search Executive.aspx'; </script>");


                }
                else
                {
                    Session["accountid"] = DropDownList1.Text;
                    Response.Redirect("AccountDetials.aspx");
                    
                }
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Fill Either One');window.location.href='Account-Search Executive.aspx'; </script>");
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

           
            long accounid = Convert.ToInt64(TextBox1.Text);
            List<Iaccount> accounts = new List<Iaccount>();
            IAccountBLL accbll = new AccountBLL();
            accounts = accbll.retriveaccount(accounid);
            if (accounts.Count == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('Account Doesnot Exists');window.location.href='Account-Search Executive.aspx'; </script>");
                

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool s1 = (TextBox1.Text.Length > 0);
            bool s2 = (TextBox2.Text.Length > 0);

            if (s1 && s2)
            {
                Response.Write("<script type=\"text/javascript\">alert('Fill Either One');window.location.href='Account-Search Executive.aspx'; </script>");

            }
            else if (s1)
            {

                IAccountBLL accbll = new AccountBLL();
                long accounid = Convert.ToInt64(TextBox1.Text);
                List<Iaccount> accounts = new List<Iaccount>();
                accounts = accbll.retriveaccount(accounid);
                if (accounts.Count == 0)
                {

                    Response.Write("<script type=\"text/javascript\">alert('Account Doesnot Exists');window.location.href='Account-Search Executive.aspx'; </script>");


                }
                else
                {

                    Session["accountid"] = TextBox1.Text;
                    Response.Redirect("Delete Account.aspx");




                }
            }
            else if (s2)
            {
                IAccountBLL accbll = new AccountBLL();
                long customerid = Convert.ToInt64(TextBox2.Text);
                List<Iaccount> daccounts = new List<Iaccount>();
                daccounts = accbll.retriveaccounts(customerid);

                if (daccounts.Count == 0)
                {

                    Response.Write("<script type=\"text/javascript\">alert('Customer Id Doesnot Exists');window.location.href='Account-Search Executive.aspx'; </script>");


                }
                else
                {
                    Session["accountid"] = DropDownList1.Text;
                    Response.Redirect("Delete Account.aspx");

                }
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Fill Either One');window.location.href='Account-Search Executive.aspx'; </script>");
            }
           
        }
    }
}
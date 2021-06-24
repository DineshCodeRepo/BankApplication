using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankTypes;
using BankBLL;

namespace ProductBacklog
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool s1 = txtSSNid.Text.Length > 0;
            bool s2 = txtcusid.Text.Length > 0;
            
            if (s1 && s2)
            {
                Response.Write("<script type=\"text/javascript\">alert('Fill Either One');window.location.href='Customer-Search.aspx'; </script>");

            }
            else if(txtSSNid.Text.Length>0)
                {
                long cusid = -1;
                long SSNid = long.Parse((txtSSNid.Text).ToString());

                List<ICustomer> customers = new List<ICustomer>();
                ICustomerBLL custbll = new CustomerBLL();
                customers=custbll.retriveCusDetails(cusid, SSNid);
                if (customers.Count > 0)
                {
                    Session["SSNid"] = txtSSNid.Text;
                    Session["Cusid"] =-1;

                    Response.Redirect("Update Customer.aspx");
                }
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Customer does not exists');window.location.href='Customer-Search.aspx'; </script>");
                }
                }
               else if(txtcusid.Text.Length>0)
                {
                long cusid = long.Parse((txtcusid.Text).ToString());
                long SSNid = -1;
                List<ICustomer> customers = new List<ICustomer>();
                ICustomerBLL custbll = new CustomerBLL();
                customers = custbll.retriveCusDetails(cusid, SSNid);
                if (customers.Count > 0)
                {
                    Session["SSNid"] = -1;
                    Session["Cusid"] = txtcusid.Text;
                    Response.Redirect("Update Customer.aspx");
                }
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Customer does not exists');window.location.href='Customer-Search.aspx'; </script>");
                }
                

                
                }
                
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            bool s1 = txtSSNid.Text.Length > 0;
            bool s2 = txtcusid.Text.Length > 0;

            if (s1 && s2)
            {
                Response.Write("<script type=\"text/javascript\">alert('Fill Either One');window.location.href='Customer-Search.aspx'; </script>");

            }
            else if (txtSSNid.Text.Length > 0)
            {
                long cusid = -1;
                long SSNid = long.Parse((txtSSNid.Text).ToString());

                List<ICustomer> customers = new List<ICustomer>();
                ICustomerBLL custbll = new CustomerBLL();
                customers = custbll.retriveCusDetails(cusid, SSNid);
                if (customers.Count > 0)
                {
                    Session["SSNid"] = txtSSNid.Text;
                    Session["Cusid"] = -1;

                    Response.Redirect("Update Customer.aspx");
                }
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Customer does not exists');window.location.href='Customer-Search.aspx'; </script>");
                }
            }
            else if (txtcusid.Text.Length > 0)
            {
                long cusid = long.Parse((txtcusid.Text).ToString());
                long SSNid = -1;
                List<ICustomer> customers = new List<ICustomer>();
                ICustomerBLL custbll = new CustomerBLL();
                customers = custbll.retriveCusDetails(cusid, SSNid);
                if (customers.Count > 0)
                {
                    Session["SSNid"] = -1;
                    Session["Cusid"] = txtcusid.Text;
                    Response.Redirect("Update Customer.aspx");
                }
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Customer does not exists');window.location.href='Customer-Search.aspx'; </script>");
                }



            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankTypes;
using BankDAL;
using BankBLL;

namespace ProductBacklog
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ICustomerBLL customer = new CustomerBLL();
            Grid.DataSource = customer.viewall();
            Grid.DataBind();
        }

        
        protected void Grid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string cusid = Grid.Rows[e.RowIndex].FindControl("lb1").ToString();
            Session["VCustomerid"] = cusid;
           

            string cusSSNid = Grid.Rows[e.RowIndex].FindControl("lb2").ToString();
            Session["CustomerSSNid"] = cusid;
            Response.Redirect("View Customer.aspx");
        }
    }
}
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
    public partial class WebForm4 : System.Web.UI.Page
    {

       // Operations ob = new Operations();

        protected void Page_Load(object sender, EventArgs e)
        {
            long customerssnid = long.Parse(Session["SSNid"].ToString());
            long customerid = long.Parse(Session["Cusid"].ToString());
            ICustomerBLL customerBll = new CustomerBLL();
            List<ICustomer> cuslist = customerBll.retriveCusDetails(customerid, customerssnid);
            //string customername = txtcusname.Text;
            //int age = int.Parse(txtAge.Text);
            //string address = txtAddress.Text;

            

          //  List<ICustomer> cuslist = ob.retriveCusDetails(65475457);

            for (int i = 0; i < cuslist.Count; i++)
            {
                txtSSNid.Text = cuslist[i].Customerssnid.ToString();
                txtcusid.Text = cuslist[i].Customerid.ToString();
                txtcusname.Text = cuslist[i].Customername.ToString();
                txtAddress.Text = cuslist[i].Address.ToString();
                txtAge.Text = cuslist[i].Age.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cusName = txtcusname.Text;
            string cusAdd = txtAddress.Text;
            int age = int.Parse(txtAge.Text);
            long cusid = long.Parse(txtcusid.Text);
            long ssnid = long.Parse(txtSSNid.Text);


            //  Operations ob = new Operations();

            //  int res = ob.deleteCustomer(cusName, age, cusAdd, ssnid, cusid);

            ICustomerBLL customerBll = new CustomerBLL();
            int res = customerBll.deleteCustomer(ssnid, cusid, cusName, age, cusAdd, " ", " ", "InActive", "Customer Deleted Successfully", DateTime.Now.Date);

            if (res >= 1)
                Response.Write("<script type=\"text/javascript\">alert('Successfully deleted');</script>");
            else
                Response.Write("<script type=\"text/javascript\">alert('Delete failed');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("<script type=\"text/javascript\">alert('Not deleted');</script>");
        }
    }
}
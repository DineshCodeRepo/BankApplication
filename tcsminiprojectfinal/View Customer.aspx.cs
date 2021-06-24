using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankTypes;
using BankBLL;
namespace tcsminiprojectfinal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            long customerssnid = 0;// long.Parse(Session["CustomerSSNid"].ToString());
            long customerid = long.Parse(Session["VCustomerid"].ToString());
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankBLL;
using BankTypes;
using BankDAL;

namespace UI
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        IOperations ob = new Operations();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["cusSSNid"] = lbSSNid.ToString();
            //Session["cusName"] = lbOldcus.ToString();
            //Session["cusAddress"] = lbOldadd.ToString();
            //Session["cusAge"] = lbOldage.ToString();

            //Operations op = new Operations();


            long customerssnid = long.Parse(Session["SSNid"].ToString());
            long customerid = long.Parse(Session["Cusid"].ToString());
            //string customername = lbOldcus.Text;
            //int age = int.Parse(lbOldage.Text);
            //string address = lbOldadd.Text;



            ICustomerBLL customerBll = new CustomerBLL();
            List<ICustomer> cuslist = customerBll.retriveCusDetails(customerid, customerssnid);
          //      List<ICustomer> cuslist = ob.retriveCusDetails(65475457);

                for (int i=0;i<cuslist.Count;i++)
                {
                   
                    lbSSNid.Text = cuslist[i].Customerssnid.ToString();
                    lbcusID.Text = cuslist[i].Customerid.ToString();
                    lbOldcus.Text = cuslist[i].Customername.ToString();
                    lbOldadd.Text = cuslist[i].Address.ToString();
                    lbOldage.Text = cuslist[i].Age.ToString();

                }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            long cusSSNid = long.Parse(lbSSNid.Text);
            long cusid = long.Parse(lbcusID.Text);
            string newcusName = txtNewcus.Text;
            string newcusAdd = txtNewadd.Text;
            int newage = int.Parse(txtNewage.Text);
           // long id = long.Parse(lbSSNid.Text);


            //    Operations ob = new Operations();

            //  int res = ob.updateCustomer(newcusName,newage,newcusAdd,id);

            ICustomerBLL customerBll = new CustomerBLL();
            int res = customerBll.updateCustomer(cusSSNid,cusid,newcusName,newage,newcusAdd," "," ","Active","Customer Updated Successfully",DateTime.Now.Date);


            if (res == 1)
                Response.Write("<script type=\"text/javascript\">alert('Successfully Updated');</script>");
            else
                Response.Write("<script type=\"text/javascript\">alert('Update failed');</script>");
        }
    }
}
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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlState.SelectedValue == "TAMIL NADU")
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add(new ListItem("Chennai"));
                ddlCity.Items.Add(new ListItem("Coimbatore"));
                ddlCity.Items.Add(new ListItem("Trichy"));
            }
            else if (ddlState.SelectedItem.Value == "ANDHRA PRADESH")
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add(new ListItem("Hyderabad"));
                ddlCity.Items.Add(new ListItem("Secundrabad"));
                ddlCity.Items.Add(new ListItem("Nellore"));
            }
            else if (ddlState.SelectedItem.Value == "KERALA")
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add(new ListItem("Thiruvanandhapuram"));
                ddlCity.Items.Add(new ListItem("Aluva"));
                ddlCity.Items.Add(new ListItem("Aalzapuzha"));
            }
            else if (ddlState.SelectedItem.Value == "KARNATAKA")
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add(new ListItem("Bangalore"));
                ddlCity.Items.Add(new ListItem("Mysore"));
            }
            else if (ddlState.SelectedItem.Value == "MAHARASHTRA")
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add(new ListItem("Mumbai"));
                ddlCity.Items.Add(new ListItem("Pandra"));
                ddlCity.Items.Add(new ListItem("Tharave"));
            }
            else if (ddlState.SelectedItem.Value == "GUJARAT")
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add(new ListItem("Gandhi nagar"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long conSSNid;
            string cusname;
            int age;
            string address;
            string state;
            string city;
            
            conSSNid = long.Parse(txtSSNid.Text);
            cusname = txtcusname.Text;
            age = int.Parse(txtage.Text);
            address = txtaddress.Text;
            state = ddlState.Text;
            city = ddlCity.Text;


            ICustomerBLL customerbll = new CustomerBLL();
            int res=customerbll.createCustomer(conSSNid, 0, cusname, age, address, city, state, "Active", "Customer Created Successfully", DateTime.Now.Date);


            

         //   Operations ob = new Operations();

            //int res;

          //  res = ob.addCustomer(conSSNid, cusname, age, address, state, city);

            if (res == 1)
            {
               Response.Write("<script type=\"text/javascript\">alert('Customer added Successfully');</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Failed');</script>");
            }

            //Session["cusSSNid"] = long.Parse(txtSSNid.Text);
            //Session["cusName"] = txtcusname.Text;
            //Session["cusAddress"] = txtaddress.Text;
            //Session["cusAge"] = txtage.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtSSNid.Text = null;
            txtcusname.Text = null;
            txtage.Text = null;
            txtaddress.Text = null;
            ddlState.Text = null;
            ddlCity.Text = null;
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankBLL;
using BankTypes;

namespace UI
{
    public partial class WebForm7 : System.Web.UI.Page
    {
      //  Operations ob = new Operations();
      //  List<AccountInfo> acclist = new List<AccountInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
             //Session["accid"] = ddlaccid.ToString();
            //Session["actype"] = txtacctype.ToString();
            //long cusid = long.Parse(Session["Accid"].ToString());

            if(!IsPostBack)
            {
                long accid = long.Parse(Session["accountid"].ToString());
                //IAccountBLL accountbll = new AccountBLL();
                //List<Iaccount> acclist = accountbll.viewAccountID(accid);

                //acclist = ob.ViewAccountID();


                //ddlaccid.DataSource = acclist;
                //ddlaccid.DataTextField = "accid";
                //ddlaccid.DataValueField = "accid";
                //ddlaccid.DataBind();

                ddlaccid.Items.Add(new ListItem("Select ID", "Select ID"));
                ddlaccid.Items.Add(new ListItem(accid.ToString(), accid.ToString()));
                ddlaccid.ClearSelection();
                ddlaccid.Items.FindByValue("Select ID").Selected = true;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long acid;
            string actype;

            acid = long.Parse(ddlaccid.SelectedItem.Value);
            actype = txtacctype.Text;

          //  Operations ob = new Operations();

            

            IAccountBLL accountbll = new AccountBLL();
            int res = accountbll.deleteAccount(0, acid, actype, "Pending", "Account Deleted Successfully", 0, DateTime.Now.Date);

           // res = ob.deleteAccount(acid,actype);

            if(res == 1)
            {
                Response.Write("<script type=\"text/javascript\">alert('Account deleted Successfully');</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Account not deleted(Withdraw Balance)');</script>");
            }
        }

        protected void ddlaccid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlaccid.Text != "Select")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();



                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_viewAccountdetails";

                cmd.Parameters.AddWithValue("@accid", long.Parse(ddlaccid.SelectedItem.Value));

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtacctype.Text = reader["acctype"].ToString();

                }

                con.Close();
            }
        }

        protected void txtacctype_TextChanged(object sender, EventArgs e)
        {
            //long accid;
            //string acctype;

            //accid = long.Parse(ddlaccid.SelectedItem.Value);
            //acctype = txtacctype.Text;

            //if(accid!=0)
            //{
            //    txtacctype.Visible = true;
            //}
            //else
            //{
            //    txtacctype.Visible = false;
            //}
        }
    }
}
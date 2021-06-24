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
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                long accountid = (long)Session["accountid"];
                TextBox3.Text = Convert.ToString(accountid);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            DateTime dos, doe;
            dos = DateTime.Parse(TextBox1.Text);
            doe = DateTime.Parse(TextBox2.Text);
            TimeSpan diff = doe - dos;


            if (dos > DateTime.Now.Date || doe > DateTime.Now.Date)
            {
                Label2.Text = "Please select a Date on or before"+DateTime.Now.Date.ToString();
            }
            else if (diff.TotalDays < 0)
            {
                Label2.Text = "Please select valid start and end date";
            }
            else
            {
                long accountid = Convert.ToInt64(TextBox3.Text);
                DateTime startdate = Convert.ToDateTime(TextBox1.Text);
                DateTime enddate = Convert.ToDateTime(TextBox2.Text);

                ITransactionBLL transbll = new TransactionBLL();
                List<Itransaction> transacs = new List<Itransaction>();
                transacs = transbll.retrivetransactionbydate(accountid, startdate, enddate);
                Grid.DataSource = transacs;
                Grid.DataBind();
                Button2.Visible = true;
                Button3.Visible = true;
            }
        }
    }
}
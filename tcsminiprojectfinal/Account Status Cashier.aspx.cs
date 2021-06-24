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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IAccountBLL accbll = new AccountBLL();
            List<Iaccount> acclist = new List<Iaccount>();
            acclist = accbll.retrivealldetials();
            GridCashier.DataSource = acclist;
            GridCashier.DataBind();

        }
    }
}
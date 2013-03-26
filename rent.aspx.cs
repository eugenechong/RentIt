using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class rent : System.Web.UI.Page
    {
        RentIt00.IRentIt rentItServices;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.rentItServices = new RentIt00.RentItClient();
            String data = rentItServices.ListNamesAsString();
            String[] arrayData = data.Split(new String[] { "\r\n" }, StringSplitOptions.None);

            foreach (String s in arrayData) {
                TableRow tr = new TableRow();
                TableCell tc = new TableCell();
                tr.Cells.Add(tc);
                Table1.Rows.Add(tr);
                tc.Text = s;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

    }
}
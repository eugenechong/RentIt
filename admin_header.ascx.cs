using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class admin_header : System.Web.UI.UserControl
    {
        //these are used by UI for display
        public bool login = false;
        public String username = null;
        public String email = null;
        public int userid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
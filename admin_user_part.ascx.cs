using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class admin_user_part : System.Web.UI.UserControl
    {

        public Utility utility = null;
        public RentIt.RentItServices.User[] user_list = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //load webservice client
            utility = new Utility();
            utility.loadClient();

            user_list = utility.getAllUsers();            
        }
    }
}
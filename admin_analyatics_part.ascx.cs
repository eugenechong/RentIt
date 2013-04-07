using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class admin_analyatics_part : System.Web.UI.UserControl
    {
        public Utility utility = null;
        public RentItServices.Media[] media_list =null;
        public RentItServices.User[] user_list=null;

        protected void Page_Load(object sender, EventArgs e)
        {
            utility = new Utility();
            utility.loadClient();
            
            media_list = utility.getAllMedia();
            user_list = utility.getAllUsers();
               

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class admin_media_analytics_part : System.Web.UI.UserControl
    {
        public Utility utility = null;

        public RentItServices.Media[] media_list = null;
        public RentItServices.User[] user_list = null;        
        public RentItServices.Rental[] rental_list = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            utility = new Utility();
            utility.loadClient();

            media_list = utility.getAllMedia();
            user_list = utility.getAllUsers();            
        }
    }
}
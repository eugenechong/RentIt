using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class itemview_part : System.Web.UI.UserControl
    {
        public int itemID = 0;

        public RentItServices.User user = null;

        public Utility utility = null;
        public RentItServices.Media media = null;
        public RentItServices.Comment[] comment_list = null;

        protected void Page_Load(object sender, EventArgs e)
        {            
            utility = new Utility();
            utility.loadClient();

            //call the web service to retrieve media data
            media = utility.getMedia(itemID);                       
            comment_list = media.Comments;                      
        }

        protected void rate_click(object sender, EventArgs e)
        {

        }

        protected void commentButton_Click(object sender, EventArgs e)
        {            
            bool success = utility.commentMedia(itemID, user, this.Request.Form.Get("inputMediaComment"));
            if (success)
            {
                Response.Redirect("~/index.aspx?msg=Media commented!");
            }
            else
            {
                Response.Redirect("~/index.aspx?msg=");
            }
        }

        protected void bookmarkButton_Click(object sender, EventArgs e)
        {
            bool success = utility.bookmarkMedia(itemID, user);
            if (success)
            {
                Response.Redirect("~/index.aspx?msg=Media bookmarked!");
            }
            else
            {
                Response.Redirect("~/index.aspx?msg=");
            }
        }
    }
}
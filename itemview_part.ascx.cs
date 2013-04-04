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

        public bool isRented = false;


        private RentItServices.User getUser()
        {
            //grabs user
            if (Session["userEmail"] != null)
            {

                return utility.getUser(Session["userEmail"].ToString(), Session["userKey"].ToString());
            }
            else
            {
                return null;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {            
            utility = new Utility();
            utility.loadClient();
            user = getUser();   
            
            //call the web service to retrieve media data
            media = utility.getMedia(itemID);
            isRented = utility.isRented(media.MediaId, user);       
            comment_list = media.Comments;

            //preload media for viewing if rented
            if (isRented)
            {
                utility.loadFileService();
                Tuple<string, RentItServices.Media, RentItServices.User> tuple = 
                    new Tuple<string, RentItServices.Media, RentItServices.User>(user.SharedKey, media, user);

            }
        }

        protected void rate_click(object sender, EventArgs e)
        {
            int rating =Convert.ToInt32(this.Request.Form.Get("rate_amount"));
            bool success = utility.rateMedia(itemID,user,rating);
            if (success)
            {
                Response.Redirect("~/index.aspx?msg=Your rating of "+rating +" star(s) have been recorded.&item=" + itemID);
            }
            else
            {
                Response.Redirect("~/index.aspx?msg=There's an error recording your comment :(");
            }
        }

        protected void commentButton_Click(object sender, EventArgs e)
        {            
            
            bool success = utility.commentMedia(itemID, user, this.Request.Form.Get("inputMediaComment"));
            if (success)
            {
                Response.Redirect("~/index.aspx?item="+itemID);
            }
            else
            {
                Response.Redirect("~/index.aspx?msg=There's an error recording your comment :(");
            }
        }

        protected void bookmarkButton_Click(object sender, EventArgs e)
        {
            bool success = utility.bookmarkMedia(itemID, user);
            if (success)
            {
                Response.Redirect("~/index.aspx?msg=Bookmark added successfully!&item=" + itemID);
            }
            else
            {
                Response.Redirect("~/index.aspx?msg=There's an error adding your bookmark :(");
            }
        }

        protected void rent_click(object sender, EventArgs e)
        {
            Tuple <bool,string> rentStatus = utility.rentMedia(media.MediaId, user, Convert.ToInt32(user.Credits), 7);
            if (rentStatus.Item1)
            {
                Response.Redirect("~/index.aspx?msgTitle=Successfully rented "+ media.Title+ ":)&msg=You can now have access to stream this item!&item=" + itemID);
            }
            else
            {
                Response.Redirect("~/index.aspx?msg="+rentStatus.Item2);
            }
            
        }
    }
}
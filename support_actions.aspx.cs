using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class support_actions : System.Web.UI.Page
    {
        public RentItServices.User currentUser = null;
        public Utility utility = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            //load webservice client
            utility = new Utility();
            utility.loadClient();
            currentUser = getUser();
            if (currentUser == null)
            {
                Response.Redirect("~/index.aspx?msg=You have no permission to carry out the action!");
                return;
            }
            
            //determine which action to execute
            String deleteBookmark = Request.QueryString["deleteBookmark"];
            if (deleteBookmark != null)
            {
                doDeleteBookmark(Convert.ToInt32(deleteBookmark));
            }



        }

        private void doDeleteBookmark(int mediaId)
        {
            if (utility.deleteBookMark(currentUser, mediaId))
            {
                //deleted successfully
                Response.Redirect("~/index.aspx?msg=Bookmark deleted successfully!");
            }
            else
            {
                //deleted successfully
                Response.Redirect("~/index.aspx?msg=Failed to delete bookmark :(");
            }

        }

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

    }
}
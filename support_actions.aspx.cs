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
                return;
            }

            //determine if suspend action
            String suspendUser = Request.QueryString["suspend"];
            if (suspendUser != null)
            {
                doSuspend(suspendUser);
                return;
            }

            //determine if unsuspend action
            String unsuspendUser = Request.QueryString["unsuspend"];
            if (unsuspendUser != null)
            {
                doUnSuspend(unsuspendUser);
                return;
            }

            //determine if make admin action
            String makeAdmin = Request.QueryString["make_admin"];
            if (makeAdmin != null)
            {
                doMakeAdmin(makeAdmin);
                return;
            }

            //determine if revoke admin action
            String revokeAdmin = Request.QueryString["revoke_admin"];
            if (revokeAdmin != null)
            {
                doRevokeAdmin(revokeAdmin);
                return;
            }           


        }

        private void doRevokeAdmin(string email)
        {


            if (!currentUser.IsAdmin)
            {
                Response.Redirect("~/admin.aspx?type=user&msg=You have no authority to revoke admin users!");
                return;
            }


            RentItServices.User[] users = utility.getAllUsers();
            int toChange = 0;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Email.Equals(email))
                {
                    toChange = i;
                    i = users.Length;
                }
            }

            users[toChange].IsAdmin = false;
            if (utility.updateUser(users[toChange]))
            {
                Response.Redirect("~/admin.aspx?type=user&msg=User " + users[toChange].Username + " is no longer an administrator!");
            }
            else
            {
                Response.Redirect("~/admin.aspx?type=user&msg=Error revoking user as administrator!");
            }


        }

        private void doMakeAdmin(string email)
        {


            if (!currentUser.IsAdmin)
            {
                Response.Redirect("~/admin.aspx?type=user&msg=You have no authority to create admin users!");
                return;
            }


            RentItServices.User[] users = utility.getAllUsers();
            int toChange = 0;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Email.Equals(email))
                {
                    toChange = i;
                    i = users.Length;
                }
            }

            users[toChange].IsAdmin = true;
            if (utility.updateUser(users[toChange]))
            {
                Response.Redirect("~/admin.aspx?type=user&msg=User " + users[toChange].Username + " is now an administrator!");
            }
            else
            {
                Response.Redirect("~/admin.aspx?type=user&msg=Error making user as administrator!");
            }


        }

        private void doUnSuspend(string email)
        {


            if (!currentUser.IsAdmin)
            {
                Response.Redirect("~/admin.aspx?type=user&msg=You have no authority to unsuspend users!");
                return;
            }
 

            RentItServices.User[] users = utility.getAllUsers();
            int toChange = 0;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Email.Equals(email))
                {
                    toChange = i;
                    i = users.Length;
                }
            }

            users[toChange].IsSuspended = false;
            if (utility.updateUser(users[toChange]))
            {
                Response.Redirect("~/admin.aspx?type=user&msg=User " + users[toChange].Username+ " unsuspended!");
            }
            else
            {
                Response.Redirect("~/admin.aspx?type=user&msg=Error unsuspending user!");
            }


        }

        private void doSuspend(string email)
        {
            //can add code here to check if user is admin

            if (!currentUser.IsAdmin)
            {
                Response.Redirect("~/admin.aspx?type=user&msg=You have no authority to suspend users!");
                return;
            }

            RentItServices.User[] users = utility.getAllUsers();
            int toChange = 0;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Email.Equals(email))
                {
                    toChange = i;
                    i = users.Length;
                }
            }
            
            users[toChange].IsSuspended = true;
            if (utility.updateUser(users[toChange]))
            {
                Response.Redirect("~/admin.aspx?type=user&msg=User "+users[toChange].Username +" suspended!");
            }
            else
            {
                Response.Redirect("~/admin.aspx?type=user&msg=Error suspending user!");
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
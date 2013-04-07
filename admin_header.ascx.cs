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
        public RentItServices.User currentUser = null;

        public Utility utility = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            utility = new Utility();
            utility.loadClient();
            currentUser = getUser();

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


        protected void login_click(object sender, EventArgs e)
        {
            String inputEmail = this.Request.Form.Get("inputEmail");
            String inputPassword = this.Request.Form.Get("inputPassword");
            doLogin(inputEmail, inputPassword);
        }

        private void doLogin(string inputEmail, string inputPassword)
        {
            //execute login code for user login, stores session key if successful
            var login = utility.userLogin(inputEmail, inputPassword);
            if (login.Item1)
            {
                //TO BE IMPLEMENTED, USE BOOLEAN TO CHECK FOR ADMIN
                //store email and key in session
                Session["userEmail"] = login.Item2.Email;
                Session["userKey"] = login.Item3;

                Response.Redirect("~/admin.aspx?msg=Welcome, " + login.Item2.Username + "! Good to see you!");
            }
            else
            {
                Response.Redirect("~/admin.aspx?msg=Error, login failed!");
            }
        }
        protected void logoutButton_Click(object sender, EventArgs e)
        {

            utility.userLogout(currentUser.Email);
            //clear the session
            Session["userEmail"] = null;
            Session["userKey"] = null;
            Response.Redirect("~/admin.aspx?msg=You have logged out successfully!");
        }
    }
}
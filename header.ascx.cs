using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class header : System.Web.UI.UserControl
    {
        //these are used by UI for display
        public bool login = false;
        public String username = null;
        public String email = null;
        public int userid = 0;
        public string dp_url = null;
        public float edollar = 0;

        public Utility utility = null;
        public RentItServices.User currentUser = null;

        public RentItServices.Country[] country_list = null;
        public RentItServices.Rental[] rental_list = null;

        private static string URL_SPACE = "%20";
        private static string REG_FAIL = "Registration" + URL_SPACE + "Failed";
        private static string REG_AGAIN = "Please" + URL_SPACE + "register" + URL_SPACE + "again.";
        private static string PWD_AGAIN = "Please" + URL_SPACE + "enter" + URL_SPACE + "password" + URL_SPACE + "again.";
        private static string LOGIN_FAIL = "Login" + URL_SPACE + "Failed";
        private static string LOGIN_AGAIN = "Please" + URL_SPACE + "Login" + URL_SPACE + "again.";

        protected void Page_Load(object sender, EventArgs e)
        {
            //load webservice client
            utility = new Utility();
            utility.loadClient();

            //call the web service to retrieve list of country
            country_list = utility.getCountries();

            //call the web service to retrieve list of rental history
            currentUser = utility.getUser(email);
            rental_list = utility.getRentalHistory(currentUser);
        }

        protected void register_click(object sender, EventArgs e)
        {
            currentUser = new RentItServices.User();
            currentUser.Email = this.Request.Form.Get("signup_email");
            String password1 = this.Request.Form.Get("signup_password1");
            String password2 = this.Request.Form.Get("signup_password2");

            if (this.Request.Form.Get("signup_gender").Equals("Male"))
            {
                currentUser.Gender = RentItServices.Gender.Male;
            }
            else
            {
                currentUser.Gender = RentItServices.Gender.Female;
            }

            currentUser.Age = int.Parse(this.Request.Form.Get("signup_age"));
            int country_position = int.Parse(this.Request.Form.Get("signup_country"));
            currentUser.Country = country_list[country_position];

            if (password1.Equals("") || password2.Equals(""))
            {
                redirect_error(REG_FAIL, PWD_AGAIN);
            }
            else
            {
                if (password1.Equals(password2))
                {
                    currentUser.Password = password1;
                }
                else
                {
                    redirect_error(REG_FAIL, PWD_AGAIN);
                }
            }

            if (utility.createUser(currentUser.Email, currentUser.Password, currentUser.Gender, currentUser.Country, currentUser.Age))
            {

                redirect_user(currentUser.Email);
            }
            else
            {
                redirect_error(REG_FAIL, REG_AGAIN);
            }

        }

        private void redirect_error(String msgTitle, String msg)
        {
            Response.Redirect("~/index.aspx?msgTitle=" + msgTitle + "&msg=" + msg);
        }

        private void redirect_user(String userEmail)
        {
            Response.Redirect("~/index.aspx?user=" + userEmail);
        }

        protected void login_click(object sender, EventArgs e)
        {
            String inputEmail = this.Request.Form.Get("inputEmail");
            String inputPassword = this.Request.Form.Get("inputPassword");
            if (utility.userLogin(inputEmail, inputPassword))
            {
                redirect_user(inputEmail);
            }
            else
            {
                redirect_error(LOGIN_FAIL, LOGIN_AGAIN);
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {

            //still cannot work yet cos no current user
            utility.userLogout(currentUser.Email);
            Response.Redirect("~/index.aspx?msg=You have logged out successfully!");
        }




      
    }

      
}
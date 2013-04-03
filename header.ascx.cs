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
        public RentIt.RentItServices.MovieCategory[] movie_category_list = null;
        public RentIt.RentItServices.MusicCategory[] music_category_list = null;
        public RentItServices.Rental[] rental_list = null;
        
        private static string REG_FAIL = "Registration Failed";
        private static string REG_AGAIN = "Please register again.";
        private static string PWD_AGAIN = "Please enter password again.";

        private static string LOGIN_FAIL = "Login Failed";
        private static string LOGIN_AGAIN = "Please login again.";

        protected void Page_Load(object sender, EventArgs e)
        {
            //load webservice client
            utility = new Utility();
            utility.loadClient();

            //call the web service to load data
            country_list = utility.getCountries();
           music_category_list = utility.getMusicCategories();
            movie_category_list = utility.getMovieCategories();

            currentUser = getUser();
            if (currentUser != null)
            {
                //if user is not null, load his history
                rental_list = utility.getRentalHistory(currentUser);
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

                doLogin(currentUser.Email, currentUser.Password);
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
                //store email and key in session
                Session["userEmail"] = login.Item2.Email;
                Session["userKey"] = login.Item3;
                
                Response.Redirect("~/index.aspx?msg=Welcome, " + login.Item2.Username + "! Good to see you!");
                //redirect_user(inputEmail);
            }
            else
            {
                redirect_error(LOGIN_FAIL, LOGIN_AGAIN);
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {

            utility.userLogout(currentUser.Email);
            //clear the session
            Session["userEmail"] = null;
            Session["userKey"] = null;
            Response.Redirect("~/index.aspx?msg=You have logged out successfully!");
        }




      
    }

      
}
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

        public string[] countries = null;

        public Utility utility = null;
        public RentItServices.User currentUser = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //load webservice client
            utility = new Utility();
            utility.loadClient();

            //call the web service to retrieve list of country here
            countries = new string[] { "Singapore", "Denmark", "Others" };
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
            currentUser.Country = this.Request.Form.Get("signup_country");

            String msgTitle = "Registration%20Failed";
            
            if (password1.Equals("") || password2.Equals(""))
            {
                redirect(msgTitle, "Please%20enter%20password%20again.");
            } else {
                if (password1.Equals(password2))
                {
                    currentUser.Password = password1;
                }
                else
                {
                    redirect(msgTitle, "Please%20enter%20password%20again.");
                }
            }

            if (utility.createUser(currentUser.Email, currentUser.Password))
            {
                Response.Redirect("~/index.aspx?type=login");
            }
            else
            {
                redirect(msgTitle, "Please%20register%20again.");
            }
        
        }
            
        private void redirect(String msgTitle, String msg)
        {
            Response.Redirect("~/index.aspx?msgTitle=" + msgTitle + "&msg=" + msg);
        }

    }
}
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
            currentUser.Email = Request.QueryString["email"];
            currentUser.Name = Request.QueryString["username"];
            if (Request.QueryString["Password1"].Equals(Request.QueryString["Password2"])) 
            {
                currentUser.Password = Request.QueryString["Password1"];
            }

            if (utility.createUser(currentUser.Email, currentUser.Password))
            {
                Response.Redirect("~/index.aspx?type=login");
            }
            else
            {
                Response.Redirect("~/index.aspx?msgTitle=Registration%20failed&msg=Please%20register%20again.");
            }

        }        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class admin : System.Web.UI.Page
    {
        public bool login = false;
        public String username = null;
        public String email = null;
        public int userid = 0;
        
        public String msg = null;
        public String msgTitle = null;

        public Utility utility = null;
        public RentItServices.User currentUser = null;
        
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
            //GET params that determine what UI to show
            String actionType = Request.QueryString["type"];
            String param = Request.QueryString["param"];
            String item = Request.QueryString["item"];

            //GET params that determine if a msg need to be displayed
            String msgTitle = Request.QueryString["msgTitle"];
            String msg = Request.QueryString["msg"];

            //load webservice client
            utility = new Utility();
            utility.loadClient();
            
            //INSERT CODE TO GRAB USER INFO/LOGIN STATE HERE
           // login = false;
            //userid = 25;
            //username = "Weikiat";
            //email = "i@weikiat.net";

            //currentUser = getUser();

            //PREPARE THE NAV BAR WITH INFO
            admin_header thisHeader = (admin_header)LoadControl("~/admin_header.ascx");
            currentUser = getUser();

            if (currentUser != null)
            {

                //login = true;                  
                //login = utility.isLoggedIn(currentUser);
                login = true;
                thisHeader.login = login;

                thisHeader.userid = currentUser.UserId;
                thisHeader.username = currentUser.Username;
                thisHeader.email = currentUser.Email;
               

            }

            headerBar.Controls.Add(thisHeader);

            //PREPARE MSG BAR
            if (msg != null)
            {
                showMsg(msgTitle, msg);
            }

          


            if (login)
            {
                if (actionType == "analytics")
                {
                    showAnalytics();
                }
                if (actionType == "user")
                {
                    showUserUI();
                }
                if (actionType == "media")
                {
                    showListMediaUI();
                }

                if (item != null)
                { //handle ITEM VIEW

                    //if a param is provided, proceed to do ITEM VIEW
                    showMediaItemUI(Convert.ToInt32(item));
                }

            }
            else
            {

            }
        }

        private void showAnalytics()
        {
            admin_analyatics_part adminA = (admin_analyatics_part)LoadControl("~/admin_analyatics_part.ascx");
            mainBody.Controls.Add(adminA);
        }

        private void showListMediaUI()
        {
            admin_media_part adminMedia = (admin_media_part)LoadControl("~/admin_media_part.ascx");
            mainBody.Controls.Add(adminMedia);
        }

        private void showMediaItemUI(int itemID) //HANDLES ITEM VIEW UI
        {
            //attach the listing to UI
            admin_media_itemview_part viewUI = (admin_media_itemview_part)LoadControl("~/admin_media_itemview_part.ascx");
            viewUI.itemID = itemID;
            mainBody.Controls.Add(viewUI);
        }

        private void showUserUI(){
            admin_user_part adminUser = (admin_user_part)LoadControl("~/admin_user_part.ascx");
            mainBody.Controls.Add(adminUser);
        }

        private void showMsg(string msgTitle, string msg)
        {
            //attach the msgbar to UI
            msgbar_part msgBar = (msgbar_part)LoadControl("~/msgbar_part.ascx");
            msgBar.msgTitle = msgTitle;
            msgBar.msg = msg;
            mainBody.Controls.Add(msgBar);
        }

    }
}
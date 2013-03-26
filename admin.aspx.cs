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
        protected void Page_Load(object sender, EventArgs e)
        {
            //GET params that determine what UI to show
            String actionType = Request.QueryString["type"];
            String param = Request.QueryString["param"];

            //GET params that determine if a msg need to be displayed
            String msgTitle = Request.QueryString["msgTitle"];
            String msg = Request.QueryString["msg"];
            /*
            //LOAD WEBSERVICE CLIENT
            utility = new Utility();
            utility.loadClient();
            */
            //INSERT CODE TO GRAB USER INFO/LOGIN STATE HERE
            login = true;
            userid = 25;
            username = "Weikiat";
            email = "i@weikiat.net";


            /*login = utility.isLoggedIn(currentUser);
            currentUser = utility.getUser(email);
            */


            //PREPARE THE NAV BAR WITH INFO
            admin_header thisHeader = (admin_header)LoadControl("~/admin_header.ascx");
            thisHeader.login = login;
            thisHeader.userid = userid;
            thisHeader.username = username;
            thisHeader.email = email;


            headerBar.Controls.Add(thisHeader);

            //PREPARE MSG BAR
            if (msg != null)
            {
                showMsg(msgTitle, msg);
            }


            if (login)
            {
                if (actionType == "user")
                {
                    showUserUI();
                }
                if (actionType == "media")
                {
                    showMediaUI();
                }

            }
            else
            {

            }
        }

        private void showMediaUI()
        {
            admin_media_part adminMedia = (admin_media_part)LoadControl("~/admin_media_part.ascx");
            mainBody.Controls.Add(adminMedia);
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
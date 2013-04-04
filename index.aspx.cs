using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class index : System.Web.UI.Page
    {

        public bool login = false;
        public String username = null;
        public String email = null;
        public int userid = 0;
        public String dp_url = null;
        public float edollar = 0;

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

            //PREPARE THE NAV BAR WITH INFO
            header thisHeader = (header)LoadControl("~/header.ascx");

            currentUser = getUser();
           
                if (currentUser!=null)
                {

                    //login = true;
                  
                    //login = utility.isLoggedIn(currentUser);
                    login = true;
                    thisHeader.login = login;

                    thisHeader.userid = currentUser.UserId;
                    thisHeader.username = currentUser.Username;
                    thisHeader.email = currentUser.Email;
                    thisHeader.dp_url = currentUser.FbImageUrl;
                    thisHeader.edollar = currentUser.Credits;

                }
           /*

                //INSERT CODE TO GRAB USER INFO/LOGIN STATE HERE
                login = true;
                userid = 25;
                username = "Weikiat";
                email = "i@weikiat.net";
                edollar = 50.0F;
                dp_url = "https://graph.facebook.com/514457901/picture?type=square";

                //PREPARE THE NAV BAR WITH INFO            
                thisHeader.login = login;
                thisHeader.userid = userid;
                thisHeader.username = username;
                thisHeader.email = email;
                thisHeader.dp_url = dp_url;
                thisHeader.edollar = edollar; 

            */
            headerBar.Controls.Add(thisHeader);
            
            //PREPARE MSG BAR
            if (msg != null)
            {
                showMsg(msgTitle, msg);
            }

            //login = true;
            //PREPARE MAIN BODY UI
            if (login)
            {
                if (actionType == null)
                {
                    //if user is loggedin, default to most popular UI

                    if (item != null)
                    { //handle ITEM VIEW

                        //if a param is provided, proceed to do ITEM VIEW
                        showItemUI(Convert.ToInt32(item));

                    }
                    else
                    {
                        showListUI(0);
                    }

                }

                else
                {
                    actionType = actionType.ToLower();
                    //determine which UI to show base on action type
                    if (actionType == "popular")
                    {
                        showListUI(0);
                    }
                    if (actionType == "music")
                    {
                        showListUI(2,null, Convert.ToInt32(param));
                    }
                    if (actionType == "movie")
                    {
                        showListUI(3, null, Convert.ToInt32(param));
                    }
                    if (actionType == "search")
                    { //handle search action
                        if (param != null)
                        {
                            //if a keyword is provided, trigger show search UI
                            showListUI(1, param,0);
                        }
                        else
                        {
                            //no keyword provided, default the most popular UI
                            showListUI(0);
                        }
                    }
                   
                }
            }
            else
            {
                //SINCE NOT LOGIN, add the splash
                splash_carousel splasher = (splash_carousel)LoadControl("~/splash_carousel.ascx");
                mainBody.Controls.Add(splasher);
            }


        }

        private void showItemUI(int itemID) //HANDLES ITEM VIEW UI
        {
            //attach the listing to UI
            itemview_part viewUI = (itemview_part)LoadControl("~/itemview_part.ascx");
            viewUI.itemID = itemID;
            mainBody.Controls.Add(viewUI);
        
        }

        private void showListUI(int listType, String keyword = null,int categoryId=0) //HANDLES LIST VIEW UI
        {
            //attach the listing to UI
            itemlist_part listUI = (itemlist_part)LoadControl("~/itemlist_part.ascx");
            listUI.listType = listType;

            if ((listType == 2) || (listType == 3))
            {
                listUI.categoryId = categoryId;
            }
          
            if (listType == 1)
            {
                listUI.keyword = keyword;
            }
            mainBody.Controls.Add(listUI);
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
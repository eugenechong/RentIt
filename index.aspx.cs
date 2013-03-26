﻿using System;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            //GET params that determine what UI to show
            String actionType = Request.QueryString["type"];
            String param = Request.QueryString["param"];

            //GET params that determine if a msg need to be displayed
            String msgTitle = Request.QueryString["msgTitle"];
            String msg = Request.QueryString["msg"];

            //load webservice client
            utility = new Utility();
            utility.loadClient();
            
            //INSERT CODE TO GRAB USER INFO/LOGIN STATE HERE
            login = false;
            userid = 25;
            username = "Weikiat";
            email = "i@weikiat.net";
            edollar = 50.0F;
            dp_url = "https://graph.facebook.com/514457901/picture?type=square";

            /*login = utility.isLoggedIn(currentUser);
            currentUser = utility.getUser(email);
            */


            //PREPARE THE NAV BAR WITH INFO
            header thisHeader = (header)LoadControl("~/header.ascx");
            thisHeader.login = login;
            thisHeader.userid = userid;
            thisHeader.username = username;
            thisHeader.email = email;
            thisHeader.dp_url = dp_url;
            thisHeader.edollar = edollar;

            headerBar.Controls.Add(thisHeader);

            //PREPARE MSG BAR
            if (msg != null)
            {
                showMsg(msgTitle, msg);
            }


            //PREPARE MAIN BODY UI
            if (login)
            {
                if (actionType == null)
                {
                    //if user is loggedin, default to most popular UI
                    showListUI(0);
                }
                else
                {
                    actionType = actionType.ToLower();
                    //determine which UI to show base on action type
                    if (actionType == "popular")
                    {
                        showListUI(0);
                    }
                    if (actionType == "search")
                    { //handle search action
                        if (param != null)
                        {
                            //if a keyword is provided, trigger show search UI
                            showListUI(1, param);
                        }
                        else
                        {
                            //no keyword provided, default the most popular UI
                            showListUI(0);
                        }
                    }
                    if (actionType == "item")
                    { //handle ITEM VIEW
                        if (param != null)
                        {
                            //if a param is provided, proceed to do ITEM VIEW
                            showItemUI(Convert.ToInt32(param));
                        }
                        else
                        {
                            //NO ITEM ID PROVIDED, default to most popular UI
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

        private void showListUI(int listType, String keyword = null) //HANDLES LIST VIEW UI
        {
            //attach the listing to UI
            itemlist_part listUI = (itemlist_part)LoadControl("~/itemlist_part.ascx");
            listUI.listType = listType;
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
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace RentIt
{
    public class Utility
    {
        RentItServices.IRentitService rentItServiceClient;
        
        public void loadClient()
        {
            this.rentItServiceClient = new RentItServices.RentitServiceClient();
        }

        public bool createUser(String userEmail, String userPwd)
        {
            return rentItServiceClient.CreateUser(userEmail, userPwd).Item1;            
        }

        public RentItServices.User getUser(String userEmail)
        {
            return rentItServiceClient.GetUser(userEmail).Item1;
        }

        public bool isLoggedIn(RentItServices.User user)
        {
            return rentItServiceClient.IsLoggedIn(user).Item1;
        }

        public bool userLogin(String userEmail, String userPwd)
        {
            return rentItServiceClient.Login(userEmail, userPwd).Item1;
        }

        public bool userLogout(String userEmail)
        {
            return rentItServiceClient.Logout(userEmail).Item1;
        }

        public bool updateUser(RentItServices.User user)
        {
            return rentItServiceClient.UpdateUser(user).Item1;
        }

        public bool commentMedia(int mediaId, RentItServices.User user, String comment)
        {
            return rentItServiceClient.CommentMedia(mediaId, user, comment).Item1;
        }

        public RentItServices.Media getMedia(int mediaId)
        {
            return rentItServiceClient.GetMedia(mediaId).Item1;
        }

        public bool uploadMedia(RentItServices.Media media, RentIt.RentItServices.User admin)
        {
            return rentItServiceClient.UploadMedia(media, admin).Item1;
        }

        public bool updateMedia(RentItServices.Media media)
        {
            return rentItServiceClient.UpdateMedia(media).Item1;
        }

        public RentItServices.Media[] searchMediaFromTitle(String title)
        {
            return rentItServiceClient.SearchMediaFromTitle(title).Item1;
        }

        public RentItServices.Media[] searchMediaFromCategory(String category)
        {
            return rentItServiceClient.SearchMediaFromCategory(category).Item1;
        }

        public bool rentMedia(int mediaId, RentItServices.User user, int credits)
        {
            return rentItServiceClient.RentMedia(mediaId, user, credits).Item1;
        }

        public static String GetTeamPath(String serverPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(serverPath + "team.txt"))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
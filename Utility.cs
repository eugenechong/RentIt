using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using RentIt.RentItServices;
using System.Drawing;


namespace RentIt
{
    
    public class Utility
    {
        RentItServices.IRentitService rentItServiceClient;
        RentItServices.IRentItFileService rentItFileServiceClient;
        
        public void loadClient()
        {
            this.rentItServiceClient = new RentItServices.RentitServiceClient();            
        }

        public bool deleteBookMark(User user, int mediaId)
        {
            Media tempMedia= this.rentItServiceClient.GetMedia(mediaId).Item1;
            return this.rentItServiceClient.RemoveBookmark(user.Email, tempMedia).Item1;
        }

        public Media[] getUserBookmarks(User user)
        {
            return this.rentItServiceClient.GetUserBookmarks(user.Email).Item1;
        }

        public bool isRented(int mediaId,User user)
        {
            return this.rentItServiceClient.IsRented(mediaId, user).Item1;
        }
        
        public bool rateMedia(int mediaId, User user, int rating)
        {
            return this.rentItServiceClient.RateMedia(mediaId, user, rating).Item1;
        }

        public void loadFileService()
        {
            this.rentItFileServiceClient = new RentItServices.RentItFileServiceClient();
        }

        public UploadFileResult uploadFile(RentIt.RentItServices.UploadFileRequest request)
        {
           return rentItFileServiceClient.UploadFile(request);
        }

        public bool createUser(String email, String password, RentIt.RentItServices.Gender gender, RentIt.RentItServices.Country country, int age)
        {
            return rentItServiceClient.CreateUser(email, password, gender, country, age).Item1; 
        }

        public RentItServices.User getUser(String userEmail,String userKey)
        {
            //Open the channel


            RentitServiceClient channel = new RentitServiceClient();
            //Open a Scope
            using (new OperationContextScope(channel.InnerChannel))
            {
                //Make custom header, important that the two first parameters is Validate and Validator. 
                //The tuple should contain, the user making the calls email and the users email
                MessageHeader customheader = MessageHeader.CreateHeader("Validate", "Validator",
                                                                        new Tuple<string, string>(userEmail, userKey));
                //Add the header
                OperationContext.Current.OutgoingMessageHeaders.Add(customheader);
                //This method will have the header
                var user1 = channel.GetUser(userEmail);
                return user1.Item1;//rentItServiceClient.GetUser(userEmail).Item1;
            }
            //This method will not have the header, since its out of the using
            //var user2 = channel.GetUser(userEmail);
           // return user1.Item1;//rentItServiceClient.GetUser(userEmail).Item1;
        }

        public bool isLoggedIn(RentItServices.User user)
        {
            return true;

            // return rentItServiceClient.IsLoggedIn(user).Item1;
        }

        public Tuple<bool,User,string,string> userLogin(String userEmail, String userPwd)
        {

            var login = rentItServiceClient.Login(userEmail, userPwd) ;
            //var details = rentItServiceClient.Login(userEmail, userPwd); 
            /*if (login.Item1)
            {
                
                userEmail = login.Item2.Email;
                userKey = login.Item3;
             
            }*/

            return login;

        
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public RentIt.RentItServices.MusicCategory getMusicCatFromID(int id){
            RentIt.RentItServices.MusicCategory cats = getMusicCategories()[id -1];
            return cats;
        }
                
        public RentIt.RentItServices.MovieCategory getMovieCatFromID(int id)
        {
            RentIt.RentItServices.MovieCategory cats = getMovieCategories()[id -1];
            return cats;
        }

        public Tuple<Media[], string> getPopularList()
        {
            return rentItServiceClient.GetMostPopularMedia(5);
        }

        public bool userLogout(String userEmail)
        {
            return rentItServiceClient.Logout(userEmail).Item1;
        }

        public bool updateUser(RentItServices.User user)
        {
            return rentItServiceClient.UpdateUser(user).Item1;
        }

        public bool commentMedia(int mediaId, RentItServices.User user,  String comment)
        {
            return rentItServiceClient.CommentMedia(mediaId,user,"",comment).Item1;
        }

        public RentItServices.Media getMedia(int mediaId)
        {
            return rentItServiceClient.GetMedia(mediaId).Item1;
        }

        public bool updateMedia(RentItServices.Media media)
        {
            return rentItServiceClient.UpdateMedia(media).Item1;
        }

        public bool deleteMedia(int mediaId)
        {
            return rentItServiceClient.DeleteMedia(mediaId).Item1;
        }

        public RentItServices.Media[] searchMediaFromTitle(String title)
        {
            return rentItServiceClient.SearchMediaFromTitle(title).Item1;
        }

        public RentItServices.Media[] searchMusicFromCategory(String category)
        {
            return rentItServiceClient.SearchMusicFromCategory(category).Item1;
        }

        public RentItServices.Media[] searchMovieFromCategory(String category)
        {
            return rentItServiceClient.SearchMovieFromCategory(category).Item1;
        }

        public Tuple<bool,string> rentMedia(int mediaId, RentItServices.User user, double duration)
        {
            return rentItServiceClient.RentMedia(mediaId, user, duration);
        }

        public RentIt.RentItServices.User[] getAllUsers()
        {
            return rentItServiceClient.GetAllUsers().Item1;
        }

        public RentIt.RentItServices.Media[] getAllMedia()
        {
            return rentItServiceClient.GetAllMedia().Item1;
        }

        public RentIt.RentItServices.Country[] getCountries()
        {            
            return rentItServiceClient.GetCountries();
        }

        public string getMediaUrl(int mediaId)
        {
            return rentItServiceClient.GetMediaUrl(mediaId).Item1;
        }

        public RentIt.RentItServices.Rental[] getRentalHistory(RentIt.RentItServices.User user) 
        {
            return rentItServiceClient.GetRentalHistory(user).Item1;
        }

        public RentIt.RentItServices.MovieCategory[] getMovieCategories()
        {
            return rentItServiceClient.GetMovieCategories();
        }

        public RentIt.RentItServices.MusicCategory[] getMusicCategories()
        {
            return rentItServiceClient.GetMusicCategories();
        }

        public bool bookmarkMedia(int mediaId, RentIt.RentItServices.User user)
        {
            return rentItServiceClient.BookmarkMedia(mediaId, user).Item1;
        }

        public bool uploadMedia(RentIt.RentItServices.Media media)
        {
            return rentItServiceClient.UploadByUrl(media).Item1;
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
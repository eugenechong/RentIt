﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class admin_media_part : System.Web.UI.UserControl
    {
        public Utility utility = null;

        public RentIt.RentItServices.User currentUser = null;
        public RentIt.RentItServices.MovieCategory[] movie_category_list = null;
        public RentIt.RentItServices.MusicCategory[] music_category_list = null;

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
            //load webservice client
            utility = new Utility();
            utility.loadClient();

            currentUser = getUser();

            music_category_list = utility.getMusicCategories();
            movie_category_list = utility.getMovieCategories();
        }

        protected void add_click(object sender, EventArgs e)
        {
            utility.loadFileService();            
                           
            RentIt.RentItServices.Music newMusic = null;
            RentIt.RentItServices.Movie newMovie = null;

            String title = this.Request.Form.Get("add-title");
            String shortdesc = this.Request.Form.Get("add-shortdescription"); 
            String longdesc = this.Request.Form.Get("add-longdescription");
            String category = this.Request.Form.Get("add_category_list");
            category = category.Substring(category.IndexOf('-') + 1);
            double rentalPrice = Convert.ToDouble(this.Request.Form.Get("add-rental-price"));
            String thumbnail_url = this.Request.Form.Get("add-thumbnail-url");
            String media_url = this.Request.Form.Get("add-media-url");

            if (this.Request.Form.Get("media_type").Equals("Music")) {
                newMusic = new RentIt.RentItServices.Music();
                newMusic.Title = title;
                newMusic.SmallDescription = shortdesc;
                newMusic.Description = longdesc;
                                              
                for (int i=0; i<music_category_list.Length; i++) {
                    if (music_category_list[i].Title.Equals(category)) {
                        newMusic.Category = music_category_list[i];
                        break;
                    } 
                }

                newMusic.RentalPrice = rentalPrice;
                newMusic.Thumbnail = thumbnail_url;
                newMusic.Source = media_url;
            } else {
                newMovie = new RentIt.RentItServices.Movie();
                newMovie.Title = title;
                newMovie.SmallDescription = shortdesc;
                newMovie.Description = longdesc;
                
                for (int i=0; i<movie_category_list.Length; i++) {
                    if (movie_category_list[i].Title.Equals(category)) {
                        newMovie.Category = movie_category_list[i];
                        break;
                    } 
                }

                newMovie.RentalPrice = rentalPrice;
                newMovie.Thumbnail = thumbnail_url;
                newMovie.Source = media_url;
            }

            RentIt.RentItServices.UploadFileRequest uploadRequest = new RentItServices.UploadFileRequest();
            if (newMusic != null) {
                uploadRequest.MediaLoginAndUserTuple = new Tuple<string, RentItServices.Media, RentItServices.User>(currentUser.SharedKey, newMusic, currentUser);
            } else {
                uploadRequest.MediaLoginAndUserTuple = new Tuple<string, RentItServices.Media, RentItServices.User>(currentUser.SharedKey, newMovie, currentUser);
            }
            RentIt.RentItServices.UploadFileResult uploadResult = new RentItServices.UploadFileResult(false, "");
            uploadResult = utility.uploadFile(uploadRequest);
            
            if (uploadResult.Success)
            {
                Response.Redirect("admin.aspx?type=media&msg=You have successfully uploaded " + title + "!&msgTitle=Media Uploaded");
            }
            else
            {
                Response.Redirect("admin.aspx?type=media&msg=There was a problem uploading " + title + "!&msgTitle=Media Failed to Upload");
            }
            

        }

/*
        protected void update_click(object sender, EventArgs e)
        {

        }

        protected void delete_click(object sender, EventArgs e)
        {
            utility.DeleteMedia();
        }
*/
        

    }
}
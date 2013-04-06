using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class admin_media_itemview_part : System.Web.UI.UserControl
    {

        public int itemID = 0;

        public Utility utility = null;
        public RentItServices.Media media = null;

        public RentIt.RentItServices.MovieCategory[] movie_category_list = null;
        public RentIt.RentItServices.MusicCategory[] music_category_list = null;
        public string media_url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            utility = new Utility();
            utility.loadClient();

            //call the web service to retrieve media data
            media = utility.getMedia(itemID);                        
            media_url = utility.getMediaUrl(media.MediaId);

            music_category_list = utility.getMusicCategories();
            movie_category_list = utility.getMovieCategories();
        }

        protected void update_click(object sender, EventArgs e)
        {            
            RentIt.RentItServices.Music editMusic = null;
            RentIt.RentItServices.Movie editMovie = null;

            String title = this.Request.Form.Get("edit-title");
            String shortdesc = this.Request.Form.Get("edit-shortdescription");
            String longdesc = this.Request.Form.Get("edit-longdescription");
            String category = this.Request.Form.Get("edit_category_list");
            category = category.Substring(category.IndexOf('-') + 1);
            double rentalPrice = Convert.ToDouble(this.Request.Form.Get("edit-rental-price"));
            String thumbnail_url = this.Request.Form.Get("edit-thumbnail-url");
            String media_url = this.Request.Form.Get("edit-media-url");

            if (media.GetType().Name.Equals("Music"))
            {
                editMusic = new RentIt.RentItServices.Music();
                editMusic.Title = title;
                editMusic.SmallDescription = shortdesc;
                editMusic.Description = longdesc;

                for (int i = 0; i < music_category_list.Length; i++)
                {
                    if (music_category_list[i].Title.Equals(category))
                    {
                        editMusic.Category = music_category_list[i];
                        break;
                    }
                }

                editMusic.RentalPrice = rentalPrice;
                editMusic.Thumbnail = thumbnail_url;
                editMusic.Source = media_url;
                //editMusic.UploadedBy = currentUser; //to change
            }
            else
            {
                editMovie = new RentIt.RentItServices.Movie();
                editMovie.Title = title;
                editMovie.SmallDescription = shortdesc;
                editMovie.Description = longdesc;

                for (int i = 0; i < movie_category_list.Length; i++)
                {
                    if (movie_category_list[i].Title.Equals(category))
                    {
                        editMovie.Category = movie_category_list[i];
                        break;
                    }
                }

                editMovie.RentalPrice = rentalPrice;
                editMovie.Thumbnail = thumbnail_url;
                editMovie.Source = media_url;
                //editMovie.UploadedBy = currentUser; //to change
            }

            media = null;
            if (editMusic != null)
            {
                media = editMusic;
            }
            else
            {
                media = editMovie;
            }              

            if (utility.updateMedia(media))
            {
                Response.Redirect("admin.aspx?type=media&msg=You have successfully updated media information for " + title);
            }
            else
            {
                Response.Redirect("admin.aspx?type=media&msg=There was a problem updating media information for " + title);
            }
        }

        protected void delete_click(object sender, EventArgs e)
        {
            bool success = utility.deleteMedia(itemID);
            if (success)
            {
                Response.Redirect("admin.aspx?type=media&msg=You have successfully deleted " + media.Title);
            }
            else
            {
                Response.Redirect("admin.aspx?type=media&msg=There was a problem deleting " + media.Title + "&msg=Media Not Deleted");
            }
        }

    }
}
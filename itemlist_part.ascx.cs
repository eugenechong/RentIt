using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentIt
{
    public partial class itemlist_part : System.Web.UI.UserControl
    {
        public int listType = 0; //popular items = 0, search = 1; etc
        public String headerText = null;
        public string keyword = null;
        public int categoryId = 0;
        public Utility utility = null;
        public RentItServices.Media[] media_list = null;
        public bool noContent = false;
        public bool foreignItems = false;
        public Team01Rentit.Book[] book_list = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //load webservice client
            utility = new Utility();
            utility.loadClient();  
          
           
            switch (listType)
            {
                case 0:
                    headerText = "Most Popular Media";
                    //DO THE CODE TO GRAB MOST POPULAR LISTING
                    media_list = utility.getPopularList().Item1;
                    break;
                case 1:
                    headerText = "Search Result for \""+ keyword +"\"";
                    //DO THE CODE TO GRAB SEARCH RESULT LISTING HERE
                    media_list = utility.searchMediaFromTitle(keyword);
                    break;
                case 2:
                    //deals with music categories
                    RentItServices.MusicCategory thisCat = utility.getMusicCatFromID(categoryId);//get the entire category object for this category id
                    headerText="Browsing "+thisCat.Title+ " Category";
                    media_list = utility.searchMusicFromCategory(thisCat.Title);
                    break;
                case 3:
                    //deals with movie categories
                    RentItServices.MovieCategory thisCat2 = utility.getMovieCatFromID(categoryId);//get the entire category object for this category id
                    headerText = "Browsing " + thisCat2.Title + " Category";
                    media_list = utility.searchMovieFromCategory(thisCat2.Title);
                    break;
                case 4:
                    //deals with book categories
                    Team01Rentit.ISMURentItService team01_ws = new Team01Rentit.SMURentItServiceClient();
                    book_list= team01_ws.GetAllBooks();
                    headerText = "Browsing books from Team 01";
                    foreignItems = true;
                    //media_list.add = null;//utility.searchMovieFromCategory(thisCat2.Title);
                    break;


                default:
                    Response.Redirect("?msg=Error figuring out which category you are trying to view!");
                    break;

            }

            bool emptyBook = true;
            bool emptyMedia = true;
            if ((media_list != null) && (media_list.Length > 0))
            {
                emptyMedia = false;
            }
            if ((book_list != null) && (book_list.Length > 0))
            {
                emptyBook = false;
            }


            if ((emptyMedia)&&(emptyBook))

            {
                noContent = true;
            }
        }
      
     

    }
}
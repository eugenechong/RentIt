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

        public Utility utility = null;
        public RentItServices.Media[] media_list = null;

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
                    //media_list = utility.getMostPopularMedia();
                    break;
                case 1:
                    headerText = "Search Result for \""+ keyword +"\"";
                    //DO THE CODE TO GRAB SEARCH RESULT LISTING HERE
                    media_list = utility.searchMediaFromTitle(keyword);
                    break;

            }
        }

     

    }
}
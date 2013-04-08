using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RentIt
{
   
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {
        
        Team01Rentit.ISMURentItService rentItServices2;

        public void ProcessRequest (HttpContext context)
        {
            context.Response.Clear();

            if (!String.IsNullOrEmpty(context.Request.QueryString["id"])) //When there is a valid book id
            {
                int id = Int32.Parse(context.Request.QueryString["id"]);

                // Now we have the book id, which we need, in order to find the image
                // Pass the id to the GetImage method
                Image image = GetImage(id);

                // The context is the Image control
                // We set the contenttype to "image/jpeg" as that is our image format
                context.Response.ContentType = "image/jpeg";
                // Save the image to the OutputStream of the context
                image.Save(context.Response.OutputStream, ImageFormat.Jpeg);
            }
            else //If the book id is not set for some reason
            {
                //...
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
            //This method will get the memory stream for the image for the book which 
            //have the id you pass as parameter, and convert it to an image which it 
            //will return
        
        private Image GetImage(int id)
	    {
		    //get memorystream from server
            this.rentItServices2 = new Team01Rentit.SMURentItServiceClient();
            MemoryStream stream = rentItServices2.DownloadImage(id);
		    //Create the image and return it
		    return Image.FromStream(stream);
        }
    }
}
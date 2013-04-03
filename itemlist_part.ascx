<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="itemlist_part.ascx.cs" Inherits="RentIt.itemlist_part" %>

<div class="container ">
    <h2><%=headerText %></h2>
    <ul class="thumbnails span12 ">

       <!-- <li class="span3 well" style="background-color: #3cb9c6; border: 1px solid #32a1ac;">
            <div class="thumbnail">
                <a href="index.aspx?type=item&param=1">
                    <img src="http://metrojolt.com/wp-content/uploads/2011/11/Adrian-Lux-Teenage-Crime-cover-art-300x300.jpg" alt="">
                </a>
                <h4><i class="icon-music"></i>&nbsp;Teenage Crime</h4>
                <p>A crazy awesome remix</p>
                <a href="index.aspx?type=item&param=1" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Click for more details or rent">More</a>
                <a href="#" class="btn btn-warning tip" data-placement="bottom" rel="tooltip" title="Add to bookmark"><i class="icon-bookmark"></i></a>
                <i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i>
            </div>
        </li>
        <li class="span3 well">
            <div class="thumbnail">
                <a href="index.aspx?type=item&param=2">
                    <img src="http://www.sundriesshack.com/wp-content/uploads/2009/12/TD_CoverArt_015.jpg" alt=""></a>
                <h4><i class="icon-music"></i>&nbsp;The Delivery</h4>
                <p>The guy looks a little too familar...</p>
                <a href="?type=item&param=2" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Click for more details or rent">More</a>
                <a href="#" class="btn btn-warning tip" data-placement="bottom" rel="tooltip" title="Add to bookmark"><i class="icon-bookmark"></i></a>
                <i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i>
            </div>
        </li>
        <li class="span3 well ">
            <div class="thumbnail">
                <a href="index.aspx?type=item&param=3">
                    <img src="http://moviemusicuk.files.wordpress.com/2010/10/ironman2cover.jpg" alt=""></a>
                <h4><i class="icon-facetime-video"></i>&nbsp;Iron Man 2</h4>
                <p>When one is not enough...</p>
                <a href="?type=item&param=3" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Click for more details or rent">More</a>
                <a href="#" class="btn btn-warning tip" data-placement="bottom" rel="tooltip" title="Add to bookmark"><i class="icon-bookmark"></i></a>
                <i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i>
            </div>
        </li>-->
        <!--LOOP MEDIA HERE-->         
        <%                
                for (int i = 0; i < media_list.Length; i++) { %>                                               
                <li class="span3 well">
                    <a href="index.aspx?type=item&param=<%=media_list[i].MediaId %>">
                      <img src="<%=media_list[i].Thumbnail %>" />
                        </a>
                    <h4>
                        <i class="icon-facetime-video"></i>&nbsp;<%=media_list[i].Title %></h4>
                    <p><%=media_list[i].SmallDescription %></p>
                    <a href="?type=item&param=<%=media_list[i].MediaId %>" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Click for more details or rent">More</a>
                    <a href="#" class="btn btn-warning tip" data-placement="bottom" rel="tooltip" title="Add to bookmark"><i class="icon-bookmark"></i></a>
                    
                    <% for (int j=0;j<media_list[i].AverageRating;j++){ %>
                        <i class="icon-star"></i>
                    <%} %>
                    <% for (int j=0;j<5-media_list[i].AverageRating;j++){ %>
                        <i class="icon-star-empty"></i>
                    <%} %>
                </li>
        <%      } 
             %>         
        <!--END LOOP-->
    </ul>

</div>

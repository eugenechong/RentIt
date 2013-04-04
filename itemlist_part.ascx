<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="itemlist_part.ascx.cs" Inherits="RentIt.itemlist_part" %>
<div class="container ">
    <h2><%=headerText %></h2>

    <% if (!noContent)
       { %><ul class="thumbnails span12 ">
        <!--LOOP MEDIA HERE-->
        <%                
           for (int i = 0; i < media_list.Length; i++)
           { %>
        <li class="span3 well" style="max-height: 350px; min-height: 350px;">
            <a href="index.aspx?type=item&param=<%=media_list[i].MediaId %>">
                <img src="<%=media_list[i].Thumbnail %>" />
            </a>
            <div style="max-height: 70px; min-height: 70px;">
                <h4>
                    <% if (media_list[i].GetType().ToString() == "Movie")
                       { %>
                    <i class="icon-facetime-video"></i>
                    <% }
                       else
                       { %>
                    <i class="icon-music"></i>
                    <% } %>

                        
                        &nbsp;<%=media_list[i].Title %></h4>
                <p><%=media_list[i].SmallDescription %></p>
            </div>
            <a href="?type=item&param=<%=media_list[i].MediaId %>" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Click for more details or rent">More</a>
            <a href="#" class="btn btn-warning tip" data-placement="bottom" rel="tooltip" title="Add to bookmark"><i class="icon-bookmark"></i></a>

            <% for (int j = 0; j < media_list[i].AverageRating; j++)
               { %>
            <i class="icon-star"></i>
            <%} %>
            <% for (int j = 0; j < 5 - media_list[i].AverageRating; j++)
               { %>
            <i class="icon-star-empty"></i>
            <%} %>
        </li>

        <%      } 
        %>
    </ul>
    <!--END LOOP-->
    <% }
       else
       {  %>
    <div class="container">
        <h4>No media matching your criteria found :(</h4>
        <i class=" icon-coffee icon icon-4x"></i><br /><br /><br />
        <p>Not to worry, we are constantly adding new content!</p>
        <br /><br />
    </div>
    <% } %>
</div>

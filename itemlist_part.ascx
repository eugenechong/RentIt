<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="itemlist_part.ascx.cs" Inherits="RentIt.itemlist_part" %>
<div class="container ">
    <h2><%=headerText %></h2>

    <% if (!noContent)
       { %><ul class="thumbnails span12 ">
        <!--LOOP MEDIA HERE-->
        <% if (!foreignItems){ %>
        <% //ITEMS HERE COME FROM OUR OWN WEB SERVICE               
           for (int i = 0; i < media_list.Length; i++)
           { %>
        <li class="span3 well" style="max-height: 350px; min-height: 350px;">
            <a href="index.aspx?item=<%=media_list[i].MediaId %>">
                <img src="<%=media_list[i].Thumbnail %>" style="height: 220px;"/>
            </a>
            <div style="max-height: 70px; min-height: 70px;">
                <h4>
                    <% if (media_list[i].GetType().Name == "Movie")
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
            <a href="?item=<%=media_list[i].MediaId %>" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Click for more details or rent">View Media</a>
            

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
   
    <%}else{ %>
             <% //ITEMS HERE COME FROM TEAM 1 WEB SERVICE               
           for (int i = 0; i < book_list.Length; i++)
           { %>
        <li class="span3 well" style="max-height: 450px; min-height: 450px;">
            <a target="_blank" href="http://green.smu.edu.sg/gspm2013/team01/bookPage.aspx?id=<%=book_list[i].Id %>">
                <img src="ImageHandler.ashx/?id=<%=book_list[i].Id %>" style="height: 320px;"/>
            </a>
            <div style="max-height: 70px; min-height: 70px;">
                <h4>
                   
                    <i class="icon-book"></i>
                    
                        
                        &nbsp;<%=book_list[i].Title %></h4>
                <p><%=book_list[i].Author %></p>
            </div>
            <a target="_blank" href="http://green.smu.edu.sg/gspm2013/team01/bookPage.aspx?id=<%=book_list[i].Id %>" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="You will be taken to Team 01's Rentit">View Book</a>
            

              &nbsp;  &nbsp;$<% =book_list[i].Price%>
        </li>

        <%      } 
        %>
   


    <% } %>
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

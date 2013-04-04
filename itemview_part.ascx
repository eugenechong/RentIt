<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="itemview_part.ascx.cs" Inherits="RentIt.itemview_part" %>

<div class="container">
    <div class="container-fluid well">
        <div class="row-fluid">
            <div class="span4 well" style="background-color: #4dccd9;">
                <p>
                    <img src="<%=media.Thumbnail %>" alt="">
                </p>

                <%
                    //generate the fb share link

                    string url = "https://www.facebook.com/dialog/feed?app_id=103996706365313&link=http://green.smu.edu.sg/gspm2013/team09/index.aspx?item=" + media.MediaId + "&" +
                              "picture=" + media.Thumbnail + "&" +
                              "name=" + media.Title + "&" +
                              "caption=RentIt Team 9&" +
                              "description=" + media.SmallDescription + "&" +
                              "redirect_uri=http://green.smu.edu.sg/gspm2013/team09/index.aspx?item=" + media.MediaId + "&";
                          
                    
                %>
                <asp:LinkButton ID="bookmarkButton" runat="server" class="btn btn-warning tip" OnClick="bookmarkButton_Click" data-placement="bottom" rel="tooltip" title="Add to bookmark"><i class="icon-bookmark"></i></asp:LinkButton>
                <a href="<%=url %>" class="btn btn-danger tip" data-placement="bottom" rel="tooltip" title="Share on Facebook"><i class="icon-share-alt"></i></a>
                
                <%if (!isRented){ %>
                <a href="#confirmRent" role="button" data-toggle="modal" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Rent this"><i class="icon-shopping-cart"></i>&nbsp;Rent for $<%=media.RentalPrice %></a>
                <% }else{ %>
                 <a href="#" role="button"  class="btn btn-success tip disabled" data-placement="bottom" rel="tooltip" title="You have already rented this item"><i class="icon-shopping-cart"></i>&nbsp;Rented</a>
                

                <% } %>
                <br />
                <br />
                <form class="form-inline well">
                    <h3>Rate This Media</h3>
                    <select id="rate_amount" name="rate_amount" class="input-small">
                        <option value="5">5 Stars</option>
                        <option value="4">4 Stars</option>
                        <option value="3">3 Stars</option>
                        <option value="2">2 Stars</option>
                        <option value="1">1 Star</option>
                    </select>
                    <asp:Button ID="btn_rate" class="btn btn-small btn-info tip" OnClick="rate_click" runat="server" data-placement="bottom" rel="tooltip" title="Rate this media" Text="Rate this" />
                </form>

            </div>
            <div class="span8 well" style="background-color: #4dccd9;">
                <h2>  <% if (media.GetType().Name == "Movie")
                       { %>
                    <i class="icon-facetime-video"></i>
                    <% }
                       else
                       { %>
                    <i class="icon-music"></i>
                    <% } %>&nbsp;&nbsp;&nbsp;&nbsp;<%=media.Title %> </h2>
                <h4><%=media.SmallDescription %></h4>
                <% for (int j = 0; j < media.AverageRating; j++)
                   { %>
                <i class="icon-star"></i>
                <%} %>
                <% for (int j = 0; j < 5 - media.AverageRating; j++)
                   { %>
                <i class="icon-star-empty"></i>
                <%} %>
                <br />
                <p>
                    <%=media.Description %>
                </p>
                <h3>Rental Fee: $<%=media.RentalPrice %> for a week</h3>
            </div>

            <% if(isRented){ %>
            <!------PUT THE STREAMING UI HERE-------------->
            <div class="span8 well" style="background-color: #4dccd9;">
                <h3>View Your Media</h3>
                <object width="400" height="280" classid="CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95" id="media_player">                    
                    <param name="AutoStart" value="True">
                    <param name="ShowControls" value="True">
                    <param name="ShowStatusBar" value="False">
                    <param name="ShowDisplay" value="False">
                    <param name="AutoRewind" value="True">
                    <embed type="application/x-mplayer2"
                        pluginspage="http://www.microsoft.com/Windows/Downloads/Contents/MediaPlayer/"
                        width="400" height="280" src="" <!------http://www.2atoms.com/video/haha/fighting_cats4.wmv-------------->
                        autostart="True" showcontrols="True" showstatusbar="False" showdisplay="False" autorewind="True">
                </embed> 
                </object>
                                
            </div>
            <!------END OF STREAMING UI------------------>
            <% }  %>


            <div class="span8 well" style="background-color: #4dccd9;">
                <h3>Comments</h3>
                <div class="media">
                    <!--LOOP INDIVIDUAL COMMENTS HERE--->
                    <% if ((comment_list != null) || (comment_list.Length > 0))
                       {
                           for (int i = 0; i < comment_list.Length; i++)
                           { %>
                    <div class="well">
                        <a class="pull-left" href="#">
                            <img class="media-object" src="<%=comment_list[i].User.FbImageUrl %>">
                        </a>
                        <h4><%=comment_list[i].User.Username %> said,</h4>
                        <div class="media-body">
                            <!--<h4 class="media-heading">Super Crazy awesome movie&nbsp;</h4> <!--TO CHANGE COMMENT TITLE--->
                            <p>"<%=comment_list[i].Content %>"</p>
                            <label class="label-success label">on <%=comment_list[i].DateCreated %></label>
                        </div>
                    </div>
                    <%  }
                       }
                       else
                       { %>

                    <h4>No comments yet :(&nbsp;</h4>
                    <p>Be the first to comment!</p>

                    <% } %>
                    <!-------END OF LOOP----->
                </div>
                <h4>Leave My Comment</h4>
                <div class="form-horizontal">

                    <div class="control-group">
                        <label class="control-label" for="inputComment">Comment</label>
                        <div class="controls">
                            <textarea name="inputMediaComment" id="inputMediaComment" rows="3"></textarea>
                        </div>
                    </div>
                    <div class="control-group">
                        <div class="controls">
                            <asp:Button ID="commentButton" class="btn btn-warning" OnClick="commentButton_Click" runat="server" Text="Leave my comment"></asp:Button>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </div>
</div>


<!--- MODAL FOR POPUP HERE--->

<div id="confirmRent" class="modal hide fade">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
        <h3>Are you sure you want to rent...</h3>
    </div>
    <div class="modal-body">
        <ul class="media-list">

            <li class="media ">
                <a class="pull-left" href="#">
                    <img class="media-object" style="height: 100px;" src="<%=media.Thumbnail %>">
                </a>
                <div class="media-body">
                    <h3 class="media-heading">  <% if (media.GetType().Name == "Movie")
                       { %>
                    <i class="icon-facetime-video"></i>
                    <% }
                       else
                       { %>
                    <i class="icon-music"></i>
                    <% } %>&nbsp;<%=media.Title %></h3>
                    <p><%=media.SmallDescription %></p>

                    <h4>$<%=media.RentalPrice %> for a week</h4>
                </div>
            </li>

        </ul>

    </div>
    <div class="modal-footer">
        <a href="#" data-dismiss="modal"   class="btn">Close</a>
        <asp:Button ID="btn_rent"  class="btn btn-primary" OnClick="rent_click" runat="server" Text="Confirm Rent"/>
    </div>
</div>

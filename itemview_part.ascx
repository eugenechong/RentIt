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
                <a  href="<%=url %>" class="btn btn-danger tip" data-placement="bottom" rel="tooltip" title="Share on Facebook"><i class="icon-share-alt"></i></a>
                <a  href="#confirmRent" role="button"  data-toggle="modal" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Rent this"><i class="icon-shopping-cart"></i>&nbsp;Rent for $<%=media.RentalPrice %></a>
                 <br /><br />
                <form class="form-inline well">
                <h3>Rate This Media</h3><select class="input-small">
                                <option>5 Stars</option>
                                <option>4 Stars</option>
                                <option>3 Stars</option>
                                <option>2 Stars</option>
                                <option>1 Star</option>
                            </select>                
                <asp:Button id="btn_rate" class="btn btn-small btn-info tip" onclick="rate_click" runat="server" data-placement="bottom" rel="tooltip" title="Rate this media" text="Rate this" />
                </form>
                
            </div>
            <div class="span8 well" style="background-color: #4dccd9;">
                <h2><i class="icon-facetime-video"></i>&nbsp;&nbsp;&nbsp;&nbsp;<%=media.Title %> </h2>
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
            <div class="span8 well" style="background-color: #4dccd9;">
                <h3>Comments</h3>
                <div class="media">
                    <!--LOOP INDIVIDUAL COMMENTS HERE--->                    
                    <% if (comment_list.Length > 0 || comment_list != null) {
                        for (int i=0; i<comment_list.Length; i++) { %>
                    <a class="pull-left" href="#">
                        <img class="media-object" src="https://graph.facebook.com/514457901/picture?type=square">
                    </a>
                    <h5>By User</h5> <!--TO CHANGE NAME comment_list[i].User.UserId --->
                    <div class="media-body">
                        <h4 class="media-heading">Super Crazy awesome movie&nbsp;</h4> <!--TO CHANGE COMMENT TITLE--->
                        <p><%=comment_list[i].Content %></p>
                    </div>
                    <%  }
                       } else { %>
                        <div class="media-body">
                            <h4 class="media-heading">No comments yet&nbsp;</h4>                            
                        </div>                                
                    <% } %>
                    <!-------END OF LOOP----->
                </div>
                <h4>Leave My Comment</h4>
                <form class="form-horizontal">
                   
                    <div class="control-group">
                        <label class="control-label" for="inputComment">Comment</label>
                        <div class="controls">
                            <textarea id="inputMediaComment" rows="3"></textarea>
                        </div>
                    </div>
                    <div class="control-group"><div class="controls">
                      <asp:Button id="commentButton" class="btn btn-warning" onclick="commentButton_Click" runat="server" Text="Leave my comment"></asp:Button>
                        </div></div>
                </form>


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
                    <img class="media-object" style="height: 100px;" src="http://metrojolt.com/wp-content/uploads/2011/11/Adrian-Lux-Teenage-Crime-cover-art-300x300.jpg">
                </a>
                <div class="media-body">
                    <h3 class="media-heading"><i class="icon-music"></i>&nbsp;Iron Man 2</h3>
                    <p>Some random text here to spice up your life.</p>
                   
                    <h4>$2 for 2 weeks</h4>
                </div>
            </li>
            
        </ul>

  </div>
  <div class="modal-footer">
    <a href="#" class="btn">Close</a>
    <a href="index.aspx?msg=You have successfully rented Iron Man 2! Enjoy!&msgTitle=Rental Confirmed" class="btn btn-primary">Confirm ($2)</a>
  </div>
</div>
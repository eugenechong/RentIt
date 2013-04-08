<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_media_itemview_part.ascx.cs" Inherits="RentIt.admin_media_itemview_part" %>

<div class="container">
    <div class="container-fluid well">   
        <div class="row-fluid">

            <div class="span12 well" style="background-color: #4dccd9;">
                <h2>Media Control Panel</h2>

                <div>
                    Take charge of media on RenitIt
                </div>
            </div>
        </div>

        <div>
            <div class="span5 well" style="background-color: #4dccd9;">
                <p>
                    <img src="<%=media.Thumbnail %>" width="250px">
                </p>
        
                <% if (media.GetType().Name == "Movie")
                       { %>
                <i class="icon-facetime-video"></i>
                <% }
                       else
                       { %>
                <i class="icon-music"></i>
                <% } %>
                        
                <div class="control-group">
                    <div class="controls">
                        <h4>Title</h4>
                        <input class="input-xlarge" type="text" id="edit-title" name="edit-title" value="<%=media.Title %>">
                    </div>
                </div>

                <div class="control-group">
                    <div class="controls">
                        <h4>Short Description</h4>
                        <input class="input-xlarge" type="text" id="edit-shortdescription" name="edit-shortdescription" value="<%=media.SmallDescription %>">
                    </div>
                </div>
            </div>

            <div class="form-inline well" style="background-color: #4dccd9;">
                <div class="control-group">
                    <div class="controls">
                        <h4>Description</h4>
                        <textarea class="input-xlarge" id="edit-longdescription" name="edit-longdescription" rows="5"><%=media.Description %></textarea>
                    </div>
                </div>

                <div class="control-group">
                    <div class="controls">
                        <h4>Rental Fee</h4>
                        <input class="input-xlarge" type="text" id="edit-rental" name="edit-rental" value="<%=media.RentalPrice %>" />
                    </div>
                </div>

                <div class="controls">
                    <h4>Category</h4>
                    <select class="input-xlarge" id="edit_category_list" name="edit_category_list">
                        <% for (int i=0; i<movie_category_list.Length; i++) { %>
                        <option value="movie-<%= movie_category_list[i].Title %>">Movie - <%= movie_category_list[i].Title %></option>
                        <% } %>
                        <% for (int i=0; i<music_category_list.Length; i++) { %>
                        <option value="music-<%= movie_category_list[i].Title %>">Music - <%= music_category_list[i].Title %></option>
                        <% } %>
                    </select>
                </div>

                <div class="control-group">
                    <h4>Thumbnail URL</h4>
                    <div class="controls">
                       <input class="input-xlarge"  type="text" id="edit-thumbnail-url" name="edit-thumbnail-url" value="<%=media.Thumbnail %>" />
                    </div>
                </div>
            
                <div class="control-group">
                    <h4>Media URL</h4>
                    <div class="controls">
                       <input class="input-xlarge"  type="text" id="edit-media-url" name="edit-media-url" value="<%=media.Source %>" />
                    </div>
                </div>

                <div>
                    <div class="controls">
                        <asp:Button ID="btn_edit" class="btn   btn-warning tip" data-placement="bottom" rel="tooltip" title="Update media information" OnClick="update_click" runat="server" Text="Update"></asp:Button>
                        <a  href="#confirm-delete-pop" data-toggle="modal" class="btn  btn-primary tip" data-placement="bottom" rel="tooltip" title="Delete this media forever">Delete </a>
                    </div>
                </div>  

            </div>

    </div>
</div>


<!--- Confirm delete POP HERE--->
<div id="confirm-delete-pop" class="modal hide fade">
  <div class="modal-header">
    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
    <h3>Are you sure you want to delete?</h3>
  </div>
  <div class="modal-body">
   This will permanently delete <%= media.Title %>. Think twice. 

  </div>
  <div class="modal-footer">
    <a href="#" data-dismiss="modal" aria-hidden="true" class="btn">Close</a>    
    <asp:Button ID="btn_delete" class="btn   btn-warning tip" data-placement="bottom" rel="tooltip" title="Delete media" OnClick="delete_click" runat="server" Text="Delete" />
  </div>
</div>
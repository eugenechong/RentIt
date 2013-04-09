<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_media_part.ascx.cs" Inherits="RentIt.admin_media_part" %>
<div class="container ">
    <h2>Media Control Panel</h2>

    <div>
        Take charge of media on RenitIt
        <div class="pull-right">
            <a href="#media-pop" data-toggle="modal" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Add new media">Add New</a><br />
        </div>
    </div>
    <table class="table table-bordered">

        <thead>
            <tr>
                <th>Mediaid</th>
                <th>Thumbnail</th>
                <th>Type</th>
                <th>Category</th>
                <th>Title</th>                
                <th>Short Description</th>
                <th>Description</th>
                <th>Rental Cost</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <!--Loop media here-->
            <% for (int i=0; i<media_list.Length; i++) { %>
            <tr>
                <td><%= media_list[i].MediaId %></td>
                <td>
                    <img src="<%= media_list[i].Thumbnail %>" width="100px"/>                    
                </td>
                <td>
                    <% 
                       if (media_list[i].GetType().Name == "Movie")
                       { 
                        movie = (RentIt.RentItServices.Movie) media_list[i]; %>
                        <i class="icon-facetime-video"></i>
                </td>
                <td>
                        <%= movie.Category.Title %>
                </td>
                    <% } else { 
                        music = (RentIt.RentItServices.Music) media_list[i]; %>
                        <i class="icon-music"></i>
                </td>
                <td>
                        <%= music.Category.Title %>
                </td>
                    <% } %>                
                <td><%= media_list[i].Title %></td>                
                <td><%= media_list[i].SmallDescription %></td>
                <td><%= media_list[i].Description %></td>
                <td><%= media_list[i].RentalPrice %></td>
                <td>
                    <a href="?item=<%=media_list[i].MediaId %>" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Edit media information">Edit media</a>
                </td>
            </tr>
            <% } %>
            <!-- end of loop---->
        </tbody>
    </table>
</div>

<!--ADD NEW MEDIA MODAL---->
<div id="media-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="H1">Add new Media</h3>
    </div>

    <div class="modal-body">       
        <div class="control-group">
            <div class="controls">
                <input type="radio" id="media_type" name="media_type" value="Music">Music                
                <input type="radio" id="media_type" name="media_type" value="Movie">Movie
            </div>
        </div>
        
        <div class="control-group">
            <div class="controls">
                <input class="input-xlarge" type="text" id="add-title" name="add-title" placeholder="Media Title">
            </div>
        </div>

        <div class="control-group">
            <div class="controls">
                <input class="input-xlarge"  type="text" id="add-shortdescription" name="add-shortdescription" placeholder="Short Description">
            </div>
        </div>

        <div class="control-group">
            <div class="controls">
                <textarea class="input-xlarge"  id="add-longdescription" name="add-longdescription" rows="5" placeholder="Long Description"></textarea>
            </div>
        </div>

        <div class="control-group">
            <div class="controls">
                <select class="input-xlarge" id="add_category_list" name="add_category_list">
                    <% for (int i=0; i<movie_category_list.Length; i++) { %>
                        <option value="movie-<%= movie_category_list[i].Title %>">Movie - <%= movie_category_list[i].Title %></option>
                    <% } %>
                    <% for (int i=0; i<music_category_list.Length; i++) { %>
                        <option value="music-<%= music_category_list[i].Title %>">Music - <%= music_category_list[i].Title %></option>
                    <% } %>
                </select>
            </div>
        </div>

        <div class="control-group">
            <div class="controls">
               <input class="input-xlarge"  type="text" id="add-rental-price" name="add-rental-price" placeholder="Rental Price">
            </div>
        </div>

        <div class="control-group">
            <div class="controls">
               <input class="input-xlarge"  type="text" id="add-thumbnail-url" name="add-thumbnail-url" placeholder="Thumbnail URL">
            </div>
        </div>

        <div class="control-group">
            <div class="controls">
               <input class="input-xlarge"  type="text" id="add-media-url" name="add-media-url" placeholder="Media URL">
            </div>
        </div>
        
        <div class="control-group">
            <div class="controls">
                 <asp:Button ID="btn_add" class="btn-success btn" OnClick="add_click" runat="server" Text="Add Media" />
            </div>
        </div>
        
    </div>

</div>



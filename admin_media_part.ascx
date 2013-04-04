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
                <th>Title</th>
                <th>Category</th>
                <th>Short Description</th>
                <th>Description</th>
                <th>Rental Cost</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <!--Loop media here-->
            <tr>
                <td>1</td>
                <td>
                    <img src="http://moviemusicuk.files.wordpress.com/2010/10/ironman2cover.jpg" width="100px" /></td>
                <td><i class="icon-facetime-video"></i></td>
                <td>Iron Man 2</td>
                <td>Movie - Thriller</td>
                <td>Here's a short description</td>
                <td>here's a really really long description.. Long leh.</td>
                <td>$2</td>

                <td>
                    <a  href="#edit-media-pop" data-toggle="modal"  class="btn btn-block btn-small btn-warning tip" data-placement="bottom" rel="tooltip" title="Update media information">Update</a>
                    <a  href="#confirm-delete-pop" data-toggle="modal" class="btn btn-block btn-small btn-primary tip" data-placement="bottom" rel="tooltip" title="Delete this media forever">Delete </a>
                </td>
            </tr>
            <!-- end of loop---->
        </tbody>
    </table>
</div>


<!--ADD EDIT MEDIA MODAL---->
<div id="edit-media-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="H2">Update Media</h3>
    </div>
    <div class="modal-body">



        <form>

        <div class="control-group">

            <div class="controls">
                <input class="input-xlarge" type="text" id="Text1" placeholder="Media Title">
            </div>
        </div>
        <div class="control-group">

            <div class="controls">
                <input class="input-xlarge"  type="text" id="Text2" placeholder="Short Description">
            </div>
        </div>
        <div class="control-group">

            <div class="controls">
                <textarea class="input-xlarge"  id="Textarea1" rows="5" placeholder="Long Description"></textarea>
            </div>
        </div>
        <div class="control-group">

            <div class="controls">
                <select class="input-xlarge"  id="Select1">
                    <option value="1">Movie - Thriller</option>
                    <option value="2">Movie - Comedy</option>
                    <option value="3">Music - Jazz</option>
                    <option value="4">Music - Classical</option>
                    <option value="5">Music - Pop</option>
                </select>
            </div>
        </div>

        <div class="control-group">
            <div class="controls">
               <input class="input-xlarge"  type="text" id="Text3" placeholder="Thumbnail URL">
            </div>
        </div>

                    <div class="control-group">
            <div class="controls">
               <input class="input-xlarge"  type="text" id="Text4" placeholder="Media URL">
            </div>
        </div>


        <div class="control-group">
            <div class="controls">

                <button type="submit" class="btn-success btn">Update</button>
            </div>
        </div>
        </form>
                       
             
    </div>

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
                <select class="input-xlarge" id="add_category_list" name="add-add_category_list">
                    <% for (int i=0; i<movie_category_list.Length; i++) { %>
                        <option value="movie-<%= movie_category_list[i].Title %>">Movie - <%= movie_category_list[i].Title %></option>
                    <% } %>
                    <% for (int i=0; i<music_category_list.Length; i++) { %>
                        <option value="music-<%= movie_category_list[i].Title %>">Music - <%= music_category_list[i].Title %></option>
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



<!--- Confirm delete POP HERE--->

<div id="confirm-delete-pop" class="modal hide fade">
  <div class="modal-header">
    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
    <h3>Are you sure you want to delete?</h3>
  </div>
  <div class="modal-body">
   This will permanently delete Iron Man 2. Think twice. 

  </div>
  <div class="modal-footer">
    <a href="#" data-dismiss="modal" aria-hidden="true" class="btn">Close</a>
    <a href="admin.aspx?type=media&msg=You have successfully deleted Iron Man 2! Enjoy!&msgTitle=Media Deleted" class="btn btn-warning">Delete</a>
  </div>
</div>
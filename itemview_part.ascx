<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="itemview_part.ascx.cs" Inherits="RentIt.itemview_part" %>

<div class="container">

    <div class="container-fluid well">
        <div class="row-fluid">
            <div class="span4 well" style="background-color: #4dccd9;">
                <p>
                    <img src="http://moviemusicuk.files.wordpress.com/2010/10/ironman2cover.jpg" alt="">
                </p>
                <a href="#" class="btn btn-warning tip" data-placement="bottom" rel="tooltip" title="Add to bookmark"><i class="icon-bookmark"></i></a>
                <a target="_blank" href="http://www.facebook.com/sharer.php?u=http://www.google.com" class="btn btn-danger tip" data-placement="bottom" rel="tooltip" title="Share on Facebook"><i class="icon-share-alt"></i></a>
                <a  href="#confirmRent" role="button"  data-toggle="modal" class="btn btn-success tip" data-placement="bottom" rel="tooltip" title="Add media to rental cart"><i class="icon-shopping-cart"></i>&nbsp;Rent for $2</a>
                 <br /><br />
                <form class="form-inline well">
                <h3>Rate This Media</h3><select class="input-small">
                                <option>5 Stars</option>
                                <option>4 Stars</option>
                                <option>3 Stars</option>
                                <option>2 Stars</option>
                                <option>1 Star</option>
                            </select>
                <input type="submit" class="btn btn-small btn-info tip" data-placement="bottom" rel="tooltip" title="Rate this media" value="Rate this"/>
                    </form>
                
            </div>
            <div class="span8 well" style="background-color: #4dccd9;">
                <h2><i class="icon-facetime-video"></i>&nbsp;&nbsp;&nbsp;&nbsp;Iron Man 2 (ItemID: <%=itemID %>)</h2>
                <h4>Extra information, whatever the information might be. This is so interesting.</h4>
                <i class="icon-star"></i><i class="icon-star"></i><i class="icon-star"></i>
                <br />
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                </p>
                <h3>Rental Fee: $2 for a week</h3>
            </div>
            <div class="span8 well" style="background-color: #4dccd9;">
                <h3>Comments</h3>
                <div class="media">
                    <!--LOOOP INDIVIDUAL COMMENTS HERE--->
                    <a class="pull-left" href="#">
                        <img class="media-object" src="https://graph.facebook.com/514457901/picture?type=square">
                    </a>
                    <div class="media-body">
                        <h4 class="media-heading">Super Crazy awesome movie&nbsp;</h4>
                        <p>Actually, I regretted renting this...</p>
                    </div>
                    <!-------END OF LOOP----->
                </div>
                <h4>Leave My Comment</h4>
                <form class="form-horizontal">
                   
                    <div class="control-group">
                        <label class="control-label" for="inputComment">Comment</label>
                        <div class="controls">
                            <textarea rows="3"></textarea>
                        </div>
                    </div>
                    <div class="control-group"><div class="controls">
                      <button type="submit" class="btn btn-warning">Leave my comment</button>
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
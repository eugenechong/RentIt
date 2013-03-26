﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="RentIt.header" %>

<!------------------ BARS ARE HERE------------>

<% if (!login)
   { %>
<!--navbar without login-->
<div class="container">
    <div class="navbar ">
        <div class="navbar-inner">
            <a class="brand" href="index.aspx"><i class=" icon-film"></i>&nbsp;&nbsp; RentIt</a>

            <ul class="nav pull-right">



                <li class="divider-vertical"></li>
                <li><a href="#signup-pop" data-toggle="modal">Register</a></li>
                <li class="divider-vertical"></li>
                <li><a href="#login-pop" data-toggle="modal"><i class=" icon-group"></i>Login</a></li>
            </ul>
        </div>
    </div>
</div>
<%}
   else
   { %>
<!--navbar with login-->
<div class="container">
    <div class="navbar navbar">
        <div class="navbar-inner">
            <a class="brand" href="index.aspx"><i class=" icon-film"></i>&nbsp;&nbsp; RentIt</a>
            <ul class="nav">
                <li class="dropdown">
                    <a id="drop1" href="#" class="dropdown-toggle" data-toggle="dropdown">Browse <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="drop1">
                        <li><a tabindex="-1" href="index.aspx?type=popular"><i class="icon-thumbs-up"></i>Most Popular</a></li>
                        <li class="divider"></li>
                        <li class="dropdown-submenu">
                            <a tabindex="-1" href="#"><i class="icon-music"></i>Music</a>
                            <ul class="dropdown-menu">
                                <li><a tabindex="-1" href="#">Country</a></li>
                                <li><a tabindex="-1" href="#">Classical</a></li>
                                <li><a tabindex="-1" href="#">Pop</a></li>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a tabindex="-1" href="#"><i class="icon-facetime-video"></i>Movies</a>
                            <ul class="dropdown-menu">
                                <li><a tabindex="-1" href="#">Thriller</a></li>
                                <li><a tabindex="-1" href="#">Comedy</a></li>
                                <li><a tabindex="-1" href="#">Sci-Fi</a></li>
                            </ul>
                        </li>

                    </ul>
                </li>
            </ul>
            <ul class="nav pull-right">
                <form class="navbar-search pull-left" method="get">
                    <input name="param" type="text" class="search-query" placeholder="Search" />
                    <input name="type" type="hidden" value="search" />
                </form>
                <li class="divider-vertical"></li>
                <li class="dropdown"><a href="#" id="drop2" class="dropdown-toggle" data-toggle="dropdown">
                    <img src="<% =dp_url %>" style="border-radius: 2px; max-height: 22px;" alt="">
                    <%=username %> <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="drop2">
                        <li class="disabled"><a tabindex="-1" href="#"  style="color:black;"><i class="icon-money"></i>&nbsp;Balance: $<%=edollar %></a></li>
                         <li class="divider"></li>
                        <li><a tabindex="-1" href="#"><i class="icon-cog"></i>&nbsp;Account Settings</a></li>
                       
                        <li><a tabindex="-1" href="#"><i class="icon-signout"></i>&nbsp;Logout</a></li>
                    </ul>
                </li>
                <li class="divider-vertical"></li>
                <li><a href="#bookmark-pop" data-toggle="modal"><i class="icon-large icon-bookmark"></i></a></li>
                <li class="divider-vertical"></li>
                <li><a href="#cart-pop" data-toggle="modal"><i class="icon-large icon-shopping-cart"></i></a></li>
            </ul>
        </div>
    </div>
</div>


<% } %>



<!--  -------------POP UPS DIALOGS ARE HERE ------------------------>
<!---CART MODAL---->
<div id="cart-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="H3"><i class=" icon-shopping-cart"></i>&nbsp;&nbsp;&nbsp;&nbsp;Rental History</h3>
    </div>
    <div class="modal-body">


     
        <ul class="media-list">
            <!--LOOP CART ITEM HERE-->
            <li class="media ">
                <a class="pull-left" href="#">
                    <img class="media-object" style="height: 100px;" src="http://metrojolt.com/wp-content/uploads/2011/11/Adrian-Lux-Teenage-Crime-cover-art-300x300.jpg">
                </a>
                <div class="media-body">
                    <h4 class="media-heading"><i class="icon-music"></i>&nbsp;Teenage Crime</h4>
                    <p>Some random text here to spice up your life.<br />Rented on XX/XX/XX for $2</p>
                    <a href="index.aspx?type=item&param=1" class="btn btn-success btn-small tip" data-placement="bottom" rel="tooltip" title="More details about this item">More</a>
                    <a target="_blank" href="http://www.facebook.com/sharer.php?u=http://www.google.com" class="btn btn-small btn-danger tip" data-placement="bottom" rel="tooltip" title="Share on Facebook"><i class="icon-share-alt"></i>&nbsp;Share</a>
                    

                </div>
            </li>
            <!--END LOOP-->
        </ul>


    </div>
    <div class="modal-footer">
        <a href="#" data-dismiss="modal" aria-hidden="true" class="btn">Close</a>

    </div>
</div>


<!---BookMARK MODAL---->
<div id="bookmark-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="H2"><i class=" icon-bookmark"></i>&nbsp;&nbsp;&nbsp;&nbsp;Bookmark Manager</h3>
    </div>
    <ul class="modal-body">
        <ul class="media-list">
            <!--LOOP BOOKMARKs HERE-->
            <li class="media ">
                <a class="pull-left" href="#">
                    <img class="media-object" style="height: 100px;" src="http://metrojolt.com/wp-content/uploads/2011/11/Adrian-Lux-Teenage-Crime-cover-art-300x300.jpg">
                </a>
                <div class="media-body">
                    <h4 class="media-heading"><i class="icon-music"></i>&nbsp;Teenage Crime</h4>
                    <p>Some random text here to spice up your life.</p>
                    <a href="index.aspx?type=item&param=1" class="btn btn-success btn-small tip" data-placement="right" rel="tooltip" title="More details about this item">More</a>
                    <a target="_blank" href="http://www.facebook.com/sharer.php?u=http://www.google.com" class="btn btn-small btn-danger tip" data-placement="right" rel="tooltip" title="Share on Facebook"><i class="icon-share-alt"></i>&nbsp;Share</a>

                    <a href="#" class="btn btn-warning btn-small tip" data-placement="right" rel="tooltip" title="Remove this item from bookmark"><i class="icon-remove"></i>&nbsp;Remove</a>

                </div>
            </li>
            <!--END OF BOOKMARK LOOP-->
        </ul>
    </ul>

    <div class="modal-footer">
        <a href="#" data-dismiss="modal" aria-hidden="true" class="btn">Close</a>

    </div>
</div>


<!---LOGIN MODAL---->
<div id="login-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="myModalLabel">RentIt Login</h3>
    </div>
    <div class="modal-body">
        <table cellpadding="4px" width="100%" height="100%">
            <tr>
                <td>
                    <div class="well">

                        <form>
                            <h4>Classic Login</h4>
                            <div class="control-group">

                                <div class="controls">
                                    <input type="text" id="inputEmail" placeholder="Email">
                                </div>
                            </div>
                            <div class="control-group">

                                <div class="controls">
                                    <input type="password" id="inputPassword" placeholder="Password">
                                </div>
                            </div>
                            <div class="control-group">
                                <div class="controls">

                                    <button type="submit" class="btn-success btn">Login</button>
                                </div>
                            </div>
                        </form>
                    </div>
                </td>
                <td>
                    <h5>Or</h5>

                </td>
                <td>
                    <div class="well">
                        <h4>Login with Facebook</h4>
                        <a class="btn-primary btn">Login With Facebook</a>
                    </div>
                </td>
            </tr>

        </table>
    </div>

</div>
<!--REGISTRATION MODAL---->
<div id="signup-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="H1">RentIt Signup</h3>
    </div>
    <div class="modal-body">
        <table cellpadding="4px" width="100%" height="100%">
            <tr>
                <td>
                    <div class="well">


                        <h4>Classic Signup</h4>
                        <div class="control-group">

                            <div class="controls">
                                <input type="text" id="email" placeholder="Email">
                            </div>
                        </div>
                        <div class="control-group">

                            <div class="controls">
                                <input type="text" id="username" placeholder="Username">
                            </div>
                        </div>
                        <div class="control-group">

                            <div class="controls">
                                <input type="password" id="Password1" placeholder="Password">
                            </div>
                        </div>
                        <div class="control-group">

                            <div class="controls">
                                <input type="password" id="Password2" placeholder="Password Again">
                            </div>
                        </div>

                        <div class="control-group">

                            <div class="controls">
                                <select id="gender">

                                    <option value="1">Male</option>

                                    <option value="2">Female</option>

                                </select>
                            </div>
                        </div>

                        <div class="control-group">

                            <div class="controls">
                                <select id="country">
                                    <% for (int i = 0; i < countries.Length; i++)
                                       {                                       
                                    %>
                                    <option value="<%=countries[i] %>"><%=countries[i] %></option>
                                    <%} %>
                                </select>
                            </div>
                        </div>
                        <div class="control-group">

                            <div class="controls">
                                <select id="age">
                                    <% for (int i = 18; i < 99; i++)
                                       {                                       
                                    %>
                                    <option value="<%=i %>"><%=i+" years old" %></option>
                                    <%} %>
                                </select>
                            </div>
                        </div>
                        <div class="control-group">
                            <div class="controls">
                               <button type="submit" class="btn-success btn" onclick="register_click" runat="server">Register</button>
                            </div>
                        </div>
                    </form>
                        
                </td>
                <td>
                    <h5>Or</h5>

                </td>
                <td>
                    <div class="well">
                        <h4>Signup with Facebook</h4>
                        <a class="btn-primary btn">Signup With Facebook</a>
                    </div>
                </td>
            </tr>

        </table>
    </div>

</div>



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="RentIt.header" %>

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
    <div class="navbar ">
        <div class="navbar-inner">
            <a class="brand" href="index.aspx"><i class=" icon-film"></i>&nbsp;&nbsp; RentIt</a>
            <ul class="nav">
                <li class="dropdown">
                    <a id="drop1" href="#" class="dropdown-toggle" data-toggle="dropdown">Browse <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="drop1">
                        <li><a tabindex="-1" href="index.aspx?type=popular"><i class="icon-thumbs-up"></i>Most Popular</a></li>
                        <li class="divider"></li>
                        <li class="dropdown-submenu">
                            <a tabindex="-1" href="#"><i class="icon-music"></i>&nbsp;Music</a>
                            <ul class="dropdown-menu">
                                <% for (int i = 0; i < music_category_list.Length; i++)
                                   { %>
                                <li><a tabindex="-1" href="?type=music&param=<%=music_category_list[i].CategoryId %>"><%=music_category_list[i].Title %></a></li>
                                <% } %>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a tabindex="-1" href="#"><i class="icon-facetime-video"></i>&nbsp;Movies</a>
                            <ul class="dropdown-menu">
                                <% for (int i = 0; i < movie_category_list.Length; i++)
                                   { %>
                                <li><a tabindex="-1" href="?type=movie&param=<%=movie_category_list[i].CategoryId %>"><%=movie_category_list[i].Title %></a></li>
                                <% } %>
                            </ul>
                        </li>

                    </ul>
                </li>
            </ul>
            <ul class="nav">
                <div style="padding-top: 11px;">
                              <input name="type" type="hidden" value="search" />

                    <input name="param" type="text" class=" span2  search-query" placeholder="Search" />
                    <asp:Button ID="searchButton" type="submit" class="btn" Style="position: absolute; height: 0px; width: 0px; border: none; padding: 0px;"
                        hidefocus="true" TabIndex="-1" OnClick="search_click" runat="server" />
                </div>
            </ul>
            <ul class="nav pull-right">
                <li class="divider-vertical"></li>
                <li class="dropdown"><a href="#" id="drop2" class="dropdown-toggle" data-toggle="dropdown">
                    <img src="<% =dp_url %>" style="border-radius: 2px; max-height: 22px;" alt="">
                    <%=username %> <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="drop2">
                        <li class="disabled"><a tabindex="-1" href="#" style="color: black;"><i class="icon-money"></i>&nbsp;Balance: $<%=edollar %></a></li>
                        <li class="divider"></li>
                        
                        <li>
                            <asp:LinkButton ID="logoutButton" runat="server" OnClick="logoutButton_Click"><i class="icon-signout"></i>&nbsp;Logout</asp:LinkButton></li>
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


<%if (login)
  { %>
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
            <%
            string cart_share_url = "";
                for (int i = 0; i < rental_list.Length; i++)
                
                //for (int i = 0; i < 0; i++)
               { %>
            <li class="media ">
                <a class="pull-left" href="#">
                    <img class="media-object" style="height: 100px;" src="<%=rental_list[i].Media.Thumbnail %>">
                </a>
                <div class="media-body">
                    <h4 class="media-heading"><% if (rental_list[i].GetType().Name == "Movie")
                       { %>
                    <i class="icon-facetime-video"></i>
                    <% }
                       else
                       { %>
                    <i class="icon-music"></i>
                    <% } %>&nbsp;<%=rental_list[i].Media.Title %></h4>
                    <p>
                        <%=rental_list[i].Media.SmallDescription %><br />
                        <span class="label">Rented on <%=rental_list[i].StartDate %> for $<%=rental_list[i].Price %></span>
                    </p>
                     <%
                    //generate the fb share link

                   cart_share_url = "https://www.facebook.com/dialog/feed?app_id=103996706365313&link=http://green.smu.edu.sg/gspm2013/team09/index.aspx?item=" + rental_list[i].Media.MediaId + "&" +
                              "picture=" + rental_list[i].Media.Thumbnail + "&" +
                              "name=" + rental_list[i].Media.Title + "&" +
                              "caption=RentIt Team 9&" +
                              "description=" + rental_list[i].Media.SmallDescription + "&" +
                              "redirect_uri=http://green.smu.edu.sg/gspm2013/team09/close.aspx";
                          
                    
                     %>

                    <a href="index.aspx?item=<%=rental_list[i].Media.MediaId %>" class="btn btn-success btn-small tip" data-placement="bottom" rel="tooltip" title="View or find out more about this media item">View</a>
                    <a target="_blank" href="<%=cart_share_url %>" class="btn btn-small btn-danger tip" data-placement="bottom" rel="tooltip" title="Share on Facebook"><i class="icon-share-alt"></i>&nbsp;Share</a>
                </div>
            </li>
            <% }  %>
            <!--END LOOP-->
        </ul>
    </div>
    <div class="modal-footer">
        <a href="#" data-dismiss="modal" aria-hidden="true" class="btn">Close</a>

    </div>
</div>


<!---BOOKMARK MODAL---->
<div id="bookmark-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="H2"><i class=" icon-bookmark"></i>&nbsp;&nbsp;&nbsp;&nbsp;Bookmark Manager</h3>
    </div>
    <ul class="modal-body">
        <ul class="media-list">
            <!--LOOP BOOKMARKs HERE-->
            <% if (login){ 
                   for (int i=0;i<bookmark_list.Length;i++){
                   %>
            <li class="media ">
                <a class="pull-left" href="#">
                    <img class="media-object" style="height: 100px;" src="<%=bookmark_list[i].Thumbnail %>">
                </a>
                <div class="media-body">
                    <h4 class="media-heading">  <% if (bookmark_list[i].GetType().Name == "Movie")
                       { %>
                    <i class="icon-facetime-video"></i>
                    <% }
                       else
                       { %>
                    <i class="icon-music"></i>
                    <% } %>&nbsp;<%=bookmark_list[i].Title %></h4>
                    <p><%=bookmark_list[i].SmallDescription %></p>
                    <a href="index.aspx?item=<%=bookmark_list[i].MediaId %>" class="btn btn-success btn-small tip" data-placement="right" rel="tooltip" title="View this item">View</a>
                   

                    <a href="support_actions.aspx?deleteBookmark=<%=bookmark_list[i].MediaId %>" class="btn btn-warning btn-small tip" data-placement="right" rel="tooltip" title="Remove this item from bookmark"><i class="icon-remove"></i>&nbsp;Remove</a>

                </div>
            </li>
            <% } }
                %>
            <!--END OF BOOKMARK LOOP-->
        </ul>
    </ul>

    <div class="modal-footer">
        <a href="#" data-dismiss="modal" aria-hidden="true" class="btn">Close</a>

    </div>
</div>

<% } %>
<!---LOGIN MODAL---->
<div id="login-pop" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
        <h3 id="myModalLabel">RentIt Login</h3>
    </div>
    <div class="modal-body">
        <table style="background: white; width: 100%;">
            <tr>
                <td>
                    <h3>Login</h3>

                    <div class="control-group ">

                        <div class="controls">
                            <input type="text" id="inputEmail" name="inputEmail" placeholder="Email" value="i@weikiat.net"/>
                        </div>
                    </div>
                    <div class="control-group">

                        <div class="controls">
                            <input type="password" id="inputPassword" name="inputPassword" placeholder="Password"  value="weikiat"/>
                        </div>
                    </div>
                    <div class="control-group">
                        <div class="controls">

                            <asp:Button ID="btn_login" class="btn-success btn"
                                OnClick="login_click" runat="server" Text="Login" />
                        </div>
                    </div>

                </td>
                <td valign="top" width="300px">


                    <div class="well" style="background-color: #e1e1e1">
                        <h4>Don't have email or password?</h4>
                        <p>Register for a new account! You get 100 credits free!</p>
                        <br />
                        <a href="#signup-pop" data-dismiss="modal" data-toggle="modal" class="btn btn-primary">Register</a>

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
        <h3 id="H1">Signup</h3>
    </div>
    <div class="modal-body">

        <table style="background: white; width: 100%;">
            <tr>
                <td>
                    <h3>Classic Signup</h3>

                    <div class="control-group">

                        <div class="controls">
                            <input type="text" id="email" name="signup_email" placeholder="Email">
                        </div>
                    </div>
                    <div class="control-group">

                        <div class="controls">
                            <input type="text" id="username" name="signup_username" placeholder="Username">
                        </div>
                    </div>
                    <div class="control-group">

                        <div class="controls">
                            <input type="password" id="Password1" name="signup_password1" placeholder="Password">
                        </div>
                    </div>
                    <div class="control-group">

                        <div class="controls">
                            <input type="password" id="Password2" name="signup_password2" placeholder="Password Again">
                        </div>
                    </div>

                    <div class="control-group">

                        <div class="controls">
                            <select id="gender" name="signup_gender">

                                <option value="Male">Male</option>

                                <option value="Female">Female</option>

                            </select>
                        </div>
                    </div>

                    <div class="control-group">

                        <div class="controls">
                            <select id="country" name="signup_country">
                                <% for (int i = 0; i < country_list.Length; i++)
                                   {                                       
                                %>
                                <option value="<%=i %>"><%=country_list[i].Name %></option>
                                <%} %>
                            </select>
                        </div>
                    </div>
                    <div class="control-group">

                        <div class="controls">
                            <select id="age" name="signup_age">
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
                            <asp:Button ID="btn_register" class="btn-success btn" OnClick="register_click" runat="server" Text="Register" />
                        </div>
                    </div>

                </td>
                <td valign="top" width="280px">


                    <div class="well" style="background-color: #e1e1e1">
                        <h4>Already have email or password?</h4>
                        <p>Access your rental and bookmarks by logging in!</p>
                        <br />
                        <a href="#login-pop" data-dismiss="modal" data-toggle="modal" class="btn btn-primary">Login</a>

                    </div>
                </td>
            </tr>
        </table>

    </div>

</div>









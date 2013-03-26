<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_header.ascx.cs" Inherits="RentIt.admin_header" %>

<!------------------ BARS ARE HERE------------>

<% if (!login)
   { %>
<!--navbar without login-->
<div class="container">
    <div class="navbar ">
        <div class="navbar-inner">
            <a class="brand" href="admin.aspx"><i class=" icon-film"></i>&nbsp;&nbsp; RentIt Adminstration Panel</a>

            <ul class="nav pull-right">
                <li>
                <form class="form-inline ">
                    <input type="text" class="input-small" placeholder="Email" style="margin-top:10px;">
                    <input type="password" class="input-small" placeholder="Password" style="margin-top:10px;">
                    <button type="submit" class="btn btn-primary">Sign in</button>
                    
                </form>

                    </li>
                <li class="divider-vertical"></li>

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
            <a class="brand" href="admin.aspx"><i class=" icon-film"></i>&nbsp;&nbsp; RentIt Administration Panel</a>
           
               
            <ul class="nav pull-right">
                <li ><a href="admin.aspx">Home</a></li>
                <li ><a href="admin.aspx?type=media">Media</a></li>
                <li ><a href="admin.aspx?type=user">Users</a></li>
                <li ><a href="#">Analyatics</a></li>
                <li class="divider-vertical"></li>
                <li class="dropdown"><a href="#" id="drop2" class="dropdown-toggle" data-toggle="dropdown">

                    <%=username %> <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="drop2">


                        <li><a tabindex="-1" href="#"><i class="icon-signout"></i>&nbsp;Logout</a></li>
                    </ul>
                </li>

            </ul>
        </div>
    </div>
</div>


<% } %>

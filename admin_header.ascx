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
                    <input type="text" class="input-small" id="inputEmail" name="inputEmail" placeholder="Email" style="margin-top:10px;" />
                    <input type="password" class="input-small" id="inputPassword" name="inputPassword" placeholder="Password" style="margin-top:10px;" />
                     <asp:Button ID="btn_login" class="btn-success btn"
                                OnClick="login_click" runat="server" Text="Login"  style="margin-top:0px;"/>
                    
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
             <ul class="nav">
                <li class="dropdown">
                    <a id="A1" href="#" class="dropdown-toggle" data-toggle="dropdown">Analytics <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="drop1">
                        <li ><a href="admin.aspx?type=user_analytics">User Analytics</a></li>        
                        <li ><a href="admin.aspx?type=media_analytics">Media Analytics</a></li>                                            
                    </ul>
                </li>
            </ul>
                                        
                <li class="divider-vertical"></li>
                <li class="dropdown"><a href="#" id="drop2" class="dropdown-toggle" data-toggle="dropdown">

                    <%=username %> <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="drop2">


                        <li><asp:LinkButton ID="logoutButton" runat="server" OnClick="logoutButton_Click"><i class="icon-signout"></i>&nbsp;Logout</asp:LinkButton></li></li>
                    </ul>
                </li>

            </ul>
        </div>
    </div>
</div>


<% } %>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_user_part.ascx.cs" Inherits="RentIt.admin_user_part" %>
<div class="container ">
    <h2>User Control Panel</h2>
    <p>Review, suspend, and do what you like with the users of RentIt</p>
    <table class="table table-bordered">

        <thead>
            <tr>
                <th>Userid</th>
                <th>Username</th>
                <th>Email</th>
                <th>Gender</th>
                <th>Age</th>
                <th>Country</th>                
                <th>Actions</th>
                
            </tr>
        </thead>
        <tbody>
            <!--Loop user here-->
            <% for (int i=0; i<user_list.Length; i++) { %>
            <tr>
                <td><%=user_list[i].UserId %></td>
                <td><%=user_list[i].Username %></td>
                <td><%=user_list[i].Email %></td>
                <td><%=user_list[i].Gender %></td>
                <td><%=user_list[i].Age %></td>
                <td><%=user_list[i].Country.Name %></td>                
                <td>
                    <% if (user_list[i].IsSuspended == false){ %>
                    <a href="support_actions.aspx?suspend=<%=user_list[i].Email %>" class="btn btn-small btn-warning tip" data-placement="bottom" rel="tooltip" title="Suspend this user. User won't be able to login.">Suspend</a>
                    <% }else{ %>
                     <a href="support_actions.aspx?unsuspend=<%=user_list[i].Email %>" class="btn btn-small btn-success tip" data-placement="bottom" rel="tooltip" title="Unsuspend this user. User will be able to login.">Unsuspend</a>
                    <%} %>                   
                
                    <% if (user_list[i].IsAdmin == false){ %>
                    <a href="support_actions.aspx?make_admin=<%=user_list[i].Email %>" class="btn btn-small btn-success tip" data-placement="bottom" rel="tooltip" title="Make user as Admin.">Make Admin</a>
                    <% }else{ %>
                    <a href="support_actions.aspx?revoke_admin=<%=user_list[i].Email %>" class="btn btn-small btn-warning tip" data-placement="bottom" rel="tooltip" title="Make user as Admin.">Revoke Admin</a>
                    <%} %>
                </td>
            </tr>
            <% } %>
            <!-- end of loop---->
        </tbody>
    </table>
</div>


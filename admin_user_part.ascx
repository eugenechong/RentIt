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
                    <% if (user_list[i].IsSuspended==false ){ %>
                    <a href="support_actions.aspx?suspend=<%=user_list[i].Email %>" class="btn btn-small btn-warning tip" data-placement="bottom" rel="tooltip" title="Suspend this user. User won't be able to login.">Suspend</a>
                    <% }else{ %>
                     <a href="support_actions.aspx?unsuspend=<%=user_list[i].Email %>" class="btn btn-small btn-success tip" data-placement="bottom" rel="tooltip" title="Unsuspend this user. User will be able to login.">Unsuspend</a>
                    <%} %>
                </td>
            </tr>
            <% } %>
            <!-- end of loop---->
        </tbody>
    </table>
</div>


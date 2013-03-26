<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="msgbar_part.ascx.cs" Inherits="RentIt.msgbar_part" %>
 <div class="container">
        <!--FOR SHOWING ALERT MESSAGES IF ANY, SUCH AS COMMENT POSTED, ITEM ADDED TO CART, ETC-->
        <div class="alert alert-info">
            <button type="button" class="close" data-dismiss="alert">&times;</button>
            <% if (msgTitle != null) { %>
            <h4><%=msgTitle %></h4>
            <% } %>
            <%=msg %>
        </div>
    </div>
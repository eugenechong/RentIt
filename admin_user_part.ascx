﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_user_part.ascx.cs" Inherits="RentIt.admin_user_part" %>
<div class="container ">
    <h2>User Control Panel</h2>
    <p>Review, ban, and do what you like with the users of RentIt</p>
    <table class="table table-bordered">

        <thead>
            <tr>
                <th>Userid</th>
                <th>Username</th>
                <th>Email</th>
                <th>Gender</th>
                <th>Age</th>
                <th>Country</th>
                <th>Facebook</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <!--Loop user here-->
            <tr>
                <td>1</td>
                <td>Wei Kiat</td>
                <td>i@weikiat.net</td>
                <td>Male</td>
                <td>20</td>
                <td>Singapore</td>
                <td><i class="icon-facebook-sign"></i></td>
                <td>
                    <a href="#" class="btn btn-small btn-warning tip" data-placement="bottom" rel="tooltip" title="Suspend this user. User won't be able to login.">Suspend</a>
                </td>
            </tr>
            <!-- end of loop---->
        </tbody>
    </table>
</div>

<!--- Confirm delete POP HERE--->

<div id="confirm-suspend-pop" class="modal hide fade">
  <div class="modal-header">
    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
    <h3>Are you sure you want to suspend?</h3>
  </div>
  <div class="modal-body">
   This will permanently suspend Weikiat. Think twice. 

  </div>
  <div class="modal-footer">
    <a href="#" data-dismiss="modal" aria-hidden="true" class="btn">Close</a>
    <a href="admin.aspx?type=media&msg=You have successfully deleted Iron Man 2! Enjoy!&msgTitle=Media Deleted" class="btn btn-warning">Delete</a>
  </div>
</div>
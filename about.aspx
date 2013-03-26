<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="RentIt.about" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="http://code.jquery.com/jquery-latest.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <div class="navbar navbar-inverse">
            <div class="navbar-inner">
                <a class="brand" href="/gspm2013/<%= RentIt.Utility.GetTeamPath(Server.MapPath("~/")) %>">RentIt</a>
                <ul class="nav">
                    <li><a href="/gspm2013/<%= RentIt.Utility.GetTeamPath(Server.MapPath("~/")) %>">Home</a></li>
                    <li><a href="rent.aspx">Rent</a></li>
                    <li class="active"><a href="#">About Us</a></li>
                </ul>
            </div>
        </div>
        <div class="hero-unit">
            <h1>RentIt</h1>
            <p>A collaboration between SMU and ITU</p>
            <p>
                <a class="btn btn-primary btn-large" href="http://wiki.smu.edu.sg/is411/">Learn more
                </a>
            </p>
        </div>
    </div>
</body>
</html>

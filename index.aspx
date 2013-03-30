<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RentIt.index" %>

<!--headers and footers-->

<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="foot" %>



<!DOCTYPE html>

<!--include the js and css stuff-->
<% Response.WriteFile("includes.aspx"); %>

<body>
<form id="form" runat="server">
    <!--HEADER-->
    <asp:PlaceHolder runat="server" ID="headerBar" />
    <!--END HEADER-->

    <!--MSG BAR-->
    <asp:PlaceHolder runat="server" ID="msgBar" />
    <!--END MSG BAR-->

    <!--BODY-->
    <asp:PlaceHolder runat="server" ID="mainBody" />
    <!--END BODY-->

    <foot:footer ID="footer1" runat="server" />
</form>
<script type="text/javascript">
    $('.tip').tooltip(

        );
</script>

</body>

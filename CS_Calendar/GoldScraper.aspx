<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoldScraper.aspx.cs" Inherits="CS_Calendar.GoldScraper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class ="form">
        <form class="loginform"  runat="server">
            <input type="text" id="inputUsername" runat="server" placeholder="Username"/>
            <input type="password" id="inputPassword" runat="server" placeholder="Password"/>
            <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click1" />
            <p id="registertext">Not Registered? <a href="javascript:void(0)">Sign Up</a></p>
        </form>
    </div>
</body>
</html>

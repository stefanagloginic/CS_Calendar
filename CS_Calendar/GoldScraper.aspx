<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoldScraper.aspx.cs" Inherits="CS_Calendar.GoldScraper" %>

<style>
   
  /* Visual studio does not like gradients inside of stylesheets, will have to add in html file */
body{
  background: -moz-linear-gradient(270deg, rgba(26,82,118,1) 0%, rgba(0,128,128,1) 100%); /* ff3.6+ */
  background: -webkit-gradient(linear, left top, left bottom, color-stop(0%, rgba(26,82,118,1)), color-stop(100%, rgba(0,128,128,1))); /* safari4+,chrome */
  background: -webkit-linear-gradient(270deg, rgba(26,82,118,1) 0%, rgba(0,128,128,1) 100%); /* safari5.1+,chrome10+ */
  background: -o-linear-gradient(270deg, rgba(26,82,118,1) 0%, rgba(0,128,128,1) 100%); /* opera 11.10+ */
  /* background: -ms-linear-gradient(270deg, rgba(26,82,118,1) 0%, rgba(0,128,128,1) 100%);*/ /* ie10+ */
  background: linear-gradient(180deg, rgba(26,82,118,1) 0%, rgba(0,128,128,1) 100%); /* w3c */
  filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#1A5276', endColorstr='#008080',GradientType=0 );
  width:100%;
  margin: auto;
 }

</style>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/main.css"/>
    <link rel="stylesheet" type="text/css" href="CSS/normalize.css"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta charset="utf-8"/>
    <title>CS Calander</title>
</head>
<body>
  <div class="header">
      <div class="container">
          <div class="logo">
              <h1> <a href=#>Computer Science Calender</a></h1>  
          </div>
      </div>
  </div>
      <div class ="form">
          <form class="loginform"  runat="server">
             <input type="text" id="inputUsername" runat="server" placeholder="Username"/>
             <input type="password" id="inputPassword" runat="server" placeholder="Password"/>
             <asp:Button CssClass="Button" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1"></asp:Button>
             <p id="registertext">Not Registered? <a href="javascript:void(0)">Sign Up</a></p>
          </form>
      </div>
    </body>
</html>
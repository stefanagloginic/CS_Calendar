<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoldScraper.aspx.cs" Inherits="CS_Calendar.GoldScraper" %>

<!--<style>
   
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

</style>-->


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/main.css"/>
    <link rel="stylesheet" type="text/css" href="CSS/normalize.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.0.0/jquery.min.js"></script>
    <script src="JavaScript/main.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta charset="utf-8"/>
    <title>CS Calandar</title>
</head>
  <body>
    <!-- represents the screen which pops up-->
    <div id="loader-wrapper">
    <div id="loader"></div>
 
    <div class="loader-section section-left"></div>
    <div class="loader-section section-right"></div>
 
    </div>

    <div class ="mainlayout">
    <div class="wrapper">
      <div class="header">
        <div class="container">
            <div class="logo">
                <img src="Resources/CSLogo.png" id="ucsbLogo" />
            </div>
        </div>
    </div>
        <div class ="form">
            <div id="registerWrap" class ="formWrappers">
            <form class="registerform" onsubmit="return validateFieldsRegister();">
                <input type="text" id="registerUsername" placeholder="Username" />
                <input type="text" id="registerEmail" placeholder="Email" />
                <input type="password" id="registerPassword" placeholder="Password" />
                <input type="password" id="registerRetype" placeholder="Retype Password" />
                <button class="Button" id="RegisterButton" type="button">Sign Up</button> 
                 <p class="message" id="logintext">Already Registered? <a href="javascript:;" onclick="animateFormReg()"> Log In</a></p>
            </form>
                </div>
            <div id="loginWrap" class ="formWrappers">
            <form class="loginform"  runat="server" onsubmit="return validateFieldsLogin();">
                <input type="text" id="inputUsername" runat="server" placeholder="Username"/>
                <input type="password" id="inputPassword" runat="server" placeholder="Password"/>
                <asp:Button CssClass="Button" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
                 <p class="message" id="registertext">Not Registered?<a href="javascript:;" onclick="animateForm()"> Sign Up</a></p>
             </form>
             </div>
        </div>
      <div class="push"></div>
      
    </div>
    <div class="footer">
       <span> &copy;Stefana Gloginic and Angel Rivera: All Rights Reserved </span>
    </div>
        </div>
  </body>
</html>
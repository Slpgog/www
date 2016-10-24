<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regist.aspx.cs" Inherits="WebApplication1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Регистрация</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="CSS/Style.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="CSS/Auth.css" />
    <script type="text/javascript" src="Scripts/placeholder.js"></script>




</head>
<body>
    <form id="form1" runat="server">    
        <div id="slick-login">
            <h1>Регистрация</h1>               
            <asp:TextBox ID="TextBox1" runat="server" CssClass="placeholder" placeholder="Имя пользователя"></asp:TextBox> 
            <asp:TextBox ID="TextBox2" runat="server" CssClass="placeholder" placeholder="Пароль" TextMode="Password"></asp:TextBox>  
            <asp:TextBox ID="TextBox3" runat="server" CssClass="placeholder" placeholder="Повторите пароль" TextMode="Password"></asp:TextBox>   
            <asp:TextBox ID="TextBox4" runat="server" CssClass="placeholder" placeholder="Email"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Зарегистрироваться" OnClick="Button1_Click" />
            <a href="login.aspx"><font size="2px">Авторизация</font></a>     
            
        </div>
	</form>

</body>
</html>
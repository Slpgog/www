<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Войти</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="CSS/Style.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="CSS/Auth.css" />
    <script type="text/javascript" src="Scripts/placeholder.js"></script>




</head>
<body>
    <form id="form1" runat="server">
        <div id="slick-login">
            <h1>Авторизация</h1>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="placeholder" placeholder="Имя пользователя"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="placeholder" placeholder="Пароль" TextMode="Password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Войти" OnClick="Button1_Click1" />
            <a href="regist.aspx"><font size="2px">Регистрация</font></a>
            <a href="#"><font size="2px">Восстановить пароль</font></a>

        </div>
    </form>

</body>
</html>

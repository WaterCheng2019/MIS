<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MIS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登陆</title>
    <script src="JavaScript/Login.js"></script>
    <style type="text/css">
        #login {
               margin:100px auto;
               text-align:center;
        }
        table{
            margin:0 auto;
        }

    </style>
</head>
<body>
    <div id="login">
    <div id="img">
        <img src="Images/login.jpg" />
    </div>
    <div id="content">
        <table>
            <tr>
                <td>用户名：</td>
                <td>
                    <input type="text" name="Name" id="Name" />
                </td>
                <td>密码：</td>
                <td>
                    <input type="text" name="Pwd" id="Pwd" />
                </td>
                <td>
                    <a href="#" id="btnLogin">登陆</a>
                </td>
            </tr>
        </table>
    </div>
    </div>
</body>
</html>

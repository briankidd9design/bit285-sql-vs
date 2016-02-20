<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <span style = "color:blue;">Login Page:</span></p>
    <p>
        &nbsp;</p>
        User Name:&nbsp;&nbsp;
        <asp:TextBox ID="userName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqFldUserName" runat="server" ErrorMessage="User Name is Required!" ControlToValidate="userName" ForeColor="Red"></asp:RequiredFieldValidator>
        <p>
&nbsp; Password&nbsp; :<asp:TextBox ID="password" runat="server" style="margin-left: 9px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqFldPassword" runat="server" ErrorMessage="A Password is Required!" ControlToValidate="password" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click"/>
        </p>
        
        <asp:Label ID="lblPasswordStatus" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>

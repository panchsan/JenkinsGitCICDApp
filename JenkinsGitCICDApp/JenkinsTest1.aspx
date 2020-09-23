<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JenkinsTest1.aspx.cs" Inherits="JenkinsGitCICDApp.JenkinsTest1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JenkinsTest1</title>
    <style type="text/css">
        #btnadd {
            width: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to Jenkins Test</h1>
            <h2>Welcome to JenkinsTest1.aspx Page</h2>
            <h3>Jenkins Test Completed</h3>

            <h4>Jenkins New Test 09/21/2020</h4>

            First Testbox: <asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
            Scoend Textbox: <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:Button ID="btnadd" Text="Add"  runat="server" OnClick="btnadd_Click"/>
            <br />
            <br />
            <br />
            <br />
            Result:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>

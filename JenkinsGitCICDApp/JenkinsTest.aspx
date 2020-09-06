<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JenkinsTest.aspx.cs" Inherits="JenkinsGitCICDApp.JenkinsTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JenkinsTest</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Jenkins Test</h2>

            <asp:Button ID="btnClickMe" runat="server" Text="Click Me" OnClick="btnClickMe_Click"/>
        </div>
    </form>
</body>
</html>

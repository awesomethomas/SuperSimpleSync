<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Server._Default" %>
<html>
    <body>
        <form id="form1" runat="server">
        Super Simple Sync Server
        <h1>New Comment</h1>
        <asp:DropDownList ID="AccountList" runat="server">
        </asp:DropDownList>
        <asp:Button ID="ChangeAccountButton" runat="server" onclick="Button1_Click" 
            Text="Change Account" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        </form>
    </body>
</html>
<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Server._Default" %>
<html>
    <body>
        <form id="form1" runat="server">
        &nbsp;<h1>Super Simple Sync Server
        </h1>
        <asp:DropDownList ID="AccountList" runat="server" 
            onselectedindexchanged="ChangeAct">
        </asp:DropDownList>
        <asp:Button ID="ChangeAccountButton" runat="server" onclick="Button1_Click" 
            Text="View Account" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </form>
    </body>
</html>
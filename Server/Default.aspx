<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Server._Default" %>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
<html>
    <body>
        <form id="form1" runat="server">
        <h2>SuperSimpleSyncServer</h2>
        <h1>Directory Listing</h1>
        <p>Here is a list of directory that was Sync'd</p>
        <asp:DropDownList ID="AccountList" runat="server" 
            onselectedindexchanged="ChangeAct">
        </asp:DropDownList>
        <asp:Button ID="ChangeAccountButton" runat="server" onclick="Button1_Click" 
            Text="View Account" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" CssClass="mGrid">
        </asp:GridView>
        </form>
    </body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesReviewAddPage.aspx.cs" Inherits="GamesReviewMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title> 
    <link href ="GamesReviewAddPage.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="MainForm" runat="server">
        <div class="MainDiv">
            
            <asp:DropDownList ID="GameScoreDDL" runat="server">
               
            </asp:DropDownList>
            <asp:DropDownList ID="GameGenreDDL" runat="server"></asp:DropDownList>
            &nbsp;<asp:TextBox ID="GameNameTXT" runat="server"></asp:TextBox>
            <textarea id="GameReviewTA" cols="20" rows="1" ></textarea>
            <asp:Label ID="GameNameLBL" runat="server" Text="Game Name:"></asp:Label>
            <asp:Label ID="GameGenreLBL" runat="server" Text="Genre:"></asp:Label>
            <asp:Label ID="GameScoreLBL" runat="server" Text="Score:"></asp:Label>
            <asp:Label ID="GameReviewLBL" runat="server" Text="Submit Review:"></asp:Label>
            <asp:Label ID="GameReviewAddPageLBL" runat="server" Text="Welcome to the Games Review Add Page"></asp:Label>
        </div>
    </form>
</body>
</html>
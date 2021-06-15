<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PokemonForm.aspx.cs" Inherits="WebApplication1.View.PokemonForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Pokemon List</h1>
            <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="SEARCH" OnClick="btnSearch_Click"></asp:Button>
            <asp:GridView ID="gvPokemons" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="gvPokemons_SelectIndexChanged"></asp:GridView>
            <h1>Pokemon DETAILS</h1>
            <table>
                <tr>
                    <td>ID</td>
                    <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Height</td>
                    <td><asp:TextBox ID="txtHeight" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Weight</td>
                    <td><asp:TextBox ID="txtWeight" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Type</td>
                    <td><asp:TextBox ID="txtType" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" Text="ADD NEW"/>
            <asp:Button ID="btnUpdate" OnClick="btnUpdate_Click" runat="server" Text="UPDATE"/>
            <asp:Button ID="btnDelete" OnClick="btnDelete_Click" runat="server" Text="DELETE" OnClientClick="return confirm('Are you suer');"/>
        </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/RoqueMasterPage.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Roque.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h2>Buscar Producto</h2>
        <asp:Label ID="Label1" runat="server" Text="Categoría"></asp:Label>
        <asp:DropDownList ID="cmbCategorias" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbCategorias_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Precio desde: "></asp:Label>
        <asp:TextBox ID="txtRangoInicial" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Hasta: "></asp:Label>
        <asp:TextBox ID="txtRangoFinal" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" CssClass="botones" OnClick="btnFiltrar_Click" />
        
        <asp:GridView ID="grdProductos" runat="server"></asp:GridView>
        

    </section>
</asp:Content>

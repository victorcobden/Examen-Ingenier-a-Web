<%@ Page Title="" Language="C#" MasterPageFile="~/RoqueMasterPage.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Roque.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section >
        <h2>Registrar Cliente</h2>
        <div id="Clientes">
            <div class="columnas-3">
                <asp:Label ID="Label1" runat="server" Text="CustomerID"></asp:Label>
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="CompanyName"></asp:Label>
                <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="ContactName"></asp:Label>
                <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="ContactTitle"></asp:Label> 
                <asp:DropDownList ID="cmbTitulos" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
            <div class="columnas-3">
                <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" Text="City"></asp:Label>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="Region"></asp:Label>
                <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="PostalCode"></asp:Label>
                <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
            </div>
            <div class="columnas-3">
                <asp:Label ID="Label9" runat="server" Text="Country"></asp:Label>
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label10" runat="server" Text="Phone"></asp:Label>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label11" runat="server" Text="Fax"></asp:Label>
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
            </div>

        </div>
        
        <div class="btn-group text-center">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="botones" />
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar los registros" OnClick="btnMostrar_Click" CssClass="botones" /> 
        </div>
        
        
        <hr /> 
        <asp:GridView ID="grdClientes" runat="server">
        </asp:GridView>
        
    </section>
</asp:Content>

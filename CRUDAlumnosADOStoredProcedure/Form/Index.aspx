<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CRUDAlumnosADOStoredProcedure.Form.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="ddl" runat="server"></asp:DropDownList>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
    <asp:Button ID="btnDetalles" runat="server" Text="Detalles" />
    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
    <asp:GridView ID="dgv" runat="server"></asp:GridView>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Seminario1.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="Pagina de Administracion"></asp:Label>
        <div>
            
            <div class="split left">
                <h2>Agregar Categoria</h2>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="CategoriaNombre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Descripcion"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="CategoriaDescripcion" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Crear" OnClick="Button1_Click" />
                        </td>
                        <td>
                            <asp:Label ID="resultado" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            
            <div class=" split right">
                <h2> Agregar Producto</h2>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="ProductoNombre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Descripcion"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="ProductoDescripcion" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Imagen"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="ProductoImagenRute" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Precio"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="ProductoPrecio" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Categoria"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="ProductoCategoria" runat="server" TextMode="Number"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="CrearProducto" runat="server" Text="Crear Producto" OnClick="CrearProducto_Click" />
                        </td>
                        <td>
                            <asp:Label ID="ResultadoProducto" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>

    </div>

</asp:Content>

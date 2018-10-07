<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Seminario1.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Tu carrito</h1></div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="Models.LineaProducto" SelectMethod="GetLineasDelPedido" 
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="ProductoId" HeaderText="ID" SortExpression="ProductID" />        
        <asp:BoundField DataField="Producto.Nombre" HeaderText="Name" />        
        <asp:BoundField DataField="Producto.Precio" HeaderText="Price (each)" DataFormatString="{0:c}"/>     
        <asp:TemplateField   HeaderText="Cantidad">            
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Cantidad %>"></asp:TextBox> 
                </ItemTemplate>        
        </asp:TemplateField>    
        <asp:TemplateField HeaderText="Item Total">            
                <ItemTemplate>
                    <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Cantidad)) *  Convert.ToDouble(Item.Producto.Precio)))%>
                </ItemTemplate>        
        </asp:TemplateField> 
        <asp:TemplateField HeaderText="Remove Item">            
                <ItemTemplate>
                    <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>        
        </asp:TemplateField>    
        </Columns>    
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong> 
    </div>
    <br />

    <table>
        <asp:Label ID="aviso" runat="server" Text=""></asp:Label>
    <tr>
      <td>
        <asp:Button ID="UpdateBtn" runat="server" Text="Actualizar" OnClick="UpdateBtn_Click" />
      </td>
        <td>
            <asp:Button ID="ConfirmarBtn" runat="server" Text="Confirmar" OnClick="ConfirmarBtn_Click" />
        </td>
      <td>
        <!--Checkout Placeholder -->
      </td>
    </tr>
    </table>


</asp:Content>

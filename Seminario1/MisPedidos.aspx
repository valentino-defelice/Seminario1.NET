<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisPedidos.aspx.cs" Inherits="Seminario1.MisPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div>
            <h2> Bienvenido: </h2>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
                    <asp:ListView ID="ListView1" runat="server" GroupItemCount="4" ItemType="Models.Orden" SelectMethod="GetOrdenes">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No tiene ninguna Orden confirmada.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="OrdenDetail.aspx?OrdenId=<%#:Item.OrdenId%>">
                                        <b>Numero de Orden: </b><%#:Item.OrdenId%>
                                    </a>
                                        
                                    </a>
                                    <br />
                                </td>

                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        
                        </p>
                    </td>
                </ItemTemplate>
            </asp:ListView>
</asp:Content>

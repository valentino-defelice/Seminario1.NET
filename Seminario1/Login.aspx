<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Seminario1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="ingreseEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUser" ErrorMessage="Ingrese su e-mail" ControlToValidate="TextBoxEmail" runat="server" /> 
        
    </div>
    <div>
        <asp:Label ID="ingresePass" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPWD" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Ingrese su contraseña" />

    </div>
    <div>
        <asp:Button ID="ButtonIngresar" runat="server" Text="Ingresar" OnClick="ButtonIngresar_Click1"/>
        <asp:Button ID="ButtonCrear" runat="server" Text="Crear Usuario" OnClick="ButtonCrear_Click1"/>
    </div>
    <div>
        <asp:Label ID="resultado" runat="server" Text=""></asp:Label> 
    </div>
</asp:Content>

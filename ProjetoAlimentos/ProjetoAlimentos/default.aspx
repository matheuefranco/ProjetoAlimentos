<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ProjetoAlimentos._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="text-align:center">
        <img alt="Avatar" class="avatar" src="img/avatar.png" /><br />
        Usuario<br />
        <asp:TextBox ID="txtUser" CssClass="form form-control" runat="server"></asp:TextBox>
        <br />
        Senha 
        <br />
        <asp:TextBox ID="txtsenha" CssClass="form form-control" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnAcessa" CssClass="btn btn-success" runat="server" Text="Acessar" OnClick="btnAcessa_Click" />
        <br />
        <br />

    </div>

</asp:Content>

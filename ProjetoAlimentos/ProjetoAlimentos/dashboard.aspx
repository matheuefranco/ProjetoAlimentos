<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="ProjetoAlimentos.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="text-align:center">
     <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:ImageButton ID="btnProdutos" runat="server" ImageUrl="~/img/product_add.png" OnClick="btnProdutos_Click" />
        <br />
   </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="itens.aspx.cs" Inherits="ProjetoAlimentos.itens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1> Cadastro de Itens </h1>
<br />
 <div class="form-group">
   <label for="ddlProd">Produto </label>
    <asp:DropDownList ID="ddlProd" CssClass="form-control" runat="server">
    </asp:DropDownList>
     <label for="ddlProd">Descrição </label>
     <asp:TextBox ID="txtDesc" CssClass="form-control" runat="server"></asp:TextBox>
    
     <label for="ddlProd">Massa Inicial </label>
     <asp:TextBox ID="txtMassa" CssClass="form-control" runat="server"></asp:TextBox>

    <asp:Button ID="btnCadastra" CssClass="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btnCadastra_Click" Width="126px" />
 </div>
     <br />
    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>

</asp:Content>

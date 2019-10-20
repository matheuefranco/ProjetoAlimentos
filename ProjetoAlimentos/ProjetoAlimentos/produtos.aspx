<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="produtos.aspx.cs" Inherits="ProjetoAlimentos.produtos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="col-form-label-lg"> Cadastro de Produtos </h1>
<div class="form-group">
<label for="txtDescricao">Descrição</label>
<asp:TextBox ID="txtDescricao" CssClass="form-control" runat="server"></asp:TextBox>
 </div>

<div class="form-group">
<label for="ddlTipo">Tipo </label>
    <asp:DropDownList ID="ddlTipo" CssClass="form-control" runat="server">
        <asp:ListItem Value="1">Peso</asp:ListItem>
        <asp:ListItem Value="2">Volume</asp:ListItem>
    </asp:DropDownList>
</div>
 <div class="form-group">
    <label for="txtDensidade">Densidade</label>
    <asp:TextBox ID="txtDensidade" CssClass="form-control" runat="server"></asp:TextBox>
 </div>
    <asp:Button ID="btnCadastra" CssClass="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btnCadastra_Click" Width="126px" />
    <br /> <br />
    <div class="row">
     <div class="col">
        <asp:ImageButton ID="btnVoltar" runat="server" ImageUrl="~/img/back.png" OnClick="btnVoltar_Click" />
     </div>
        <div class="col">
           <asp:ImageButton ID="btnItem" runat="server" ImageUrl="~/img/add-item.png" OnClick="btnItem_Click" />
            <br />
            Add Item</div>
    </div>
    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>

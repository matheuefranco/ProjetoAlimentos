<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="consumo.aspx.cs" Inherits="ProjetoAlimentos.consumo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Cadastro de Consumo </h1>
<br />
 <div class="form-group">
   <label for="ddlProd">Produto </label>
    <asp:DropDownList ID="ddlProd" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProd_SelectedIndexChanged">
    </asp:DropDownList>
   <label for="lstItens">Item </label>
     <br />
     <asp:ListBox ID="lstItens" CssClass="form-control" runat="server"></asp:ListBox>
     <br />
     <label for="txtDesc">Descrição </label>
     <asp:TextBox ID="txtDesc" CssClass="form-control" runat="server"></asp:TextBox>
    
     <label for="txtMassa">Massa Consumida</label>
     <asp:TextBox ID="txtMassa" CssClass="form-control" runat="server"></asp:TextBox>
     
     <label for="txtData">Data</label>
     <asp:TextBox ID="txtData" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
     <br />
    <asp:Button ID="btnCadastra" CssClass="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btnCadastra_Click" Width="126px" />
 </div>
     <br />
    <asp:ImageButton ID="btnVoltar" runat="server" ImageUrl="~/img/back.png" OnClick="btnVoltar_Click" />
     <br />
    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>

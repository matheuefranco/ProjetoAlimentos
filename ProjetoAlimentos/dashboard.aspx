<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="ProjetoAlimentos.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="text-align:center">
     <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
       
        
        <div class="row">
          <div class="col">
              <asp:ImageButton ID="btnProdutos" runat="server" ImageUrl="~/img/product_add.png" OnClick="btnProdutos_Click" />
              <br />
              Produtos</div>
          <div class="col">
             <asp:ImageButton ID="btnItens" runat="server" ImageUrl="~/img/vidraria-icon.png" OnClick="btnItens_Click" Height="128px" Width="128px" />
              <br />
              Itens</div>
          <div class="col">
               <asp:ImageButton ID="btnConsumo" runat="server" ImageUrl="~/img/bottle.png" OnClick="btnConsumo_Click" />
               <br />
               Consumo</div>
          <div class="col">&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:ImageButton ID="btnConsumo0" runat="server" ImageUrl="~/img/list.png" OnClick="btnConsumo_Click" />
               <br />
              Listagem</div>
        </div>
   </div>

</asp:Content>

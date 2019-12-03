<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="listagemProdutos.aspx.cs" Inherits="ProjetoAlimentos.listagemProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>
        LISTAGEM</h1>
   <div style="text-align:center" class="table-responsive">  
    <asp:GridView ID="gvdados" CssClass="table table-striped" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="desc_prod" HeaderText="Descrição" />
            <asp:BoundField DataField="qtd_itens" HeaderText="Itens" />
            <asp:BoundField DataField="qtd_total" HeaderText="Total " />
        </Columns>
    </asp:GridView>
</asp:Content>

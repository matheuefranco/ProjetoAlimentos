<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="listaItens.aspx.cs" Inherits="ProjetoAlimentos.listaItens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>LISTAGEM DE ITENS</h1>
    <p class="text-center">Produto:
        <asp:Label ID="lblProd" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
    </p>
   <div style="text-align:center" class="table-responsive">
        <asp:GridView ID="gvItens" CssClass="table table-striped" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="descricao_itens" HeaderText="Descrição" />
                <asp:BoundField DataField="massa" HeaderText="Massa Inicial" />
                <asp:BoundField DataField="massa_restante" HeaderText="Massa Restante" />
                <asp:BoundField DataField="data" HeaderText="Data Cadastro" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblmsg" runat="server" ForeColor="#FF3300"></asp:Label>
    </div>
</asp:Content>

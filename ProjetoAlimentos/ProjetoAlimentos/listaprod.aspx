<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="listaprod.aspx.cs" Inherits="ProjetoAlimentos.listaprod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        LISTAGEM DE PRODUTOS</h1>
   <div style="text-align:center" class="table-responsive">      

        <asp:GridView ID="gvdados" CssClass="table table-striped" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" OnRowCancelingEdit="gvdados_RowCancelingEdit" OnRowEditing="gvdados_RowEditing">
            <Columns>
                <asp:BoundField DataField="desc_prod" HeaderText="Descrição" />
                <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                <asp:BoundField DataField="densidade" HeaderText="Densidade" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

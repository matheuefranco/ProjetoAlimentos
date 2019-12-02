<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="listaprod.aspx.cs" Inherits="ProjetoAlimentos.listaprod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        LISTAGEM DE PRODUTOS</h1>
   <div style="text-align:center" class="table-responsive">      

        <asp:GridView ID="gvdados" CssClass="table table-striped" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" OnRowCancelingEdit="gvdados_RowCancelingEdit" OnRowEditing="gvdados_RowEditing" DataKeyNames="idprodutos" OnRowUpdating="gvdados_RowUpdating" OnSelectedIndexChanged="gvdados_SelectedIndexChanged" OnSelectedIndexChanging="gvdados_SelectedIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="Descrição">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtprod" runat="server" Text='<%# Bind("desc_prod") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblprod" runat="server" Text='<%# Bind("desc_prod") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tipo">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddltipo" runat="server">
                            <asp:ListItem Value="2">Volume</asp:ListItem>
                            <asp:ListItem Value="1">Peso</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("tipo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Densidade">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtdensidade" runat="server" Text='<%# Bind("densidade") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("densidade") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

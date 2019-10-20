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
     <br />
    <asp:Button ID="btnCadastra" CssClass="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btnCadastra_Click" Width="126px" />
 </div>
     <br />
     <div class="row">
     <div class="col">
        <asp:ImageButton ID="btnVoltar" runat="server" ImageUrl="~/img/back.png" OnClick="btnVoltar_Click" />
     </div>
        <div class="col">
           <asp:ImageButton ID="btnConsumo" runat="server" ImageUrl="~/img/add-item.png" OnClick="btnConsumo_Click" />
            <br />
            Add Consumo</div>
    </div>
    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListaItensConsumo.aspx.cs" Inherits="ProjetoAlimentos.ListaItensConsumo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center" class="table-responsive">
        <h3 class="display-4 mb-5">Filtrar Consumos por Período</h3>
        <div class="row justify-content-around"> 
            <div class="col-sm-4">
                <asp:DropDownList ID="lstProd" runat="server" class="form-control ">
                </asp:DropDownList>
            </div>
            <div class="col-sm-3">
                <div class="input-group">
                    <div class="input-group-prepend">
                        <div class="input-group-text">Inicio</div>
                    </div>
                    <asp:TextBox ID="dateSt" runat="server" type="date" class="form-control"/>                
                </div>
            </div>
            <div class="col-sm-3">
                 <div class="input-group">
                     <div class="input-group-prepend">
                         <div class="input-group-text">Fim</div>
                     </div>
                    <asp:TextBox ID="dateEnd" runat="server" type="date" class="form-control"/>
                 </div>
             </div>      
        </div>
        <div class="row my-5 justify-content-center">
            <div class="col-sm-5">
                <asp:Button ID="btnFiltra" runat="server" Text="Filtrar" CssClass="btn btn-outline-success btn-block" OnClick="btnFiltra_Click"/>
            </div>
            <div class="col-sm-5">
                <asp:Button ID="limpa" runat="server" Text="Limpar" CssClass="btn btn-outline-dark btn-block" OnClick="limpa_Click"/>
            </div>
        </div>
        <asp:GridView ID="gvItensConsumo" CssClass="table table-striped" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="desc_prod" HeaderText="Descrição do Produto" />                
                <asp:BoundField DataField="descricao_itens" HeaderText="Descrição" />
                <asp:BoundField DataField="massa_restante" HeaderText="Massa Restante" />
                <asp:BoundField DataField="consumo" HeaderText="Consumo" />
                <asp:BoundField DataField="data" HeaderText="Data Cadastro"/>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblmsg" runat="server" ForeColor="#FF3300"></asp:Label>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ProjetoAlimentos._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="text-align:center">
        <img alt="Avatar" class="avatar" src="img/avatar.png" /><br />
        Usuario<br />
        <asp:TextBox ID="txtUser" CssClass="form form-control" runat="server"></asp:TextBox>
        <br />
        Senha 
        <br />
        <asp:TextBox ID="txtsenha" CssClass="form form-control" runat="server" TextMode="Password" ></asp:TextBox>
        <br />
        <asp:Button ID="btnAcessa" CssClass="btn btn-success" runat="server" Text="Acessar" OnClick="btnAcessa_Click" />
        <br />
        <br />

    </div>
<!-- Modal Popup -->
<div id="MyPopup" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title"> </h4>
            </div>
            <div class="modal-body">
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-danger" data-dismiss="modal">Fechar</button>
            </div>
        </div>
    </div>
</div>
<!-- Modal Popup -->

<script type="text/javascript">
            function ShowPopup(title, body) {
                $("#MyPopup .modal-title").html(title);
                $("#MyPopup .modal-body").html(body);
                $("#MyPopup").modal("show");
            }
</script>
</asp:Content>

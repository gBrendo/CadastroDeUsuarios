<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadUsuario.aspx.cs" Inherits="CadastrodeUsuario.CadUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="alert alert-primary" role="alert">
        Total de Registros :
        <asp:Label ID="lbltotal" runat="server" />
        <br />
        <asp:Label ID="lblmensagem" runat="server" />
    </div>
    <div class="form-group">
        <label>Nome</label>
        <asp:TextBox ID="txtNome" runat="server" />
    </div>
    <div class="form-group">
        <label>Nascimento</label>
        <asp:TextBox ID="txtNascimento" runat="server" type="date" />
    </div>
    <div class="form-group">
        <label>Telefone</label>
        <asp:TextBox ID="txtTelefone" runat="server" />
    </div>
    <div class="form-group">
        <asp:CheckBox ID="cbAtivo" runat="server" Text="Ativo" />
    </div>
    <asp:Button ID="btnSalvar" runat="server" Text="salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" CssClass="btn" OnClick="btnLimpar_Click" />
</asp:Content>


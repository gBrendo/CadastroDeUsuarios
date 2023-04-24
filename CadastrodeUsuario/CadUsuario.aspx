<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadUsuario.aspx.cs" Inherits="CadastrodeUsuario.CadUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="alert alert-primary" role="alert">
        Total de Registros :
        <asp:Label ID="lbltotal" runat="server" />
        <br />
        ...
        <asp:Label ID="lblmensagem" runat="server" />
    </div>
    <asp:Panel ID="pnlCadastro" runat="server" Visible="false">
        <div class="form-group">
            <label>Nome</label>
            <asp:TextBox ID="txtNome" runat="server" />

        </div>
        <div class="form-group">
            <label>Nascimento</label>
            <asp:TextBox ID="txtNascimento" runat="server" type="date" />
            <br />
        </div>
        <div class="form-group">
            <label>Telefone</label>
            <asp:TextBox ID="txtTelefone" runat="server" />
        </div>
        <div class="form-group">
            <asp:CheckBox ID="cbAtivo" runat="server" Text="Ativo" />
        </div>
        <asp:Button ID="btnSalvar" runat="server" Text="salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" ViewStateMode="Enabled" />
        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" CssClass="btn" OnClick="btnVoltar_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlPesquisa" runat="server" Visible="true">
        <div class="row">
            <div class="mb-3">
                <label for="txtNomePesquisa" class="form-label">Nome</label>
                <asp:TextBox ID="txtNomePesquisa" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="btnPesquisar" runat="server" OnClick="btnPesquisar_Click" Text="Pesquisar" CssClass="btn" />
        <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" CssClass="btn btn-primary" />
        <asp:GridView ID="gridResultado" runat="server" Height="1" HorizontalAlign="center" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Nascimento" HeaderText="Nascimento" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>



</asp:Content>


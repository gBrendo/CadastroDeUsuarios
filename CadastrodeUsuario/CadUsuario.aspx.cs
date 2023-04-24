using CadastrodeUsuario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastrodeUsuario
{
    /// <summary>
    /// tarefas
    /// ajustar o layout do painel de cadastro
    /// ao salvar o registro, exibir mensagem de sucesso e voltar para tela de pesquisa
    /// trocar o botão limpar por voltar
    /// ao clicar em voltar exibir o painel de pesquisa e ocultar o painel de cadastro
    /// 
    /// </summary>
    public partial class CadUsuario : System.Web.UI.Page
    {
        private Contexto banco;
        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new Contexto();
            if (!IsPostBack)
            {
                ExibirTotal();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            // validaçoes de entrada
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Ativo = cbAtivo.Checked;
            usuario.Nascimento =Convert.ToDateTime(txtNascimento.Text);
            usuario.Telefone = txtTelefone.Text;

            //salvar o usuario no banco de dados

            banco.Add(usuario);
            banco.SaveChanges();

            lblmensagem.Text = "Usuário salvo com sucesso";
            ExibirTotal();
           


        }

        public void ExibirTotal()
        {
            int usuariosCadastrados = banco.Usuarios.Count();
            lbltotal.Text = usuariosCadastrados.ToString();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            var resultado = banco.Usuarios.Where(item => item.Nome.Contains(txtNomePesquisa.Text)).ToList();
            gridResultado.DataSource = resultado;
            gridResultado.DataBind();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            //exibir o painel de cadastro e ocultar o painel de pesquisa
            pnlCadastro.Visible = true;
            pnlPesquisa.Visible = false;
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNascimento.Text = string.Empty;
            cbAtivo.Checked = false;
            pnlCadastro.Visible = false;
            pnlPesquisa.Visible = true;


        }
    }
}

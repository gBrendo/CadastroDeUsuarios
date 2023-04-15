using CadastrodeUsuario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastrodeUsuario
{
    public partial class CadUsuario : System.Web.UI.Page
    {
        private Contexto banco;
        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new Contexto();
            int usuariosCadastrados = banco.Usuarios.Count();
            lbltotal.Text=usuariosCadastrados.ToString();

           

           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            // validaçoes de entrada
            Usuario usuario = new Usuario();
            usuario.Ativo = cbAtivo.Checked;
            usuario.Nascimento =Convert.ToDateTime(txtNascimento.Text);
            usuario.Telefone = txtTelefone.Text;

            //salvar o usuario no banco de dados

            banco.Add(usuario);
            banco.SaveChanges();
            Response.Write("Usuario salvo com sucesso.");


        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNascimento.Text = string.Empty;
            cbAtivo.Checked = false;
        }
    }
}
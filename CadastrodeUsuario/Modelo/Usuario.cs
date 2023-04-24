using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastrodeUsuario.Modelo
{
    public class Usuario

    {
        public Usuario()
        {
            
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public string Telefone { get; set; }

        public static List<Usuario> Lista = new List<Usuario>();

        public List<Usuario> Todos()
        {
            return Usuario.Lista;
        }

        public void Salvar()
        {
            Usuario.Lista.Add(this);
        }

        public bool Ativo { get; set; }

    }
}
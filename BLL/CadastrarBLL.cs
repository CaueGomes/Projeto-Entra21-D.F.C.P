using System;
using DAL;
using BLL.Interfaces;
using Metadata;

namespace BLL
{
    public class CadastrarBLL : ILoginCadastro
    {
        public void Inserir(Usuario usuario)
        {
            ConnectionDatabase.Insert(usuario);
        }
        public string ValidarUsuario(Usuario usuario)
        {
            if (ConnectionDatabase.ValidarUsuarioExistente(usuario))
            {
                return "deu certo";
            }
            return "ERROR";
        }
        public string ValidaLogin(Usuario usuario)
        {
            if (ConnectionDatabase.ValidaLogin(usuario))
            {
                return "";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}

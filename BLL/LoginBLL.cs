using System;
using BLL.Interfaces;
using Metadata;
using DAL;

namespace BLL
{
    public class LoginBLL : ILoginCadastro
    {
        public void Inserir(Usuario usuario)
        {
            ConnectionDatabase.Insert(usuario);
        }
        public string ValidarUsuario(Usuario usuario)
        {
            return ConnectionDatabase.ValidarUsuarioExistente(usuario);
        }
    }
}

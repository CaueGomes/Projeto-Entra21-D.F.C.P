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
            return ConnectionDatabase.ValidarUsuarioExistente(usuario);
        }
    }
}

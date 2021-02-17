using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Metadata;

namespace BLL.Interfaces
{
    interface ILoginCadastro
    {
        public void Inserir(Usuario usuario)
        {
            ConnectionDatabase.Insert(usuario);
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

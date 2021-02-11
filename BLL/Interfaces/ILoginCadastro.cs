using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BLL.Interfaces
{
    interface ILoginCadastro
    {
        public void Inserir(string nome, string email, string senha, int idade, string profissao)
        {
            ConnectionDatabase.Insert(nome, email, senha, idade, profissao);
        }
        public string ValidarUsuario(string nome)
        {
            return ConnectionDatabase.ValidarUsuarioExistente(nome);
        }
    }
}

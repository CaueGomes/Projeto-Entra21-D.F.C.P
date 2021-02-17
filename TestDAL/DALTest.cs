using DAL;
using Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DALTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestUpdate()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "João"; string nome = "Admin";
            bool resultado = ConnectionDatabase.Update(usuario, nome);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInsert()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "João"; usuario.Email = "Admin@adm.com"; usuario.Senha = "12345"; usuario.Idade = 21; usuario.Profissao = "Desenvolvedor";
            bool resultado = ConnectionDatabase.Insert(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestValidarUsuarioExistente()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "João"; usuario.Email = "Admin@adm.com"; usuario.Senha = "12345"; usuario.Idade = 21; usuario.Profissao = "Desenvolvedor";
            bool resultado = ConnectionDatabase.ValidarUsuarioExistente(usuario);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestHistóricoValores()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; int id = 1; List<double> lt = new List<double>();
            bool resultado = ConnectionDatabase.HistóricoValores(tabela, id, out lt);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestHistóricoNomes()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; string motivo = "Motivo"; int id = 1; List<string> lt = new List<string>();
            bool resultado = ConnectionDatabase.HistóricoNomes(tabela, motivo, id, out lt);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInsertValor()
        {
            Usuario usuario = new Usuario();
            Ganhos ganho = new Ganhos();
            usuario.Id = 1015;
            string tabela = "Ganhos"; string motivo = "Motivo"; double valor = 0;
            bool resultado = ConnectionDatabase.InsertValor(usuario, tabela, valor, motivo);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestLogin()
        {
            Usuario usuario = new Usuario();
            usuario.Email = "Admin@adm.com"; usuario.Senha = "2706";
            bool resultado = ConnectionDatabase.ValidaLogin(usuario);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestDelete()
        {
            Usuario usuario = new Usuario();
            usuario.Id = 1;
            bool resultado = ConnectionDatabase.DeleteUsuario(usuario);
            Assert.IsTrue(resultado);
        }
    }
}
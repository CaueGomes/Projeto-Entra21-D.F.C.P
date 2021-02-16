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
            usuario.Nome = "João";
            bool resultado = ConnectionDatabase.Update(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInsert()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "João"; usuario.Email = "kaimanmello123@yahoo.com"; usuario.Senha = "12345"; usuario.Idade = 21; usuario.Profissao = "Desenvolvedor";
            bool resultado = ConnectionDatabase.Insert(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestValidarUsuarioExistente()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "João"; usuario.Email = "kaimanmello123@yahoo.com"; usuario.Senha = "12345"; usuario.Idade = 21; usuario.Profissao = "Desenvolvedor";
            bool resultado = ConnectionDatabase.Insert(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestHistóricoValores()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; string nome = "João"; List<double> lt = new List<double>();
            bool resultado = ConnectionDatabase.HistóricoValores(tabela, nome, out lt);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestHistóricoNomes()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; string motivo = "Motivo"; string nome = "João"; List<string> lt = new List<string>();
            bool resultado = ConnectionDatabase.HistóricoNomes(tabela, nome, motivo, out lt);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInsertValor()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; string motivo = "Motivo"; string nome = "João"; double valor = 0;
            bool resultado = ConnectionDatabase.InsertValor(tabela, nome, valor, motivo);
            Assert.IsTrue(resultado);
        }

        //[TestMethod]
        //public void TestLogin()
        //{
        //    Usuario usuario = new Usuario();
        //    string tabela = "Ganhos"; string motivo = "Motivo"; string nome = "João"; double valor = 0;
        //    bool resultado = ConnectionDatabase.ValidaLogin();
        //    Assert.IsTrue(resultado);
        //}
    }
}
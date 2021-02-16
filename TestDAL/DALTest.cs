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
            usuario.Nome = "Jo�o";
            bool resultado = ConnectionDatabase.Update(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInsert()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "Jo�o"; usuario.Email = "kaimanmello123@yahoo.com"; usuario.Senha = "12345"; usuario.Idade = 21; usuario.Profissao = "Desenvolvedor";
            bool resultado = ConnectionDatabase.Insert(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestValidarUsuarioExistente()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "Jo�o"; usuario.Email = "kaimanmello123@yahoo.com"; usuario.Senha = "12345"; usuario.Idade = 21; usuario.Profissao = "Desenvolvedor";
            bool resultado = ConnectionDatabase.Insert(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestHist�ricoValores()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; string nome = "Jo�o"; List<double> lt = new List<double>();
            bool resultado = ConnectionDatabase.Hist�ricoValores(tabela, nome, out lt);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestHist�ricoNomes()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; string motivo = "Motivo"; string nome = "Jo�o"; List<string> lt = new List<string>();
            bool resultado = ConnectionDatabase.Hist�ricoNomes(tabela, nome, motivo, out lt);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInsertValor()
        {
            Ganhos ganho = new Ganhos();
            string tabela = "Ganhos"; string motivo = "Motivo"; string nome = "Jo�o"; double valor = 0;
            bool resultado = ConnectionDatabase.InsertValor(tabela, nome, valor, motivo);
            Assert.IsTrue(resultado);
        }

        //[TestMethod]
        //public void TestLogin()
        //{
        //    Usuario usuario = new Usuario();
        //    string tabela = "Ganhos"; string motivo = "Motivo"; string nome = "Jo�o"; double valor = 0;
        //    bool resultado = ConnectionDatabase.ValidaLogin();
        //    Assert.IsTrue(resultado);
        //}
    }
}
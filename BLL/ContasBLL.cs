using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL;
using Metadata;

namespace BLL
{
    public class ContasBLL : IPaginas
    {
        public List<string> ListaNome(Usuario usuario)
        {
            string tabela = "Contas"; string motivo = "Conta";
            List<string> lt = new List<string>();
            ConnectionDatabase.HistóricoNomes(tabela, motivo, usuario.Nome, out lt);
            return lt;
        }
        public List<double> Listavalor(Usuario usuario)
        {
            string tabela = "Contas"; string motivo = "Conta";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, motivo, usuario.Nome, out lt);
            return lt;
        }
        public void CadastrarValor(string nome, double valor, string motivo)
        {
            string tabela = "Contas";
            ConnectionDatabase.InsertValor(tabela, nome, valor, motivo);
        }
        public double SomaValores(Usuario usuario)
        {
            double total = 0;
            string tabela = "Contas"; string motivo = "Conta";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, motivo, usuario.Nome, out lt);
            for (int i = 0; i < lt.Count; i++)
            {
                total += lt[i];
            }
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BLL.Interfaces
{
    interface IPaginas
    {
        public List<string> ListaNome(string nome)
        {
            string tabela = ""; string motivo = "";
            List<string> lt = new List<string>();
            ConnectionDatabase.HistóricoNomes(tabela, motivo, nome, out lt);
            return lt;
        }
        public List<double> Listavalor(string nome)
        {
            string tabela = ""; string motivo = "";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, motivo, nome, out lt);
            return lt;
        }
        public void CadastrarValor(string nome, double valor, string motivo)
        {
            string tabela = "";
            ConnectionDatabase.InsertValor(tabela, nome, valor, motivo);
        }
        public double SomaValores(string nome)
        {
            double total = 0;
            string tabela = ""; string motivo = "";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, motivo, nome, out lt);
            for (int i = 0; i < lt.Count; i++)
            {
                total += lt[i];
            }
            return total;
        }
    }
}

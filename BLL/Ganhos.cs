using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using BLL.Interfaces;

namespace BLL
{
    public class Ganhos : IPaginas
    {
        public List<string> ListaNome(string nome)
        {
            string tabela = "Ganhos"; string motivo = "Motivo";
            List<string> lt = new List<string>();
            ConnectionDatabase.HistóricoNomes(tabela, motivo, nome, out lt);
            return lt;
        }
        public List<double> Listavalor(string nome)
        {
            string tabela = "Ganhos"; string motivo = "Motivo";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, motivo, nome, out lt);
            return lt;
        }
        public void CadastrarValor(string nome, double valor, string motivo)
        {
            string tabela = "Ganhos";
            ConnectionDatabase.InsertValor(tabela, nome, valor, motivo);
        }
    }
}

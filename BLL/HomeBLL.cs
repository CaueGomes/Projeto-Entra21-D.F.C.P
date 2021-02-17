﻿using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using Metadata;
using DAL;

namespace BLL
{
    class HomeBLL : IPaginas
    {
        public List<string> ListaNome(Usuario usuario)
        {
            string tabela = ""; string motivo = "";
            List<string> lt = new List<string>();
            ConnectionDatabase.HistóricoNomes(tabela, motivo, usuario.Id, out lt);
            return lt;
        }
        public List<double> Listavalor(Usuario usuario)
        {
            string tabela = "";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, usuario.Id, out lt);
            return lt;
        }
        public void CadastrarValor(Usuario usuario, double valor, string motivo)
        {
            string tabela = "";
            ConnectionDatabase.InsertValor(usuario, tabela, valor, motivo);
        }
        public void SomaValores(Usuario usuario, out double total)
        {
            total = 0;
            string tabela = "Contas";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, usuario.Id, out lt);
            for (int i = 0; i < lt.Count; i++)
            {
                total += lt[i];
            }
        }
    }
}

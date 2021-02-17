using System;
using System.Collections.Generic;
using System.Text;
using Metadata;

namespace BLL
{
    public static class StaticsMethods
    {
        public static List<double> ltValoresGanhos(int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            GanhosBLL ltg = new GanhosBLL();
            return ltg.Listavalor(usuario);
        }
        public static List<string> ltNomesGanhos(int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            GanhosBLL ltg = new GanhosBLL();
            return ltg.ListaNome(usuario);
        }

        public static List<double> ltValoresGastos(int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            GastosBLL ltg = new GastosBLL();
            return ltg.Listavalor(usuario);
        }
        public static List<string> ltNomesGastos(int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            GastosBLL ltg = new GastosBLL();
            return ltg.ListaNome(usuario);
        }

        public static List<double> ltValoresSaldo(int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            SaldoBLL lts = new SaldoBLL();
            return lts.Listavalor(usuario);
        }
            public static List<string> ltNomesSaldo(int id)
            {
                Usuario usuario = new Usuario();
                usuario.Id = id;
                SaldoBLL lts = new SaldoBLL();
                return lts.ListaNome(usuario);
            }
        

        public static List<double> ltValoresContas(int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            ContasBLL ltc = new ContasBLL();
            return ltc.Listavalor(usuario);
        }

        public static void ListsHome(out List<double> ltGh, out List<double> ltGt, int id)
        {
            Usuario usuario = new Usuario();
            GastosBLL ltgt = new GastosBLL();
            GanhosBLL ltgh = new GanhosBLL();

            ltGh = ltgh.Listavalor(usuario);
            ltGt = ltgt.Listavalor(usuario);
            
        }

        public static void SomaTotalSaldo(double total, int id)
        {
            SaldoBLL saldo = new SaldoBLL();
            Usuario usuario = new Usuario();
            saldo.SomaValores(usuario, out total);
        }
    }
}

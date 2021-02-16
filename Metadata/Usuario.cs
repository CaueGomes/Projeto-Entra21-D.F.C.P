using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
        public List<Contas> Contas { get; set; }
        public List<Gastos> Despesas { get; set; }
        public List<Ganhos> ganhos { get; set; }
        public List<Saldo> saldo { get; set; }
    }
}

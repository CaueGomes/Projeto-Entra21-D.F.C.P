using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Entra21_DFCP.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
        public List<ContasPagar> Contas { get; set; }
        public int ContasPagarId { get; set; }
        public List<DespesasDesnecessarias> Despesas { get; set; }
        public int DespesasId { get; set; }
        public List<Ganhos> ganhos { get; set; }
        public int GanhosId { get; set; }
        public List<RemuneracaoTotal> saldo { get; set; }
        public int SaldoId { get; set; }
    }
}

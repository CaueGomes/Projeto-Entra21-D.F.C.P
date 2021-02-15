using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata
{
    public class Saldo
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public double Valor { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}

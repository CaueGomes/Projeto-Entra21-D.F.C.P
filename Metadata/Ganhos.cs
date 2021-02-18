using System;
using System.Collections.Generic;
using System.Text;

namespace Metadata
{
    public class Ganhos
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public double Valor { get; set; }
        public Usuario Usuario { get; set; }
        public int IdUsuario { get; set; }
    }
}

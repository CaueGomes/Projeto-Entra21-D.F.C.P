using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata
{
    public class RemuneracaoTotal
    {
        public int Id { get; set; }
        public double RemuneracaoIndividual { get; set; }
        public double RemuneracaoFamilia { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}

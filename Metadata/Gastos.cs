using System;

namespace Metadata
{
    public class Gastos
    {
        public int Id { get; set; }
        public string Compra { get; set; }
        public double Valor { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}

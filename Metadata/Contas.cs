using System;


namespace Metadata
{
    public class Contas
    {
        public int Id { get; set; }
        public string Conta { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagar { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}

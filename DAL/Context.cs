using Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Saldo> RemuneracoesTotais { get; set; }
        public DbSet<Contas> Contas { get; set; }
        public DbSet<Gastos> Despesas { get; set; }
        public DbSet<Ganhos> Ganhos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EagleGameplay\Desktop\Cursos\Projeto-Entra21-D.F.C.P\DAL\DataBaseDFCP.mdf;Integrated Security=True");
        }
    }
}

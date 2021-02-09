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
        public DbSet<RemuneracaoTotal> RemuneracoesTotais { get; set; }
        public DbSet<ContasPagar> Contas { get; set; }
        public DbSet<DespesasDesnecessarias> Despesas { get; set; }
        public DbSet<Ganhos> Ganhos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=admin;Persist Security Info=False;User ID=sa;Initial Catalog=D.F.C.P;Data Source=KORI\SQLEXPRESS");
        }
    }
}

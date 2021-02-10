using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class ConnectionDatabase
    {
        public static SqlConnection con = new SqlConnection(@"Password=admin;Persist Security Info=False;User ID=sa;Initial Catalog=D.F.C.P;Data Source=KORI\SQLEXPRESS");
        public void Insert(string nome, string email, string senha, int idade, string profissao)
        {
            string insert = $"INSERT Into Usuario (Nome, Email, Senha, Idade, Profissao) values ('{nome}','{email}','{senha}','{idade}','{profissao}')";
            SqlCommand cmd;
            cmd = new SqlCommand(insert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

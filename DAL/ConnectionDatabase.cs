using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Metadata;

namespace DAL
{
    public static class ConnectionDatabase
    {
        public static SqlConnection con = new SqlConnection(@"Password=admin;Persist Security Info=False;User ID=sa;Initial Catalog=D.F.C.P;Data Source=KORI\SQLEXPRESS");
        public static SqlCommand cmd;
        public static SqlDataReader dataReader;

        public static void Insert(Usuario usuario)
        {
            string insert = $"INSERT Into Usuario (Nome, Email, Senha, Idade, Profissao) values ('{usuario.Nome}','{usuario.Email}','{usuario.Senha}','{usuario.Idade}','{usuario.Profissao}')";
            cmd = new SqlCommand(insert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Update(Usuario usuario)
        {
            int Id;
            string sqlId = "Select * FROM Usuario";
            cmd = new SqlCommand(sqlId, con);
            con.Open();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (Convert.ToString(dataReader["Nome"]) == usuario.Nome)
                {
                    Id = Convert.ToInt32(dataReader["Id"]);
                    string update = $"UPDATE Usuario Set Nome = '{usuario.Nome}' WHERE Id ='{Id}'";
                    break;
                }
            }
            cmd = new SqlCommand(usuario.Nome, con);
            con.Close();
        }
        public static string ValidarUsuarioExistente(Usuario usuario)
        {
            string sqlId = "Select * FROM Usuario";
            cmd = new SqlCommand(sqlId, con);
            con.Open();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (Convert.ToString(dataReader["Email"]) == usuario.Email)
                {
                    return "Usuário ja existe no banco de dados!!";
                }
            }
            con.Close();
            return "";
        }
        public static void HistóricoValores(string tabela, string motivo, string nome, out List<double> valor)
        {
            valor = new List<double>();
            string select = $"Select * FROM '{tabela}' WHERE Nome = '{nome}'";
            cmd = new SqlCommand(select, con);
            con.Open();
            dataReader = cmd.ExecuteReader();
            
            while (dataReader.Read())
            {
                int i = 0;

                valor[i] = (double)dataReader["Valor"];
                i++;
            }

            dataReader.Close();
            con.Close();
        }
        public static void HistóricoNomes(string tabela, string motivo, string nome, out List<string> nomeConta)
        {
            nomeConta = new List<string>();
            string select = $"Select * FROM '{tabela}' WHERE Nome = '{nome}'";
            cmd = new SqlCommand(select, con);
            con.Open();
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int i = 0;

                nomeConta[i] = (string)dataReader[motivo];
                i++;
            }

            dataReader.Close();
            con.Close();
        }
        public static void InsertValor(string tabela, string nome, double valor, string motivo)
        {
            string select = $"Select * FROM '{tabela}' WHERE Nome = '{nome}'";
            cmd = new SqlCommand(select, con);
            con.Open();
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string insert = $"INSERT Into '{tabela}' (Motivo, Valor) values ('{motivo}','{valor}')";
                cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                break;
            }

            con.Close();
            dataReader.Close();
            
        }
    }
}

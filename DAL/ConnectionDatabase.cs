﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Metadata;

namespace DAL
{
    public static class ConnectionDatabase
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EagleGameplay\Desktop\Cursos\Projeto-Entra21-D.F.C.P\DAL\DataBaseDFCP.mdf;Integrated Security=True");
        public static SqlCommand cmd;
        public static SqlDataReader dataReader;

        public static bool Insert(Usuario usuario)
        {
            try
            {
                string insert = $"INSERT Into Usuarios (Nome, Email, Senha, Idade, Profissao) values ('{usuario.Nome}','{usuario.Email}','{usuario.Senha}','{usuario.Idade}','{usuario.Profissao}')";
                cmd = new SqlCommand(insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool Update(Usuario usuario, string nome)
        {
            try
            {
                int Id;
                string sqlId = "Select * FROM Usuarios";
                string update = "";
                cmd = new SqlCommand(sqlId, con);
                con.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (Convert.ToString(dataReader["Nome"]) == usuario.Nome)
                    {
                        Id = Convert.ToInt32(dataReader["Id"]);
                        update = $"UPDATE Usuarios Set Nome = '{nome}' WHERE Id ='{Id}'";
                        break;
                    }
                }
                dataReader.Close();
                cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool ValidarUsuarioExistente(Usuario usuario)
        {
            try
            {
                string sqlId = "Select * FROM Usuarios";
                cmd = new SqlCommand(sqlId, con);
                con.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (Convert.ToString(dataReader["Email"]) == usuario.Email)
                    {
                        return false;
                    }
                }
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool ValidaLogin(Usuario usuario)
        {
            try
            {
                string sqlId = "Select * FROM Usuarios";
                cmd = new SqlCommand(sqlId, con);
                con.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (Convert.ToString(dataReader["Email"]) == usuario.Email)
                    {
                        if (usuario.Senha == (string)dataReader["Senha"])
                        {
                            return true;
                        }
                    }
                }
                dataReader.Close();
                con.Close();
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool HistóricoValores(string tabela, int id, out List<double> valor)
        {
            try
            {
                valor = new List<double>(5);
                string select = $"Select * FROM {tabela} WHERE IdUsuario = 1015";
                cmd = new SqlCommand(select, con);
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    double recebe = (double)dataReader["Valor"];
                    valor.Add(recebe); 

                }

                dataReader.Close();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                valor = new List<double>();
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool HistóricoNomes(string tabela, string motivo, int Id, out List<string> nomeConta)
        {
            try
            {
                nomeConta = new List<string>();
                string select = $"Select * FROM {tabela} WHERE IdUsuario = '{Id}'";
                cmd = new SqlCommand(select, con);
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string recebe = (string)dataReader[motivo];
                    nomeConta.Add(recebe);
                }

                dataReader.Close();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                nomeConta = new List<string>();
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool InsertValor(Usuario usuario, string tabela, double valor, string motivo)
        {
            try
            { 
                string select = $"Select * FROM Usuarios WHERE Id = '{usuario.Id}'";
                cmd = new SqlCommand(select, con);
                con.Open();
                dataReader = cmd.ExecuteReader();

                string insert = "";
                while (dataReader.Read())
                {
                    insert = $"INSERT Into {tabela} (IdUsuario, Motivo, Valor) values ('{usuario.Id}', '{motivo}', '{valor}')";
                    break;
                }
                dataReader.Close();
                cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool DeleteUsuario(Usuario usuario)
        {
            try
            {
                string delete = $"Delete From Usuarios Where Id = '{usuario.Id}'";
                cmd = new SqlCommand(delete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}

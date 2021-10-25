using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Datos.Servidor;

namespace Datos.Admin
{
    public static class AdmPublisher
    {
        public static List<Publisher> Listar()
        {
            string consulta = "SELECT pub_id, pub_name, city, state, country FROM dbo.Publishers";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while(reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_Name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString(),

                    }
                    ) ;
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return lista; 
        }
        public static List<Publisher> Listar(string city)
        {
            string consulta = "SELECT pub_id, pub_name, city, state, country FROM dbo.Publishers WHERE City=@City";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            comando.Parameters.Add("City", SqlDbType.VarChar, 20).Value = city; 
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_Name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString(),

                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return lista;
        }
        public static List<Publisher> Listar(string city, string state)
        {
            string consulta = "SELECT pub_id, pub_name, city, state, country FROM dbo.Publishers  WHERE City=@City AND State=@State";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            comando.Parameters.Add("City", SqlDbType.VarChar, 20).Value = city;
            comando.Parameters.Add("State", SqlDbType.Char, 2).Value = state;
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_Name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString(),

                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return lista;
        }
        public static List<Publisher> Listar(string city, string state, string country)
        {
            string consulta = "SELECT pub_id, pub_name, city, state, country FROM dbo.Publishers  WHERE City=@City AND State=@State AND Country=@Country";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            comando.Parameters.Add("City", SqlDbType.VarChar, 20).Value = city;
            comando.Parameters.Add("State", SqlDbType.Char, 2).Value = state;
            comando.Parameters.Add("Country", SqlDbType.VarChar, 30).Value = country;
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_Name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString(),

                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return lista;
        }
    }
}

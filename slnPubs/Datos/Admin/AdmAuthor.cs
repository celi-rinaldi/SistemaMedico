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
    public static class AdmAuthor
    {
        public static DataTable listarSoloCiudades()
        {
            string consulta = "SELECT distinct city FROM dbo.Authors";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "City");
            return ds.Tables["City"];
        }
        public static DataTable ListarDataTable()
        {
            string consulta = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.Authors";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "City");
            return ds.Tables["City"];
        }
        public static DataTable ListarDataTable(string city)
        {
            string consulta = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.Authors WHERE city=@city";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            adapter.SelectCommand.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "city");
            return ds.Tables["city"]; 
        }

        public static List<Author> Listar()
        {
            string consulta = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.Authors";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Author> listaAutores = new List<Author>(); 
            while(reader.Read())
            {
                listaAutores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = Convert.ToBoolean(reader["contract"])
                    }
                    ) ;
            }
            AdminDB.ConectarBase().Close(); 
            reader.Close();
            return listaAutores; 
        }
        public static List<Author> Listar(string city)
        {
            string consulta = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.Authors WHERE City=@City";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            comando.Parameters.Add("@City", SqlDbType.VarChar).Value = city;
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Author> listaAutores = new List<Author>();
            while (reader.Read())
            {
                listaAutores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = Convert.ToBoolean(reader["contract"])
                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return listaAutores;
        }
        public static List<Author> Listar(string city, string state)
        {
            string consulta = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract FROM dbo.Authors WHERE City=@City AND State=@State";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarBase());
            comando.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = city;
            comando.Parameters.Add("@State", SqlDbType.Char, 2).Value = state;
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Author> listaAutores = new List<Author>();
            while (reader.Read())
            {
                listaAutores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = Convert.ToBoolean(reader["contract"])
                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return listaAutores; 
        }
    }
 
}

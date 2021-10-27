using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;
using System.Data.SqlClient;
using Datos.Servidor;

namespace Datos.Admin
{
    public static class AdminMedico
    {
        public static List<Medico> Listar()
        {
            string consulta = "SELECT Id, Nombre, Apellido, NroMatricula, Especialidad FROM dbo.Medico";
            SqlCommand command = new SqlCommand(consulta, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Medico> lista = new List<Medico>();
            while (reader.Read())
            {
                lista.Add(

                  new Medico()
                  {
                      Id = (int)reader["Id"],
                      Apellido = reader["Apellido"].ToString(),
                      Nombre = reader["Nombre"].ToString(),
                      NroMatricula = (int)reader["NroMatricula"],
                      IdEspecialidad = (int)reader["Especialidad"]
                  }

                    ) ; 
            }
            AdminDB.ConectarBase().Close();
            reader.Close(); 
            return lista; 
        }
        public static DataTable Listar(int IdEspecialidad)
        {
            string consulta = "SELECT nombre, apellido, NroMatricula, Especialidad FROM dbo.Medico WHERE @Especialidad=Especialidad"; 
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            adapter.SelectCommand.Parameters.Add("@Especialidad", SqlDbType.Int).Value = IdEspecialidad;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Especialidad"); 
            return ds.Tables["Especialidad"];
        }
        public static DataTable TraerUno(int Id)
        {
            string consulta = "SELECT nombre, apellido, NroMatricula, Especialidad FROM dbo.Medico WHERE Id=@Id"; 
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Id");
            return ds.Tables["Id"];
        }

        public static int Crear(Medico m)
        {
            string insertSQL = "INSERT dbo.Medico (Nombre, Apellido, NroMatricula, Especialidad) VALUES (@Nombre, @Apellido, @NroMatricula, @Especialidad)";
            SqlCommand comando = new SqlCommand(insertSQL, AdminDB.ConectarBase());
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = m.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = m.Apellido;
            comando.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = m.NroMatricula;
            comando.Parameters.Add("@Especialidad", SqlDbType.VarChar, 50).Value = m.IdEspecialidad;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasAfectadas; 
        }
        public static int Modificar(Medico m)
        {
            string update = "UPDATE dbo.Medico SET Nombre=@Nombre, Apellido=@Apellido, NroMatricula=@NroMatricula, Especialidad=@Especialidad WHERE Id=@Id";
            SqlCommand command = new SqlCommand(update, AdminDB.ConectarBase());
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = m.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = m.Apellido;
            command.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = m.NroMatricula;
            command.Parameters.Add("@Especialidad", SqlDbType.Int).Value = m.IdEspecialidad;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = m.Id;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();

            return filasAfectadas;

        }
        public static int Eliminar(int id)
        {
            string deleteSQL = "DELETE FROM dbo.Medico WHERE Id=@Id";
            SqlCommand command = new SqlCommand(deleteSQL, AdminDB.ConectarBase());
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }
    }
}

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
    public static class AdminEspecialidad
    {
        public static DataTable Listar()
        {
            string consulta = "SELECT Id, Nombre from dbo.Especialidad";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Especialidad");
            return ds.Tables["Especialidad"];
        }
        public static DataTable TraerUno(int id)
        {
            string consulta = "SELECT Id, Nombre from dbo.Especialidad WHERE Id=@Id";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConectarBase());
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "IdEspecialidad");
            return ds.Tables["IdEspecialidad"];
        }
        public static int Crear(Especialidad especialidad)
        {
            string insertSQL = "INSERT dbo.Especialidad (Id, Nombre) VALUES (@Id, @Especialidad)";
            SqlCommand comando = new SqlCommand(insertSQL, AdminDB.ConectarBase());
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = especialidad.Id;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = especialidad.Nombre;
            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }

    }
}

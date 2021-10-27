using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.Servidor
{
    internal static class AdminDB
    {
        // realizar la conexion a la base de datos, los metodos
        internal static SqlConnection ConectarBase()
        {
            string cadena = Datos.Properties.Settings.Default.KeyDBMedicos;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            return connection;
        }
    }
}

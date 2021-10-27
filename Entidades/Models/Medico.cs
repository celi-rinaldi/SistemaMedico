using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Medico
    {
        public Medico()
        {
        }

        public Medico(string apellido, string nombre, int matricula, int idEspecialidad)
        {
            Apellido = apellido;
            Nombre = nombre;
            NroMatricula = matricula;
            IdEspecialidad = idEspecialidad;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NroMatricula { get; set; }
        public int IdEspecialidad { get; set; }
    }
}

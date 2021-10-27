using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Admin;
using Entidades.Models; 

namespace WindowsMedicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarTodo();
            llenarComboEspecialidad();
            llenarComboTraerPorEspecialidad(); 
        }

        private void llenarComboTraerPorEspecialidad()
        {
            DataTable Especialidad = AdminEspecialidad.Listar();

            cbTraerPorEspecialidad.DataSource = Especialidad;
            cbTraerPorEspecialidad.DisplayMember = Especialidad.Columns["Nombre"].ToString();
            cbTraerPorEspecialidad.ValueMember = Especialidad.Columns["Nombre"].ToString();
            DataRow fila = Especialidad.NewRow();
            fila["Nombre"] = 0;
            fila["Nombre"] = "[TODAS]";
            Especialidad.Rows.InsertAt(fila, 0);


        }

        private void llenarComboEspecialidad()
        {
            DataTable Especialidad = AdminEspecialidad.Listar();

            cbEspecialidad.DataSource = Especialidad;
            cbEspecialidad.DisplayMember = Especialidad.Columns["Nombre"].ToString();
            cbEspecialidad.ValueMember = Especialidad.Columns["Nombre"].ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Medico medico = new Medico(txtApellido.Text, txtNombre.Text, Convert.ToInt32(txtNroMatricula.Text), definirEspecialidad(cbEspecialidad.SelectedValue.ToString()));
            AdminMedico.Crear(medico); 
        }

        private int definirEspecialidad(string especialidad)
        {
            int id = 0;
            switch(especialidad)
            {
                case "Pediatria": id = 2;
                    break;
                case "Clinica": id = 1;
                    break;
            }
            return id;
        }

        private void mostrarTodo()
        {
            gridMedicos.DataSource = AdminMedico.Listar();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarTodo();
        }

        private void cbTraerPorEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int especialidad = definirEspecialidad(cbTraerPorEspecialidad.SelectedValue.ToString());

            if (especialidad == 0)
            {
                mostrarTodo();
            }
            else
            {
                gridMedicos.DataSource = AdminMedico.Listar(especialidad);
            }

        }
    }
}

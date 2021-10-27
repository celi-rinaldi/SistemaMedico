using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Admin;
using Entidades.Models; 

namespace WebMedicos
{
    public partial class VistaMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                MostrarDatos();
                LlenarCombo();
            }
        }

        private void LlenarCombo()
        {
            DataTable dt = AdminEspecialidad.Listar();
            ddlEspecialidad.DataSource = dt;
            ddlEspecialidad.DataValueField = dt.Columns["Id"].ToString(); 
            ddlEspecialidad.DataTextField = dt.Columns["Nombre"].ToString(); 
            ddlEspecialidad.DataBind();
        }

        private void MostrarDatos()
        {
            gridMedico.DataSource = AdminMedico.Listar();
            gridMedico.DataBind(); 
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                IdEspecialidad = definirEspecialidad(ddlEspecialidad.SelectedItem.ToString()),
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text)
            };
            int filasAfectadas = AdminMedico.Crear(medico);
            if(filasAfectadas > 0)
            {
                MostrarDatos();
            }
        }

        private int definirEspecialidad(string especialidad)
        {
            int numero = 0;
           switch(especialidad)
            {
                case "Clinica":  numero = 1;
                    break;
                case "Pediatria": numero = 2;
                    break;
            }
            return numero;
        }

        protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrueba.Text = ddlEspecialidad.SelectedItem.ToString();
            int idEspecialidad = definirEspecialidad(ddlEspecialidad.SelectedItem.ToString());
            gridMedico.DataSource = AdminMedico.Listar(idEspecialidad);
            gridMedico.DataBind();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Medico m = new Medico()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text),
                IdEspecialidad = definirEspecialidad(ddlEspecialidad.SelectedItem.ToString())

            };
            int filasAfectadas = AdminMedico.Modificar(m); 
            if(filasAfectadas > 0)
            {
                MostrarDatos(); 
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int filasAfectadas = AdminMedico.Eliminar(id);
            if(filasAfectadas > 0)
            {
                MostrarDatos();
            }
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
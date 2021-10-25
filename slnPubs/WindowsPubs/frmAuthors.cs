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
using Datos.Servidor;

namespace WindowsPubs
{
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            mostrarAutores();
            llenarComboCiudades();
        }
        private void llenarComboCiudades()
        {
            DataTable Ciudad = AdmAuthor.ListarDataTable();
            cbCiudad.DataSource = Ciudad; 
            cbCiudad.DisplayMember = Ciudad.Columns["City"].ToString();
            cbCiudad.ValueMember = Ciudad.Columns["City"].ToString();
            DataRow fila = Ciudad.NewRow();
            fila["City"] = "[TODAS]"; 
            Ciudad.Rows.InsertAt(fila, 0); 
        }

        private void btnBuscarPorCity_Click(object sender, EventArgs e)
        {
            gridAuthors.DataSource = AdmAuthor.Listar(txtCity.Text);
        }
        private void mostrarAutores()
        {
            gridAuthors.DataSource = AdmAuthor.Listar();
        }
 
        private void btnCityAndState_Click(object sender, EventArgs e)
        {
            gridAuthors.DataSource = AdmAuthor.Listar(txtCity.Text, txtState.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            mostrarAutores();
        }

        private void cbCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ciudad = cbCiudad.SelectedValue.ToString();
            if(ciudad == "[TODAS]")
            {
                mostrarAutores();
            }
            else
            {
                gridAuthors.DataSource = AdmAuthor.ListarDataTable(ciudad); 
            }
        }
    }
}

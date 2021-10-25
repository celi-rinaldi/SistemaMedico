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

namespace WindowsPubs
{
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar(); 
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar();
        }

        private void btnSortByCity_Click(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar(txtCity.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar(txtCity.Text, txtState.Text);
        }

        private void btnCityStateCountry_Click(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar(txtCity.Text, txtState.Text, txtState.Text);
        }
    }
}

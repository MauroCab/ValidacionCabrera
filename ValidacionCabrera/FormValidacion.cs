using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidacionCabrera.BE;

namespace ValidacionCabrera
{
    public partial class FormValidacion : Form
    {
        public FormValidacion()
        {
            InitializeComponent();
            lblResultado.Hide();
        }

        
        private void tbxPatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btIngresarPatente_Click_1(object sender, EventArgs e)
        {
            lblResultado.Show();
            Validacion val = new Validacion();
            if (val.ValidarPatente(tbxPatente.Text))
            {
                lblResultado.Text = "La patente ingresada es: Válida";
            }
            else
            {
                lblResultado.Text = "La patente ingresada es: Inválida";
            }
        }

        private void btIngresarCUIL_Click(object sender, EventArgs e)
        {
            Validacion val = new Validacion();
            lblDNI.Text = val.DevolverDNI(mtbxCUIL);

        }
    }
}

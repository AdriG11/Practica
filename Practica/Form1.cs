using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        Empleado myEmployee = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                error1.SetError(txtNombre, "Debe de ingresar un NOMBRE");
                txtNombre.Focus();
                return; 
            }
            error1.SetError(txtNombre, "");

            //Validacion para solo ingresar numeros
            decimal AsignacionDia;
            if (!Decimal.TryParse(txtAsignacionDia.Text, out AsignacionDia))
            {
                error1.SetError(txtAsignacionDia, "Debe de ingresar un NUMERO");
                txtAsignacionDia.Focus();
                return;
            }
            error1.SetError(txtAsignacionDia, "");


            myEmployee.Nombre = txtNombre.Text;
            myEmployee.Identificacion = txtIdentificacion.Text;
            myEmployee.AsignacionDia = Convert.ToDecimal(txtAsignacionDia.Text);
            myNomina.DiasLaborados = Convert.ToInt32(txtDiasLab.Text);
            MessageBox.Show("SE GUARDO EL REGISTRO CORRECTAMENTE");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtValorTd.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados), Convert.ToDecimal(myEmployee.AsignacionDia)).ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsignacionDia.Clear();
            txtDiasLab.Clear();
            txtValorTd.Clear();
        }
    }
}

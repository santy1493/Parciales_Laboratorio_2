using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;


namespace Vista
{
    public partial class FormEmpleados : FormMenu
    {
        public FormEmpleados()
            :base()
        {
            InitializeComponent();
        }

        public FormEmpleados(Empleado empleado)
            : base(empleado)
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if(ValidarSinVacios())
            {
                if(Empleado.CargarEmpleado(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtLegajo.Text, this.txtUser.Text, this.txtPass.Text))
                {
                    MessageBox.Show("ALTA DE EMPLEADO EXITOSA");
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos!!");
                }

                BorrarTextBox();
                LlenarGrilla();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }  

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int legajo;

            if(!(string.IsNullOrEmpty(txtLegajoBuscar.Text)) && int.TryParse(txtLegajoBuscar.Text, out legajo))
            {
                Empleado empleado = Empleado.BuscarEmpleadoPorLegajo(legajo);

                this.lblDatosEmpleado.Text = empleado.Mostrar();
            }

        }

        private void LlenarGrilla()
        {
            dtgvEmpleados.Rows.Clear();

            int n;

            foreach (Empleado empleado in Negocio.ListaEmpleados)
            {
                n = dtgvEmpleados.Rows.Add();

                dtgvEmpleados.Rows[n].Cells[0].Value = empleado.Legajo;
                dtgvEmpleados.Rows[n].Cells[1].Value = empleado.Apellido + " " + empleado.Nombre;
                dtgvEmpleados.Rows[n].Cells[2].Value = empleado.Cuil;
                dtgvEmpleados.Rows[n].Cells[3].Value = empleado.Usuario;

            }

        }

        private void BorrarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCuil.Text = string.Empty;
            txtLegajo.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private bool ValidarSinVacios()
        {
            if (!string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtLegajo.Text)
                && !string.IsNullOrEmpty(this.txtUser.Text) && !string.IsNullOrEmpty(this.txtCuil.Text) && !string.IsNullOrEmpty(this.txtPass.Text))
            {
                return true;
            }

            return false;
        }
    }
}

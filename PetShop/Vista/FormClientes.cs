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
    public partial class FormClientes : FormMenu
    {
        public FormClientes()
            : base()
        {
            InitializeComponent();
        }

        public FormClientes(Empleado empleado)
            : base(empleado)
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarSinVacios())
            {
                if(Cliente.CargarCliente(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtId.Text, this.txtSaldo.Text))
                    MessageBox.Show("ALTA DE CLIENTE EXITOSA");
                else
                {
                    MessageBox.Show("Campos incorrectos");
                }


                BorrarTextBox();
                LlenarGrilla();
            }

            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }


        }

        private void LlenarGrilla()
        {
            dtgvClientes.Rows.Clear();

            int n;

            foreach (Cliente cliente in Negocio.ListaClientes)
            {
                n = dtgvClientes.Rows.Add();

                dtgvClientes.Rows[n].Cells[0].Value = cliente.Id;
                dtgvClientes.Rows[n].Cells[1].Value = cliente.Apellido + " " + cliente.Nombre;
                dtgvClientes.Rows[n].Cells[2].Value = cliente.Cuil;
                dtgvClientes.Rows[n].Cells[3].Value = cliente.Saldo;

            }

        }

        private void BorrarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCuil.Text = string.Empty;
            txtId.Text = string.Empty;
            txtSaldo.Text = string.Empty;
        }

        private bool ValidarSinVacios()
        {
            if(!string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtId.Text)
                && !string.IsNullOrEmpty(this.txtSaldo.Text) && !string.IsNullOrEmpty(this.txtCuil.Text))
            {
                return true;
            }

            return false;
        }
    }
}

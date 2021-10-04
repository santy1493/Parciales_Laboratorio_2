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
    public partial class FormMenu : Form
    {

 
        public FormMenu()
        {
            InitializeComponent();
        }

        public FormMenu(Empleado empleado)
            :this()
        {
            this.lblDatosUser.Text = Empleado.DatosPorEmpleado(empleado);
            this.btnEmpleados.Enabled = empleado.Admin;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados(Negocio.empleadoLogeado);
            formEmpleados.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(Negocio.empleadoLogeado);
            formClientes.Show();
            this.Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos(Negocio.empleadoLogeado);
            formProductos.Show();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas(Negocio.empleadoLogeado);
            formVentas.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu(Negocio.empleadoLogeado);
            formMenu.Show();
            this.Close();
        }
    }
}

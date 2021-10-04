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
    public partial class FormProductos : FormMenu
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        public FormProductos(Empleado empleado)
            : base(empleado)
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if(ValidarSinVacios())
            {
                if(Producto.CargarProducto(this.txtNombre.Text, this.txtMarca.Text, this.txtCodigo.Text, this.txtPrecio.Text, this.txtStock.Text, ETipoProducto.Otros))
                {
                    MessageBox.Show("ALTA DE PRODUCTO EXITOSA");  
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos");
                }
                BorrarTextBox();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
                
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            dtgvProductos.Rows.Clear();

            int n;

            foreach (Producto producto in Negocio.ListaProductos)
            {
                n = dtgvProductos.Rows.Add();

                dtgvProductos.Rows[n].Cells[0].Value = producto.Codigo;
                dtgvProductos.Rows[n].Cells[1].Value = producto.Nombre;
                dtgvProductos.Rows[n].Cells[2].Value = producto.Marca;
                dtgvProductos.Rows[n].Cells[3].Value = producto.Precio;
                dtgvProductos.Rows[n].Cells[4].Value = producto.Stock;
                dtgvProductos.Rows[n].Cells[5].Value = producto.Tipo;

            }

        }

        private void BorrarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            cmbTipo.Items.Clear();
        }

        private bool ValidarSinVacios()
        {
            if (!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtMarca.Text) && !string.IsNullOrEmpty(this.txtCodigo.Text)
                && !string.IsNullOrEmpty(this.txtPrecio.Text) && !string.IsNullOrEmpty(this.txtStock.Text))
            {
                return true;
            }

            return false;
        }
    }
}

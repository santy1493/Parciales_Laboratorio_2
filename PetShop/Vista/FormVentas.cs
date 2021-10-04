using Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormVentas : FormMenu
    {
        public FormVentas()
            : base()
        {
            InitializeComponent();
        }

        public FormVentas(Empleado empleado)
            : base(empleado)
        {
            InitializeComponent();
            LlenarGrilla();
            dtgvCarrito.Rows.Clear();
        }

        private Cliente clienteComprando;
        private List<Producto> productosComprados = new List<Producto>();

        private void LlenarGrilla()
        {
            dtgvClientes.Rows.Clear();

            int n;

            foreach (Cliente cliente in Negocio.ListaClientes)
            {
                n = dtgvClientes.Rows.Add();

                dtgvClientes.Rows[n].Cells[0].Value = cliente.Id;
                dtgvClientes.Rows[n].Cells[1].Value = cliente.Apellido + " " + cliente.Nombre;
                dtgvClientes.Rows[n].Cells[2].Value = cliente.Saldo;

            }

            dtgvProductos.Rows.Clear();

            foreach (Producto producto in Negocio.ListaProductos)
            {
                n = dtgvProductos.Rows.Add();

                dtgvProductos.Rows[n].Cells[0].Value = producto.Codigo;
                dtgvProductos.Rows[n].Cells[1].Value = producto.Nombre;
                dtgvProductos.Rows[n].Cells[2].Value = producto.Tipo;
                dtgvProductos.Rows[n].Cells[3].Value = producto.Precio;
                dtgvProductos.Rows[n].Cells[4].Value = producto.Stock;

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo;
            int cantidad;
            Producto producto;

            if (int.TryParse(txtCodigo.Text, out codigo) && int.TryParse(txtCantidad.Text, out cantidad))
            {
                producto = Producto.BuscarProductoPorCod(codigo);

                if (producto != null && producto >= cantidad)
                {
                    producto.cantVenta = cantidad;
                    productosComprados.Add(producto);
                    MessageBox.Show("Producto Agregado");
                    LlenarGrillaCarrito(producto);


                }
                else
                {
                    MessageBox.Show("No se pudo agregar el producto");
                    BorrarTextBoxProducto();
                }

            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto");
                BorrarTextBoxProducto();
            }

        }

        private void LlenarGrillaCarrito(Producto producto)
        {
            int n = dtgvCarrito.Rows.Add();

            dtgvCarrito.Rows[n].Cells[0].Value = producto.Codigo;
            dtgvCarrito.Rows[n].Cells[1].Value = producto.Nombre;
            dtgvCarrito.Rows[n].Cells[2].Value = producto.Precio;
            dtgvCarrito.Rows[n].Cells[3].Value = producto.cantVenta;
            dtgvCarrito.Rows[n].Cells[4].Value = producto.cantVenta * producto.Precio;

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            int id;
            Cliente cliente;

            if (int.TryParse(txtId.Text, out id))
            {
                cliente = Cliente.BuscarClientePorId(id);

                if (cliente != null)
                {
                    clienteComprando = cliente;
                    MessageBox.Show("Se cargo cliente");
                    this.lblCliente.Text = cliente.DatosPorCliente();
                }
                else
                {
                    MessageBox.Show("Id de cliente incorrecta");
                }

            }
            else
            {
                MessageBox.Show("No se pudo cargar cliente");
            }

            this.txtId.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            double precioTotal = 0;

            if (productosComprados.Count > 0 && !(clienteComprando is null))
            {
                foreach (Producto p in productosComprados)
                {
                    precioTotal += p.Precio * p.cantVenta;
                }

                if (clienteComprando.Saldo >= precioTotal)
                {
                    MessageBox.Show("Venta exitosa precio total: " + precioTotal + "saldo cliente: " + clienteComprando.Saldo);
                    Cliente.ActualizarSaldo(clienteComprando, precioTotal);
                    Negocio.ActualizarStock();
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");                   
                }
            }

            else
            {
                MessageBox.Show("No se pudo realizar operacion");
            }

            LlenarGrilla();
            BorrarTextBoxProducto();
            lblCliente.Text = string.Empty;
            dtgvCarrito.Rows.Clear();
            clienteComprando = null;
            productosComprados.Clear();
            Negocio.RestablecerCantVentas();

        }

        public string DatosProducto()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto p in productosComprados)
            {

                sb.AppendLine($"Nombre: {p.Nombre}");
                sb.AppendLine($"Marca: {p.Marca}");
                sb.AppendLine($"Codigo: {p.Codigo}");
                sb.AppendLine($"Precio: {p.Precio}");
                sb.AppendLine($"Stock: {p.Stock}");

            }

            return sb.ToString();
        }

        private void BorrarTextBoxProducto()
        {
            txtCodigo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }
    }
}

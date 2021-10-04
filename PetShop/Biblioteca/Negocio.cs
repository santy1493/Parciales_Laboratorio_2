using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class Negocio
    {
        public static Empleado empleadoLogeado;
        static List<Empleado> listaEmpleados;
        static List<Cliente> listaClientes;
        static List<Producto> listaProductos;

        public static List<Empleado> ListaEmpleados
        {
            get
            {
                return listaEmpleados;
            }

            set
            {
                listaEmpleados = value;
            }
        }

        public static List<Producto> ListaProductos
        {
            get
            {
                return listaProductos;
            }

            set
            {
                listaProductos = value;
            }
        }

        public static List<Cliente> ListaClientes
        {
            get
            {
                return listaClientes;
            }

            set
            {
                listaClientes = value;
            }
        }

        static Negocio()
        {
            listaEmpleados = new List<Empleado>()
            {
                new Empleado("Roberto", "Molina", 20195474332, 2834, "robmolina", "banana", true),
                new Empleado("Luciano", "Herrera", 20173434425, 1944, "lucherrera", "manzana", false),
            };

            listaClientes = new List<Cliente>()
            {
                new Cliente("Mariano", "Rodriguez", 20374532217, 1, 32544.33),
                new Cliente("Sofia", "Gonzalez", 27186565343, 2, 45543.52),
                new Cliente("Jose", "Hernandez", 22356565343, 3, 78443.15),
                new Cliente("Antonio", "Montana", 23276565343, 4, 1222.52),
                new Cliente("Juliana", "Awada", 24348565343, 5, 54223.52),
            };

            listaProductos = new List<Producto>()
            {
                new Producto("dogui", "Purina", 101, 600, 15, ETipoProducto.Alimento),
                new Producto("hueso", "PetToy", 102, 230, 3, ETipoProducto.Juguete),
                new Producto("collar", "PetChain", 103, 300, 2, ETipoProducto.Correa),
                new Producto("shampoo", "PetShamp", 104, 250, 6, ETipoProducto.Limpieza),
                new Producto("pipeta", "Purina", 105, 400, 9, ETipoProducto.Medicamento),

            };

        }

        public static string GenerarFactura(Cliente c, Producto p, int cantidad)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sr/a {c.Apellido} {c.Nombre}: ");
            sb.AppendLine($"Cant.   Producto                        Precio Unit.");
            sb.AppendLine($"{cantidad}   {p.Nombre}                             {p.Precio}");
            sb.AppendLine($"                                      TOTAL: ${p.Precio * cantidad}");

            return sb.ToString();

        }

        public static bool VentaProducto(Cliente c, Producto p, int cantidad)
        {
            if (cantidad <= p.Stock)
            {
                if (c.Saldo >= p.Precio * cantidad)
                {
                    c.Saldo -= p.Precio * cantidad;
                    return true;
                }
            }

            return false;
        }

        public static void ActualizarStock()
        {
            foreach(Producto p in ListaProductos)
            {
                p.Stock -= p.cantVenta;
                p.cantVenta = 0;
            }
        }

        public static void RestablecerCantVentas()
        {
            foreach (Producto p in ListaProductos)
            {
                p.cantVenta = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        private int id;
        private double saldo;

        public Cliente(string nombre, string apellido, long cuil, int id, double saldo)
            : base(nombre, apellido, cuil)
        {
            this.Id = id;
            this.Saldo = saldo;
        }

        public double Saldo { get => saldo; set => saldo = value; }
        public int Id { get => id; set => id = value; }

        public static bool CargarCliente(string nombre, string apellido, string cuil, string id, string saldo)
        {
            if(ValidarIdSaldo(id,saldo) && ValidarNombreApellidoCuil(nombre,apellido,cuil))
            {
                Cliente nuevoCliente = new Cliente(nombre, apellido, long.Parse(cuil), int.Parse(id), double.Parse(saldo));

                Negocio.ListaClientes.Add(nuevoCliente);

                return true;
            }

            return false;
        }

        public static Cliente BuscarClientePorId(int id)
        {
            Cliente cliente;

            foreach (Cliente c in Negocio.ListaClientes)
            {
                if (id == c.Id)
                {
                    cliente = c;
                    return cliente;
                }

            }

            return null;
        }

        public static void ActualizarSaldo(Cliente cliente, double precio)
        {
            foreach (Cliente c in Negocio.ListaClientes)
            {
                if (c == cliente)
                {
                    c.saldo -= precio;
                }
            }
        }

        public string DatosPorCliente()
        {
            StringBuilder sb = new StringBuilder();

            if (this != null)
            {
                sb.AppendLine($"ID: {this.Id}");
                sb.AppendLine($"Nombre: {this.Nombre}");
                sb.AppendLine($"Apellido: {this.Apellido}");
                sb.AppendLine($"Saldo: {this.Saldo}");

                return sb.ToString();
            }

            return string.Empty;
        }

        private static bool ValidarIdSaldo(string idString, string saldoString)
        {
            int id;
            double saldo;

            if(int.TryParse(idString, out id) && double.TryParse(saldoString, out saldo))
            {
                if (id > 0 && saldo>0)
                    return true;
            }

            return false;

        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (!(c1 is null) && !(c2 is null) && c1.id == c2.id);
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Cliente))
            {
                return false;
            }
            return (this.id == ((Cliente)obj).id);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}

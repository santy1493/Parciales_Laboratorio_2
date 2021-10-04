using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        private int legajo;
        private string usuario;
        private string contrasenia;
        private bool admin;

        public Empleado(string nombre, string apellido, long cuil, int legajo, string usuario, string contrasenia)
            : base(nombre, apellido, cuil)
        {
            this.legajo = legajo;
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
            this.admin = false;
        }

        public Empleado(string nombre, string apellido, long cuil, int legajo, string usuario, string contrasenia, bool admin)
            : this(nombre, apellido, cuil, legajo, usuario, contrasenia)
        {
            this.admin = admin;
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }

            set
            {
                this.legajo = value;
            }
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
            }

            set
            {
                this.usuario = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return this.contrasenia;
            }

            set
            {
                this.contrasenia = value;
            }
        }

        public bool Admin
        {
            get
            {
                return this.admin;
            }

            set
            {
                this.admin = value;
            }
        }

        public static bool ValidarUserPass(string user, string pass)
        {
            foreach (Empleado e in Negocio.ListaEmpleados)
            {
                if (e.usuario == user && e.contrasenia == pass)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidarAdmin(string user)
        {
            foreach (Empleado e in Negocio.ListaEmpleados)
            {
                if (e.usuario == user && e.Admin == true)
                {
                    return true;
                }
            }

            return false;
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Usuario: {this.Usuario}");

            return sb.ToString();
        }

        public static string DatosUsuario(string usuario)
        {

            foreach (Empleado e in Negocio.ListaEmpleados)
            {
                if (e.usuario == usuario)
                {
                    return e.Mostrar();
                }
            }

            return "";

        }

        public static bool CargarEmpleado(string nombre, string apellido, string cuil, string legajo, string usuario, string contrasenia)
        {
            if(ValidarLegajo(legajo) && ValidarNombreApellidoCuil(nombre,apellido,cuil))
            {
                Empleado nuevoEmpleado = new Empleado(nombre, apellido, long.Parse(cuil), int.Parse(legajo), usuario, contrasenia);

                Negocio.ListaEmpleados.Add(nuevoEmpleado);

                return true;
            }

            return false;

        }

        public static string MostrarEmpleadoPorIndice(int indice)
        {
            string datos;

            Empleado empleado = Negocio.ListaEmpleados.ElementAt(indice);

            datos = DatosUsuario(empleado.Usuario);

            return datos;
        }

        public static Empleado BuscarEmpleadoPorUsuario(string user)
        {
            Empleado empleado;

            foreach(Empleado e in Negocio.ListaEmpleados)
            {
                if(user==e.Usuario)
                {
                    empleado = e;
                    return empleado;
                }
                
            }

            return null;           
        }

        public static Empleado BuscarEmpleadoPorLegajo(int legajo)
        {
            foreach(Empleado e in Negocio.ListaEmpleados)
            {
                if (e.legajo == legajo)
                    return e;
            }

            return null;
        }

        private static bool ValidarLegajo(string legajo)
        {
            int legajoInt;

            if (int.TryParse(legajo, out legajoInt))
            {
                if(legajoInt>0)
                    return true;
            }     

            return false;
        }

        public static string DatosPorEmpleado(Empleado e)
        {
            if(!(e is null))
            {
                return e.Mostrar();
            }         

            return string.Empty;
        }
    }
}

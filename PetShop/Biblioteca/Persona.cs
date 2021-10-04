using System.Text.RegularExpressions;
using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private long cuil;

        public Persona(string nombre, string apellido, long cuil)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cuil = cuil;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = value;
            }
        }

        public long Cuil
        {
            get
            {
                return this.cuil;
            }

            set
            {
                this.cuil = value;
            }
        }

        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {p.nombre}");
            sb.AppendLine($"Apellido: {p.apellido}");
            sb.AppendLine($"CUIL: {p.cuil}");

            return sb.ToString();
        }

        public static bool ValidarNombreApellidoCuil(string nombre, string apellido, string cuil)
        {
            Regex Val = new Regex(@"^[a-zA-Z]+$");

            long cuilLong;

            if (Val.IsMatch(nombre) && Val.IsMatch(apellido) && long.TryParse(cuil, out cuilLong))
            {
                if (cuilLong > 1000000000 && cuilLong < 99999999999)
                    return true;
            }

            return false;
        }


    }
}

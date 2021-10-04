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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (Empleado.ValidarUserPass(this.txtUser.Text, this.txtPass.Text))
            {
                Negocio.empleadoLogeado = Empleado.BuscarEmpleadoPorUsuario(this.txtUser.Text);

                if (Empleado.ValidarAdmin(this.txtUser.Text))
                {
                    MessageBox.Show("LOGIN ADMIN");
                    FormMenu form = new FormMenu(Negocio.empleadoLogeado);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("LOGIN EMPLEADO");
                    FormMenu form = new FormMenu(Negocio.empleadoLogeado);
                    form.Show();
                }

                this.Hide();
            }
            else
            {
                this.txtUser.Text = "";
                this.txtPass.Text = "";
                this.lblError.Text = "Usuario o contraseña incorrecto";
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "lucherrera";
            this.txtPass.Text = "manzana";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "robmolina";
            this.txtPass.Text = "banana";
        }
    }
}

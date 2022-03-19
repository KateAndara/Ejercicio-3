using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            UsuarioAcceso usuarioDA = new UsuarioAcceso();
            Usuarios usuario = new Usuarios();

            usuario = usuarioDA.Login(NombretextBox.Text, ClavetextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }
            else if (!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario Inactivo");
                return;
            }
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();

        }
    }
}

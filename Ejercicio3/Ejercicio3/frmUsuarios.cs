using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio3
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        UsuarioAcceso usuarioacceso = new UsuarioAcceso();
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            UsuariosdataGridView.DataSource = usuarioacceso.ListarUsuarios();

        }

    }
}

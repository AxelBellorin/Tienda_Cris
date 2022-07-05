using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRCAplicacion.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != String.Empty && txtContraseña.Text != String.Empty)
            {
                // Verificar datos
                MDITienda.sesionIniciada = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Por favor, llene ambos campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }
    }
}

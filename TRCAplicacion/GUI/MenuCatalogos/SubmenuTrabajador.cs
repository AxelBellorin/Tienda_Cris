using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRCAplicacion.GUI.MenuCatalogos
{
    public partial class SubmenuTrabajador : Form
    {
        public SubmenuTrabajador()
        {
            InitializeComponent();
        }

        private void SubmenuTrabajador_Load(object sender, EventArgs e)
        {
            // Cargar datos en el grid ActualizarGrid();

            cbCargo.Items.Add("Seleccionar");
            cbCargo.SelectedIndex = 0;

            txtBuscar.Focus();
        }

        private void AcualizarGrid()
        { }

        private void Limpiar()
        {
            txtNombres.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            mtbTelefono.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            cbCargo.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != String.Empty)
            {
                // Buscar

                // Busqueda Exitosa
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            else
            {
                btnCancelar.PerformClick();
                MessageBox.Show("Nada para buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = String.Empty;

            gbLlenadoEdicion.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNombres.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != String.Empty &&
                txtApellidos.Text != String.Empty &&
                mtbTelefono.MaskFull &&
                txtDireccion.Text != String.Empty &&
                txtUsuario.Text != String.Empty &&
                cbCargo.SelectedIndex != 0)
            {
                // Guardado exitoso
                MessageBox.Show("Se ha guardado el trabajador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();

                gbLlenadoEdicion.Enabled = false;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombres.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

            gbLlenadoEdicion.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            btnCancelar.PerformClick();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridTrabajador.SelectedRows.Count == 1)
            {

            }

            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // rv
            if (gridTrabajador.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Quieres borrar el producto seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("Producto borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}

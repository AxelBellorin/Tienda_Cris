using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using TRCAplicacion.Controllers.Proveedor;

namespace TRCAplicacion.GUI.MenuCatalogos
{
    public partial class SubmenuProveedor : Form
    {
        ProveedorC objProveedorC = null;
        ProveedorController objProveedorController = null;
        DataTable dt = null;

        public SubmenuProveedor()
        {
            InitializeComponent();
        }

        private void SubmenuProveedor_Load(object sender, EventArgs e)
        {
            // Cargar datos en el grid ActualizarGrid();

            mostrarGridProveedor();

            txtBuscar.Focus();
        }

        private void mostrarGridProveedor()
        {
            dgvProveedor.Rows.Clear();

            objProveedorC = new ProveedorC();
            objProveedorController = new ProveedorController(objProveedorC);

            dt = new DataTable();
            dt = objProveedorController.mostrarProveedor();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvProveedor.Rows.Add(dt.Rows[i][0].ToString(),
                                          dt.Rows[i][1].ToString(),
                                          dt.Rows[i][2].ToString(),
                                          dt.Rows[i][3].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void preInsertarProveedor()
        {
            // Se crea un objeto proveedor
            objProveedorC = new ProveedorC();

            // Se le asignan los valores
            objProveedorC.Nombre = txtNombre.Text;
            objProveedorC.Telefono = mtbTelefono.Text;
            objProveedorC.Direccion = txtDireccion.Text;
            objProveedorC.Ruc = mtbRuc.Text;

            objProveedorController = new ProveedorController(objProveedorC);

            objProveedorController.insertarProveedor();
        }

        private void preActualizarProveedor()
        {
            // Se crea un objeto cliente
            objProveedorC = new ProveedorC();

            // Se le asignan los valores
            objProveedorC.Nombre = txtNombre.Text;
            objProveedorC.Telefono = mtbTelefono.Text;
            objProveedorC.Direccion = txtDireccion.Text;
            objProveedorC.Ruc = mtbRuc.Text;

            objProveedorController = new ProveedorController(objProveedorC);

            objProveedorController.actualizarProveedor(dgvProveedor.SelectedCells[0].Value.ToString());
        }

        private void preEliminarProveedor()
        {
            // Se crea un objeto proveedor
            objProveedorC = new ProveedorC();

            //// Se le asignan los valores
            objProveedorController = new ProveedorController(objProveedorC);

            objProveedorController.eliminarProveedor(dgvProveedor.SelectedCells[0].Value.ToString());
        }

        private void AcualizarGrid()
        { }

        private void llenarControlesParaActualizar()
        {
            txtNombre.Text = dgvProveedor.SelectedCells[0].Value.ToString();
            mtbTelefono.Text = dgvProveedor.SelectedCells[1].Value.ToString();
            txtDireccion.Text = dgvProveedor.SelectedCells[2].Value.ToString();
            mtbRuc.Text = dgvProveedor.SelectedCells[3].Value.ToString();
        }

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
            mtbTelefono.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            mtbRuc.Text = String.Empty;
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

            gbLlenadoEdicion.Text = "Ingresando";
            gbLlenadoEdicion.Enabled = true;

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty &&
                mtbTelefono.MaskFull &&
                mtbRuc.MaskFull &&
                txtDireccion.Text != String.Empty)
            {
                try
                {
                    // Se verifica la operacion: ingresar o editar para invocar al metodo correspondiente
                    if (gbLlenadoEdicion.Text == "Ingresando")
                    {
                        // Guardado exitoso
                        preInsertarProveedor();
                        MessageBox.Show("Se ha guardado el proveedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (gbLlenadoEdicion.Text == "Editando")
                    {
                        preActualizarProveedor();
                        MessageBox.Show("Proveedor editado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Limpiar();

                mostrarGridProveedor();

                gbLlenadoEdicion.Enabled = false;
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

            gbLlenadoEdicion.Enabled = false;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            btnCancelar.PerformClick();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count == 1)
            {
                gbLlenadoEdicion.Text = "Editando";

                llenarControlesParaActualizar();

                gbLlenadoEdicion.Enabled = true;
                txtNombre.Focus();
            }

            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // rv
            if (dgvProveedor.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Quieres borrar el proveedor seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    preEliminarProveedor();
                    MessageBox.Show("Proveedor borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblProveedor_Click(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

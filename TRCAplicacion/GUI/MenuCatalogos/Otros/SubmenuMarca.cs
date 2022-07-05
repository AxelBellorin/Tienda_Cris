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
using TRCAplicacion.Controllers.Marca;

namespace TRCAplicacion.GUI.MenuCatalogos.Otros
{
    public partial class SubmenuMarca : Form
    {
        MarcaC objMarcaC = null;
        MarcaController objMarcaController = null;
        DataTable dt = null;

        public SubmenuMarca()
        {
            InitializeComponent();
        }
        private void mostrarGridMarca()
        {
            dgvMarca.Rows.Clear();

            objMarcaC = new MarcaC();
            objMarcaController = new MarcaController(objMarcaC);

            dt = new DataTable();
            dt = objMarcaController.mostrarMarcas();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvMarca.Rows.Add(dt.Rows[i][1].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void preInsertarMarca()
        {
            // Se crea un objeto marca
            objMarcaC = new MarcaC();

            // Se le asignan los valores
            objMarcaC.Nombre = txtNombre.Text;

            objMarcaController = new MarcaController(objMarcaC);

            objMarcaController.insertarMarca();
        }

        private void preActualizarMarca()
        {
            // Se crea un objeto cargo
            objMarcaC = new MarcaC();

            // Se le asignan los valores
            objMarcaC.Nombre = txtNombre.Text;

            objMarcaController = new MarcaController(objMarcaC);

            objMarcaController.actualizarMarca(dgvMarca.SelectedCells[0].Value.ToString());
        }

        private void preEliminarMarca()
        {
            // Se crea un objeto marca
            objMarcaC = new MarcaC();

            objMarcaController = new MarcaController(objMarcaC);

            objMarcaController.eliminarMarca(dgvMarca.SelectedCells[0].Value.ToString());
        }

        private void SubmenuMarca_Load(object sender, EventArgs e)
        {
            mostrarGridMarca();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando";

            txtBuscar.Text = String.Empty;

            gbLlenadoEdicion.Enabled = true;

            btnGuardarEditar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNombre.Focus();
        }

        private void llenarControlesParaActualizar()
        {
            txtNombre.Text = dgvMarca.SelectedCells[0].Value.ToString();
        }

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                try
                {
                    if (gbLlenadoEdicion.Text == "Ingresando")
                    {
                        preInsertarMarca();
                        // Excepcion marca guardada con anterioridad, aun muestra que se guarda
                        MessageBox.Show("Marca guardada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (gbLlenadoEdicion.Text == "Editando")
                    {
                        preActualizarMarca();

                        MessageBox.Show("Marca editada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    mostrarGridMarca();
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el cargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }

                Limpiar();
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando";

            llenarControlesParaActualizar();

            gbLlenadoEdicion.Enabled = true;
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvMarca.SelectedCells.Count != 0)
            {
                if (MessageBox.Show("¿Quieres borrar la marca seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        preEliminarMarca();

                        MessageBox.Show("Marca borrada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarGridMarca();
                    }

                    catch (Exception Excepcion)
                    {
                        MessageBox.Show("No se ha podido borrar la marca.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //throw;
                    }
                }

                else { MessageBox.Show("Operacion cancelada"); }
            }

            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

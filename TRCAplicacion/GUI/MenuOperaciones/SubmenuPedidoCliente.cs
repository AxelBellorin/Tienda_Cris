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
using TRCAplicacion.Controllers.PedidoCliente;

using TRCAplicacion.Controllers.TipoPago;

namespace TRCAplicacion.GUI.MenuOperaciones
{
    public partial class SubmenuPedidoCliente : Form
    {
        PedidoClienteC objPedidoClienteC = null;
        PedidoClienteController objPedidoClienteController = null;
        DataTable dt = null;

        private struct producto
        {
            public string codigoProducto;
            public int cantidadProducto;
        }

        private List<producto> listaProducto = new List<producto>();

        public SubmenuPedidoCliente()
        {
            InitializeComponent();
        }

        private void SubmenuPedidoCliente_Load(object sender, EventArgs e)
        {
            cbPuntoReunion.Items.Add("(Seleccione");
            cbPuntoReunion.Items.Add("Punto de reunion 1");
            cbPuntoReunion.Items.Add("Punto de reunion 2");
            cbPuntoReunion.Items.Add("Punto de reunion 3");
            cbPuntoReunion.Items.Add("Centro comercial ticuantepe");
            cbPuntoReunion.Items.Add("Centro comercial tipitapa");

            cbTipoPago.Items.Add("Tipo de pago 1");
            cbTipoPago.Items.Add("Tipo de pago 2");
        }

        // Para mostrar el tipo de pago en el combo
        TipoPagoC objTipoPagoC = null;
        TipoPagoController objTipoPagoController = null;
        DataTable dtTipoPago = null;
        private void mostrarTipoPagoComboBox()
        {
            cbTipoPago.Items.Clear();

            objTipoPagoC = new TipoPagoC();
            objTipoPagoController = new TipoPagoController(objTipoPagoC);

            dtTipoPago = new DataTable();
            dtTipoPago = objTipoPagoController.mostrarTipoPago();

            cbTipoPago.Items.Add("(Seleccione)");

            if (dtTipoPago.Rows.Count > 0)
            {
                for (int i = 0; i < dtTipoPago.Rows.Count; i++)
                {
                    cbTipoPago.Items.Add(dtTipoPago.Rows[i][1].ToString());
                }
            }

            cbTipoPago.SelectedIndex = 0;
            // cantidad
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void Limpiar()
        {
            txtCodigoPedido.Text = String.Empty;
            dtpFechaEntrega.Value = DateTime.Now;
            mtbCedula.Text = String.Empty;
            cbPuntoReunion.SelectedIndex = 0;
            cbTipoPago.SelectedIndex = 0;
            txtCodigoProducto.Text = String.Empty;
            nuCantidadProducto.Value = 0;

            txtCodigoPedido.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mostrarTipoPagoComboBox();

            listaProducto.Clear();

            Limpiar();
        }

        private void btnAgregarProductoLista_Click(object sender, EventArgs e)
        {
            if (txtCodigoPedido.Text != String.Empty &&
                // cbEstadoEncargo.SelectedIndex != 0 &&
                mtbCedula.MaskFull &&
                cbPuntoReunion.SelectedIndex != 0 &&
                cbTipoPago.SelectedIndex != 0 &&
                txtCodigoProducto.Text != String.Empty &&
                nuCantidadProducto.Value != 0)
            {
                try
                {
                    producto agregarProducto = new producto();

                    agregarProducto.codigoProducto = txtCodigoProducto.Text;
                    agregarProducto.cantidadProducto = Convert.ToInt32(nuCantidadProducto.Value);

                    // Verifica que no haya producto repetidos
                    bool verificarProductoLista = listaProducto.Any(x => x.codigoProducto == txtCodigoProducto.Text);

                    // true existe
                    // false no existe
                    if (!verificarProductoLista)
                    {
                        listaProducto.Add(agregarProducto);

                        dgvPedidoCliente.Rows.Add(agregarProducto.codigoProducto, agregarProducto.cantidadProducto);
                        lblCantidad.Text = "Hay " + listaProducto.Count.ToString() + " Productos";

                        MessageBox.Show("El pedido del cliente se agrego a la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCodigoProducto.Text = String.Empty;
                        nuCantidadProducto.Value = 0;

                        txtCodigoProducto.Focus();
                    }

                    else
                    {
                        MessageBox.Show("No se ha podido agregar el producto porque ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el pedido del cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // En caso de que exista uno o mas campos vacios
            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Se establece el foco
                txtCodigoProducto.Focus();
            }
        }

        private void verificarPedidoCliente()
        {
            int cuantosProductos = listaProducto.Count;

            if (cuantosProductos > 0)
            {
                for (int i = 0; i < cuantosProductos; i++)
                {
                    if (i == 0)
                    {
                        // Invocamos al metodo
                        preInsertarPedidoCliente(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, true);
                    }

                    else
                    {
                        preInsertarPedidoCliente(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, false);
                    }
                }

                txtCodigoProducto.Focus();
            }

            else
            {
                // sin productos
                MessageBox.Show("No hay productos");
            }
        }

        private void preInsertarPedidoCliente(string codigo_producto, int cantidad_producto, bool band)
        {
            // Se crea un objeto pedido cliente
            objPedidoClienteC = new PedidoClienteC();

            // Se le asignan los valores
            objPedidoClienteC.CodigoPedido = txtCodigoPedido.Text;
            objPedidoClienteC.FechaEntrega = dtpFechaEntrega.Value;
            objPedidoClienteC.Cedula = mtbCedula.Text;
            objPedidoClienteC.PuntoReunion = cbPuntoReunion.Text;
            objPedidoClienteC.TipoPago = cbTipoPago.Text;
            objPedidoClienteC.CodigoProducto = codigo_producto;
            objPedidoClienteC.CantidadProducto = cantidad_producto;
            objPedidoClienteC.Band = band;

            objPedidoClienteController = new PedidoClienteController(objPedidoClienteC);

            objPedidoClienteController.insertarPedidoCliente();
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                verificarPedidoCliente();
                MessageBox.Show("Pedido del cliente guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el pedido del cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCodigoPedido.Text = String.Empty;
            mtbCedula.Text = String.Empty;
            cbTipoPago.SelectedIndex = 0;
            txtCodigoProducto.Text = String.Empty;
            nuCantidadProducto.Value = 0;

            dgvPedidoCliente.Rows.Clear();

            btnNuevo.Focus();
        }
    }
}

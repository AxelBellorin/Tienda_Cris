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
using TRCAplicacion.Controllers.PuntoReunion;

namespace TRCAplicacion.GUI.MenuCatalogos.Otros
{
    public partial class SubmenuPuntoReunion : Form
    {
        PaisC objPaisC = null;
        PaisController objPaisController = null;
        DataTable dtPais = null;

        DepartamentoC objDepartamentoC = null;
        DepartamentoController objDepartamentoController = null;
        DataTable dtDepartamento = null;

        MunicipioC objMunicipioC = null;
        MunicipioController objMunicipioController = null;
        DataTable dtMunicipio = null;

        PuntoReunionC objPuntoReunionC = null;
        PuntoReunionController objPuntoReunionController = null;
        DataTable dtPuntoReunion = null;

        public SubmenuPuntoReunion()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

#region mostrar Pais, Departamento, Municipio, PuntoReunion

        private void mostrarGridPais()
        {
            dgvPais.Rows.Clear();

            objPaisC = new PaisC();
            objPaisController = new PaisController(objPaisC);

            dtPais = new DataTable();
            dtPais = objPaisController.mostrarPaises();

            if (dtPais.Rows.Count > 0)
            {
                for (int i = 0; i < dtPais.Rows.Count; i++)
                {
                    dgvPais.Rows.Add(dtPais.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void mostrarGridDepartamento()
        {
            dgvDepartamento.Rows.Clear();

            objDepartamentoC = new DepartamentoC();
            objDepartamentoController = new DepartamentoController(objDepartamentoC);

            dtDepartamento = new DataTable();
            dtDepartamento = objDepartamentoController.mostrarDepartamentos();

            if (dtDepartamento.Rows.Count > 0)
            {
                for (int i = 0; i < dtDepartamento.Rows.Count; i++)
                {
                    dgvDepartamento.Rows.Add(dtDepartamento.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void mostrarGridMunicipio()
        {
            dgvMunicipio.Rows.Clear();

            objMunicipioC = new MunicipioC();
            objMunicipioController = new MunicipioController(objMunicipioC);

            dtMunicipio = new DataTable();
            dtMunicipio = objMunicipioController.mostrarMunicipios();

            if (dtMunicipio.Rows.Count > 0)
            {
                for (int i = 0; i < dtMunicipio.Rows.Count; i++)
                {
                    dgvMunicipio.Rows.Add(dtMunicipio.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void mostrarGridPuntoReunion()
        {
            dgvPuntoReunion.Rows.Clear();

            objPuntoReunionC = new PuntoReunionC();
            objPuntoReunionController = new PuntoReunionController(objPuntoReunionC);

            dtPuntoReunion = new DataTable();
            objPuntoReunionC.Pais = dgvPais.SelectedCells[0].Value.ToString();
            objPuntoReunionC.Departamento = dgvDepartamento.SelectedCells[0].Value.ToString();
            objPuntoReunionC.Municipio = dgvMunicipio.SelectedCells[0].Value.ToString();
            //objPuntoReunionC.PuntoReunion = null;

            dtPuntoReunion = objPuntoReunionController.mostrarPuntosReunion();

            if (dtPuntoReunion.Rows.Count > 0)
            {
                for (int i = 0; i < dtPuntoReunion.Rows.Count; i++)
                {
                    dgvPuntoReunion.Rows.Add(dtPuntoReunion.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

#endregion


        private void SubmenuPuntoReunion_Load(object sender, EventArgs e)
        {
            mostrarGridPais();
            //mostrarGridDepartamento();
            //mostrarGridMunicipio();
            //mostrarGridPuntoReunion();
        }

        private void cntmOpcionesPuntoReunion_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPais.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo pais";
            }

            if (dgvDepartamento.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo departamento";
            }

            if (dgvMunicipio.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo municipio";
            }

            if (dgvPuntoReunion.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo punto de reunion";
            }
        }

        private void dgvPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarGridDepartamento();
        }

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarGridMunicipio();
        }

        private void dgvMunicipio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarGridPuntoReunion();
        }
    }
}

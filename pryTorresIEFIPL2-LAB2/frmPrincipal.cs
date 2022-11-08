using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresIEFIPL2_LAB2
{
    public partial class frmPrincipal : Form
    {

        public OleDbConnection conexionBase;
        public OleDbCommand comandoQueQuieroDeLaBase;
        public OleDbDataReader lectorDeConsulta;
        string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaClientes objVentanaCargaClientes = new frmCargaClientes();
            objVentanaCargaClientes.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClientes objVentanaConsultaClientes = new frmConsultaClientes();
            objVentanaConsultaClientes.ShowDialog();
        }

        private void listadoTotalClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoClientesPorCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
      
                conexionBase = new OleDbConnection(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    varRutaAccesoBD);

                conexionBase.Open();

                striplblEstado.Text = "Conectado";

                statusPrincipal.BackColor = Color.MediumSeaGreen;
            }
            catch (Exception mensaje)
            {
                striplblEstado.Text = mensaje.Message;

                statusPrincipal.BackColor = Color.Red;

            }
        }

        private void gestionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarCliente objVentanaGestionarCliente = new frmGestionarCliente();
            objVentanaGestionarCliente.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

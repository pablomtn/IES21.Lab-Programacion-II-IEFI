using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresIEFIPL2_LAB2
{
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsCliente objClsClienteMostrarGrilla = new clsCliente();
            objClsClienteMostrarGrilla.Listar(dgvConsultaClientes);
            txtCantidadClientes.Text = (objClsClienteMostrarGrilla.varCantidadDeClientes).ToString();
            txtPromedioSaldos.Text = (objClsClienteMostrarGrilla.varPromedioSaldosDeClientes).ToString("0.00");
            txtTotalSaldos.Text = (objClsClienteMostrarGrilla.varTotalSaldosDeClientes).ToString("0.00");
        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {

        }

        private void mrcListarClientes_Enter(object sender, EventArgs e)
        {

        }
    }
}

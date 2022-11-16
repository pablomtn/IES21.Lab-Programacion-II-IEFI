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
    public partial class frmConsultaClientePorBarrio : Form
    {
        public frmConsultaClientePorBarrio()
        {
            InitializeComponent();
        }

        private void frmConsultaClientePorBarrio_Load(object sender, EventArgs e)
        {
            clsBarrios objClaseBarrio = new clsBarrios();
            objClaseBarrio.LlenarListaDesplegable(lstBarrioConsulta);
            lstBarrioConsulta.SelectedIndex = -1;
            btnImprimir.Enabled = false;
            btnListarPorBarrio.Enabled = false;
            btnReportar.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 varCodigoBarrio = Convert.ToInt32(lstBarrioConsulta.SelectedValue);
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.ListarBarrio(varCodigoBarrio, dgvConsulta);
            if (dgvConsulta.Rows.Count > 1)
            {
                btnImprimir.Enabled = true;
                btnReportar.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
                btnReportar.Enabled = false;
            }

        }

        private void lstBarrioConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBarrioConsulta.SelectedIndex != -1)
            {
                btnListarPorBarrio.Enabled = true;

            }
            btnReportar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            clsCliente objClaseCliente = new clsCliente();
            Int32 CodigoBarrio = Convert.ToInt32(lstBarrioConsulta.SelectedValue);
            objClaseCliente.ReportarBarrio(CodigoBarrio);
            MessageBox.Show("Reporte generado exitosamente");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Ventana que nos permite elegir las impresoras
            prtVentana.ShowDialog();
            //Al objeto documento le asignamos la impresora que se eligio en la ventana de impresoras
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            //Indicamos que el documento se debe imprimir
            //Ejecuta el evento del Documento PrintPage
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso correctamente");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsCliente objClaseCliente = new clsCliente();
            Int32 varCodigoBarrio = Convert.ToInt32(lstBarrioConsulta.SelectedValue);
            objClaseCliente.ImprimirBarrio(e, varCodigoBarrio);
        }
    }
}

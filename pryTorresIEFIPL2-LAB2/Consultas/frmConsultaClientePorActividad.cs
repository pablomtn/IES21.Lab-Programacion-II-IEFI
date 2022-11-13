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
    public partial class frmConsultaClientePorActividad : Form
    {
        public frmConsultaClientePorActividad()
        {
            InitializeComponent();
        }

        private void lstActividadConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActividadConsulta.SelectedIndex != -1)
            { 
                btnListar.Enabled = true;
              
            }
            btnReportar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void frmConsultaClientePorActividad_Load(object sender, EventArgs e)
        {
            clsActividad objClaseCliente = new clsActividad();
            objClaseCliente.LlenarListaDesplegable(lstActividadConsulta);
            lstActividadConsulta.SelectedIndex = -1;
            btnImprimir.Enabled = false;
            btnListar.Enabled = false;
            btnReportar.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 varActividad = 0;
            varActividad = Convert.ToInt32(lstActividadConsulta.SelectedValue);
            clsCliente objClaseActividad = new clsCliente();
            objClaseActividad.ListarActividad(varActividad, dgvConsulta);
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            clsCliente objClaseCliente = new clsCliente();
            Int32 CodigoActividad = Convert.ToInt32(lstActividadConsulta.SelectedValue);
            objClaseCliente.ReportarActividad(CodigoActividad);
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
            Int32 varCodigoActividad = Convert.ToInt32(lstActividadConsulta.SelectedValue);
            objClaseCliente.ImprimirActividad(e, varCodigoActividad);


        }
    }
}

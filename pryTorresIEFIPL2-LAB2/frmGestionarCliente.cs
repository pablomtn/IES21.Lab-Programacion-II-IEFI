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
    public partial class frmGestionarCliente : Form
    {
        public string varSeleccionListaDesplegableBarrio = "";
        public string varSeleccionListaDesplegableActividad = "";
        public frmGestionarCliente()
        {
            InitializeComponent();
        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            clsBarrios objClaseBarriosLst = new clsBarrios();
            objClaseBarriosLst.LlenarListaDesplegable(lstBarrioConsultaCliente);
            lstBarrioConsultaCliente.SelectedIndex = -1;
            clsActividad objClaseActividad = new clsActividad();
            objClaseActividad.LlenarListaDesplegable(lstActividadClienteConsulta);
            lstActividadClienteConsulta.SelectedIndex = -1;
            

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            Int32 varDNI = Convert.ToInt32(mskDniClienteBusqueda.Text);
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.BusquedaCliente(varDNI);

            if (objClaseCliente.varDniDelCliente != varDNI)
            {
                MessageBox.Show("El cliente no se encuentra en la base de datos");
            }
            else
            {
                txtNombreClienteConsulta.Text = objClaseCliente.varNombreDelCliente;
                txtApellidoClienteConsulta.Text = objClaseCliente.varApellidoDelCliente;
                txtDni.Text = Convert.ToString(objClaseCliente.varDniDelCliente);
                clsBarrios objClaseBarrio = new clsBarrios();
                Int32 varCodigoBarrio = objClaseCliente.varBarrioDelCliente;           
                lstBarrioConsultaCliente.SelectedText = objClaseBarrio.Buscar(varCodigoBarrio);
                txtDireccionConsultaCliente.Text = objClaseCliente.varDireccionDelCliente;
                clsActividad objClaseActividad = new clsActividad();
                Int32 varCodigoActividad = objClaseCliente.varActividadDelCliente; 
                lstActividadClienteConsulta.SelectedText = objClaseActividad.Buscar(varCodigoActividad);
                txtSaldoClienteConsulta.Text = Convert.ToString(objClaseCliente.varSaldoDelCliente);

              
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 varDNI = Convert.ToInt32(mskDniClienteBusqueda.Text);
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.varBarrioDelCliente = Convert.ToInt32(lstBarrioConsultaCliente.SelectedValue);
            objClaseCliente.varDireccionDelCliente = txtDireccionConsultaCliente.Text;
            objClaseCliente.varActividadDelCliente = Convert.ToInt32(lstActividadClienteConsulta.SelectedValue);
            objClaseCliente.varSaldoDelCliente = Convert.ToDecimal(txtSaldoClienteConsulta.Text);
            objClaseCliente.Modificar(varDNI);

        }
        private void HabilitarControles()
        {

            lstBarrioConsultaCliente.Enabled = true;
            lstActividadClienteConsulta.Enabled = true;
            txtDni.ReadOnly = false;
            txtSaldoClienteConsulta.ReadOnly = false;
            txtDireccionConsultaCliente.ReadOnly = false;
        }
    }
}

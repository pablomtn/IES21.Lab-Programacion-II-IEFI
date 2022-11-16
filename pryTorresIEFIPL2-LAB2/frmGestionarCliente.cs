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
            
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            Int32 varDNI = Convert.ToInt32(mskDniClienteBusqueda.Text);
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.BusquedaCliente(varDNI);

            if (objClaseCliente.varDniDelCliente != varDNI)
            {
                MessageBox.Show("El cliente no se encuentra en la base de datos");
                btnEliminar.Enabled=false;
                btnModificar.Enabled = false;
                mskDniClienteBusqueda.Text = "";
            }
            else
            {
                txtNombreClienteConsulta.Text = objClaseCliente.varNombreDelCliente;
                txtApellidoClienteConsulta.Text = objClaseCliente.varApellidoDelCliente;
                mskDniConsulta.Text = Convert.ToString(objClaseCliente.varDniDelCliente);
                clsBarrios objClaseBarrio = new clsBarrios();
                Int32 varCodigoBarrio = objClaseCliente.varBarrioDelCliente;           
                lstBarrioConsultaCliente.Text = objClaseBarrio.Buscar(varCodigoBarrio);
                txtDireccionConsultaCliente.Text = objClaseCliente.varDireccionDelCliente;
                clsActividad objClaseActividad = new clsActividad();
                Int32 varCodigoActividad = objClaseCliente.varActividadDelCliente; 
                lstActividadClienteConsulta.Text = objClaseActividad.Buscar(varCodigoActividad);
                txtSaldoClienteConsulta.Text = Convert.ToString(objClaseCliente.varSaldoDelCliente);

              
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
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
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;


        }
        private void HabilitarControles()
        {

            lstBarrioConsultaCliente.Enabled = true;
            lstActividadClienteConsulta.Enabled = true;
            txtSaldoClienteConsulta.ReadOnly = false;
            txtDireccionConsultaCliente.ReadOnly = false;
 
        }
      

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 varDNI = Convert.ToInt32(mskDniClienteBusqueda.Text);
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.Eliminar(varDNI);
            LimpiarControles();
            mskDniClienteBusqueda.Text = "";
        }
        private void LimpiarControles()
        {
            txtApellidoClienteConsulta.Text = "";
            txtNombreClienteConsulta.Text = "";
            mskDniClienteBusqueda.Text = "";
            txtSaldoClienteConsulta.Text = "";
            lstActividadClienteConsulta.SelectedIndex = -1;
            lstBarrioConsultaCliente.SelectedIndex = -1;
            txtDireccionConsultaCliente.Text = "";
        }

        private void lstBarrioConsultaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskDniClienteBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (mskDniClienteBusqueda.Text != "")
            {
                btnBuscarCliente.Enabled = true;

            }
            else
            {
                btnBuscarCliente.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = false;
                LimpiarControles();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Procedimiento para que no se pueda escribir numeros y caracteres especiales



        private void txtDireccionConsultaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void txtSaldoClienteConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores no permitidos
                e.Handled = true;
            }
        }
    }
}

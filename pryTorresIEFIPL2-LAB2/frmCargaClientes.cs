using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryTorresIEFIPL2_LAB2
{
    public partial class frmCargaClientes : Form
    {
        //Creacion de objetos
        //Nos permite conectar a la base de datos
        public OleDbConnection conexionBd = new OleDbConnection();
        //Con este objeto enviamos una orden a la BD
        public OleDbCommand comandoBd = new OleDbCommand();
        //Nos sirve para adaptar los datos de la BD a datos reconocidos por .NET
        public OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();
        public frmCargaClientes()
        {
            InitializeComponent();
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            clsCliente objClsCliente = new clsCliente();
            objClsCliente.varNombreDelCliente = txtNombreCliente.Text;
            objClsCliente.varApellidoDelCliente =txtApellidoCliente.Text;
            objClsCliente.varDniDelCliente = Convert.ToInt32(mskDniCliente.Text);
            objClsCliente.varBarrioDelCliente = Convert.ToInt32(lstBarrioCliente.SelectedValue);
            objClsCliente.varDireccionDelCliente = txtDireccionCliente.Text;
            objClsCliente.varActividadDelCliente = Convert.ToInt32(lstActividadCliente.SelectedValue);
            objClsCliente.varSaldoDelCliente = Convert.ToDecimal(txtSaldoCliente.Text);
            objClsCliente.Agregar();
            LimpiarControles();
       
        }

        private void lstBarrioCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlarControles();
        }

        private void frmCargaClientes_Load(object sender, EventArgs e)
        {
            clsBarrios objClsBarrios = new clsBarrios();
            objClsBarrios.LlenarListaDesplegable(lstBarrioCliente);
            clsActividad objClsActividad = new clsActividad();
            objClsActividad.LlenarListaDesplegable(lstActividadCliente);
            lstActividadCliente.SelectedIndex = -1;
            lstBarrioCliente.SelectedIndex = -1;


        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            ControlarControles();
        }
        private void LimpiarControles()
        {
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            mskDniCliente.Text = "";
            lstBarrioCliente.SelectedIndex = -1;
            lstActividadCliente.SelectedIndex = -1;
            txtSaldoCliente.Text = "";
            txtDireccionCliente.Text = "";


        }

        private void txtSaldoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
             //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores no permitidos
                e.Handled = true;
            }
        }

        private void lblNombreCliente_Click(object sender, EventArgs e)
        {
            ControlarControles();
        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            ControlarControles();
        }
        public void ControlarControles()
        {
            if (txtNombreCliente.Text != "" && txtApellidoCliente.Text != "" && txtDireccionCliente.Text != "" && mskDniCliente.Text != "" &&
                lstActividadCliente.SelectedIndex != -1 && lstBarrioCliente.SelectedIndex != -1 && txtSaldoCliente.Text != "")
            {
                btnCargarCliente.Enabled = true;
            }
            else
            {
                btnCargarCliente.Enabled=false;
            }


        }

   

        private void mskDniCliente_TextChanged(object sender, EventArgs e)
        {
            ControlarControles();
        }

        private void txtDireccionCliente_TextChanged(object sender, EventArgs e)
        {
            ControlarControles();
        }

        private void lstActividadCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlarControles();
        }

        private void txtSaldoCliente_TextChanged(object sender, EventArgs e)
        {
            ControlarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Procedimiento para que no se pueda escribir numeros y caracteres especiales
        private void Keypress(KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress(e);
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress(e);
        }

        private void txtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }
    }
}

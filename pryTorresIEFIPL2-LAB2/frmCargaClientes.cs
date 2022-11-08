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
        //Ruta de la base de datos
        string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        string varTabla = "Clientes";
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

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

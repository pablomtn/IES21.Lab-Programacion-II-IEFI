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
        }
    }
}

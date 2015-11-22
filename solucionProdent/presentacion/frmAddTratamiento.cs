using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmAddTratamiento : Form
    {
        public frmAddTratamiento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCitasDePaciente frm = new frmBuscarCitasDePaciente();
            frm.ShowDialog();
        }

        private void btnBuscarTratamientos_Click(object sender, EventArgs e)
        {
            frmBuscarTratamiento frm = new frmBuscarTratamiento();
            frm.ShowDialog();
        }
    }
}

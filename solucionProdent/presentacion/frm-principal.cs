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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void menuItemPaciente_Click(object sender, EventArgs e)
        {
            frm_crudPaciente frmCrudPaciente = new frm_crudPaciente();
            frmCrudPaciente.ShowDialog();
        }

        private void frmaddCitaMedica_Click(object sender, EventArgs e)
        {
            frm_addCitaMedica frmCitaMedica = new frm_addCitaMedica();
            frmCitaMedica.ShowDialog();
        }

        private void menuAsignarTratamiento(object sender, EventArgs e)
        {

            frmAddTratamiento frm = new frmAddTratamiento();
            frm.ShowDialog();

        }


    }
}

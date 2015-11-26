using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//referencias
using dominio;
using aplicacion;


namespace presentacion
{
    public partial class frm_principal : Form
    {
        //variables
        static Medico medicoPublico;



        public frm_principal(Medico objMedicoEnviado)
        {
            InitializeComponent();
            medicoPublico = objMedicoEnviado;
            lblMedico.Text = "su nombre es: " + medicoPublico.Nombre + " y su idMedico es: " + medicoPublico.Id.ToString() + " y su idUsuario es" + medicoPublico.Usuario.Id.ToString();
           
        }


        public frm_principal()
        {
            InitializeComponent();

        }



        private void menuItemPaciente_Click(object sender, EventArgs e)
        {
            frm_crudPaciente frm = new frm_crudPaciente();
            frm.Show();

            
            
        }

        private void frmaddCitaMedica_Click(object sender, EventArgs e)
        {
            frm_addCitaMedica frm = new frm_addCitaMedica();
            frm.Show();
        }

        private void menuAsignarTratamiento(object sender, EventArgs e)
        {

            frmAddTratamiento frm = new frmAddTratamiento();
            frm.Show();

        }

        private void pacientesPorMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDePacientesPorMedico frm = new frmReporteDePacientesPorMedico();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }



        public static Medico retornarMedico()
        {
            return medicoPublico;
        }

    }
}

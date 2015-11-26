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
    public partial class Form1 : Form
    {
        private Medico medicoPublico;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            ServicioUsuario servicio = new ServicioUsuario();
            objUsuario.User = txtUser.Text;
            objUsuario.Clave = txtClave.Text;

            objUsuario = servicio.validarLogin(objUsuario);

            if(objUsuario.Id.Equals(0)){
                MessageBox.Show(this, "Usuario y/o clave incorrecto", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                ServicioMedico servicio2 = new ServicioMedico();
                medicoPublico = servicio2.crearInstancia(objUsuario);
                this.Hide();
                
                frm_principal frm = new frm_principal(medicoPublico);
                frm.Show();




            }
        }

        public Medico obtenerMedico()
        {
            return medicoPublico;
        }













    }
}

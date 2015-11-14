using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//referencis
using dominio;
using aplicacion;

namespace presentacion
{
    public partial class frm_crudPaciente : Form
    {
        List<Paciente> listaPacientes = new List<Paciente>();
        public frm_crudPaciente()
        {
            InitializeComponent();
            CargarListadoDePacientes();
            CajasTexto(false);
        }

        private void CargarListadoDePacientes()
        {
            try
            {
                crudPaciente crudPaciente = new crudPaciente();
                listaPacientes = crudPaciente.listarPacientes();
                dataPacientes.Rows.Clear();
                foreach (Paciente paciente in listaPacientes)
                {
                    Object[] fila = { paciente.Nombre, paciente.ApellidoPaterno, paciente.ApellidoMaterno, paciente.Dni};
                    dataPacientes.Rows.Add(fila);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al LISTAR los pacientes disponibles. \n\nIntente de nuevo o verifique con el Administrador.", 
                    "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err.ToString());
            }
        }

        private void CajasTexto(bool a)
        {
            txtNombre.Enabled = a;
            txtApellidoPaterno.Enabled = a;
            txtApellidoMaterno.Enabled = a;
            txtDNI.Enabled = a;
            txtDireccion.Enabled = a;
            txtTelefono.Enabled = a;
            txtCelular.Enabled = a;
            rbFemenino.Enabled = a;
            rbMasculino.Enabled = a;
            txtCorreo.Enabled = a;
            txtFechaNacimiento.Enabled = a;
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CajasTexto(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CajasTexto(false);
        }




    }
}

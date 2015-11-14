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
        Paciente objPaciente = new Paciente();

        public frm_crudPaciente()
        {
            InitializeComponent();
            CargarListadoDePacientes();
            activarCajas(false);
            activaBotones(true,false,false);
            
        }

        private void CargarListadoDePacientes()
        {
            try
            {
                crudPaciente crud = new crudPaciente();
                listaPacientes = crud.listarPacientes();
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

        private void activarCajas(bool a)
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
            //txtFechaNacimiento.Enabled = a;
        }

        private void activaBotones(bool a, bool b, bool c)
        {
            btnNuevo.Enabled = a;
            btnGuardar.Enabled = b;
            btnActualizar.Enabled = c;
            btnEliminar.Enabled = c;
        }

        private void limpiarCajas()
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            //txtFechaNacimiento.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                btnNuevo.Text = "Cancelar";
                limpiarCajas();
                activarCajas(true);
                activaBotones(true,true,false);
            }
            else
            {
                btnNuevo.Text = "Nuevo";
                limpiarCajas();
                activarCajas(false);
                activaBotones(true, false, false);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            objPaciente.Nombre = txtNombre.Text;
            objPaciente.ApellidoPaterno = txtApellidoPaterno.Text;
            objPaciente.ApellidoMaterno = txtApellidoMaterno.Text;
            objPaciente.Dni = txtDNI.Text.Trim();
            objPaciente.Direccion = txtDireccion.Text;
            objPaciente.Telefono = txtTelefono.Text.Trim();
            objPaciente.Celular = txtCelular.Text.Trim();
            objPaciente.Correo = txtCorreo.Text.Trim();
            objPaciente.FechaNacimiento = dtpFechaNacimiento.Value;
            objPaciente.Sexo =  (rbMasculino.Checked)? "M" : "F";



            if (objPaciente.Nombre.Length == 0 || objPaciente.Dni.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el nombre y el dni", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            try
            {
                crudPaciente crud = new crudPaciente();
                registros_afectados = crud.ingresarPaciente(objPaciente);
                if (registros_afectados == 1)
                    MessageBox.Show("El paciente fue creado.", "PRODENT: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El paciente no pudo ser creado, verifique.", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
                CargarListadoDePacientes();
                limpiarCajas();
                //activaBotones(true,false,false);
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar el paciente. \n\nIntente de nuevo o verifique con el Administrador.", "Worker's Health Center: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //System.Console.WriteLine("el tipo de error es "+ err);
            }


        }



    }
}

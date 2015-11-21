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
        List<Paciente> listaDePacientes = new List<Paciente>();
        Paciente objPacienteSeleccionado = new Paciente();

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
                ServicioPaciente crud = new ServicioPaciente();
                listaDePacientes = crud.listarPacientes();
                dataPacientes.Rows.Clear();
                foreach (Paciente paciente in listaDePacientes)
                {
                    Object[] fila = { paciente.Nombre, paciente.ApellidoPaterno, paciente.ApellidoMaterno, paciente.Dni};
                    dataPacientes.Rows.Add(fila);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al LISTAR los pacientes disponibles. \n\nIntente de nuevo o verifique con el Administrador.", 
                    "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> presentacion -> FRM-CRUDPACIENTE -> CARGAR LISTADO DE PACIENTES " + err);
                //Console.WriteLine(err.ToString());
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
            Paciente objPaciente = new Paciente();
            llenarObjetoPaciente(objPaciente);

            if (objPaciente.Nombre.Length == 0 || objPaciente.Dni.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el nombre y el dni", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            try
            {
                ServicioPaciente crud = new ServicioPaciente();
                registros_afectados = crud.ingresarPaciente(objPaciente);
                if (registros_afectados == 1)
                    MessageBox.Show("El paciente fue creado.", "PRODENT: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El paciente no pudo ser creado, verifique.", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarListadoDePacientes();
                limpiarCajas();
                activarCajas(false);
                activaBotones(true, false, false);
                btnNuevo.Text = "nuevo";
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar el paciente. \n\nIntente de nuevo o verifique con el Administrador.", "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> CAPA PRESENTACION -> FRM-CRUDPACIENTE -> btn GUARDAR  " + err);
            }
        }//fin de guardar

        private void llenarObjetoPaciente(Paciente objPaciente)
        {
            objPaciente.Nombre = txtNombre.Text;
            objPaciente.ApellidoPaterno = txtApellidoPaterno.Text;
            objPaciente.ApellidoMaterno = txtApellidoMaterno.Text;
            objPaciente.Dni = txtDNI.Text.Trim();
            objPaciente.Direccion = txtDireccion.Text;
            objPaciente.Telefono = txtTelefono.Text.Trim();
            objPaciente.Celular = txtCelular.Text.Trim();
            objPaciente.Correo = txtCorreo.Text.Trim();
            objPaciente.FechaNacimiento = dtpFechaNacimiento.Value;
            objPaciente.Sexo = (rbMasculino.Checked) ? "M" : "F";
        }


        /*
        private int obtenerIdPacienteSeleccionado()
        {
            //int fila = int.Parse(dataPacientes.CurrentRow.Index.ToString());
            //txtNombre.Text = dataPacientes.CurrentRow.Index.ToString();
            objPacienteSeleccionado = listaDePacientes[int.Parse(dataPacientes.CurrentRow.Index.ToString())];
            return objPacienteSeleccionado.Id;
        }
        */
        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            Paciente objPaciente = new Paciente();
            objPaciente.Id = objPacienteSeleccionado.Id;
            llenarObjetoPaciente(objPaciente);

            if (objPaciente.Nombre.Length == 0 || objPaciente.Dni.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el nombre y el dni", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            try
            {
                ServicioPaciente crud = new ServicioPaciente();
                registros_afectados = crud.modificarPaciente(objPaciente);
                if (registros_afectados == 1){
                    MessageBox.Show("El paciente fue actualizado.", "PRODENT: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListadoDePacientes();
                    limpiarCajas();
                    activarCajas(false);
                    activaBotones(true,false,false);
                }
                else
                    MessageBox.Show("El paciente no pudo ser actualizado, verifique.", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> CAPA PRESENTACION -> FRM-CRUDPACIENTE -> BTN ACTUALIZAR " + err);
                MessageBox.Show(this, "Ocurrio un problema al actualizado el paciente. \n\nIntente de nuevo o verifique con el Administrador.", "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fin de actualizar


        private void dataPacientes_MouseClick(object sender, MouseEventArgs e)
        {
            objPacienteSeleccionado = listaDePacientes[int.Parse(dataPacientes.CurrentRow.Index.ToString())];
            txtNombre.Text = objPacienteSeleccionado.Nombre;
            txtApellidoPaterno.Text = objPacienteSeleccionado.ApellidoPaterno;
            txtApellidoMaterno.Text = objPacienteSeleccionado.ApellidoMaterno;
            txtDNI.Text = objPacienteSeleccionado.Dni;
            txtDireccion.Text = objPacienteSeleccionado.Direccion;
            txtCelular.Text = objPacienteSeleccionado.Celular;
            txtTelefono.Text = objPacienteSeleccionado.Telefono;
            txtCorreo.Text = objPacienteSeleccionado.Correo;
            btnNuevo.Text = "Nuevo";
            activaBotones(true,false,true);
            activarCajas(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            

            DialogResult resultado;
            resultado = MessageBox.Show("Estas seguro que deseas eliminar el registro de: " + objPacienteSeleccionado.Nombre, "PRODENT: Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado == DialogResult.Yes){
                try
                {
                    ServicioPaciente crud = new ServicioPaciente();
                    registros_afectados = crud.eliminarPaciente(objPacienteSeleccionado);
                    if (registros_afectados == 1)
                    {
                        MessageBox.Show("El paciente fue eliminado", "PRODENT: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListadoDePacientes();
                        limpiarCajas();
                        activarCajas(false);
                        activaBotones(true, false, false);
                    }
                    else
                        MessageBox.Show("El paciente no pudo ser eliminado, verifique.", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception err)
                {
                    System.Console.WriteLine("ERROR -> CAPA PRESENTACION -> FRM-CRUDPACIENTE -> BTN ELIMINAR " + err);
                    MessageBox.Show(this, "Ocurrio un problema al actualizado el paciente. \n\nIntente de nuevo o verifique con el Administrador.", "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                limpiarCajas();
                activarCajas(false);
                activaBotones(true,false,false);
            }
        }

        private void frm_crudPaciente_Load(object sender, EventArgs e)
        {

        }



    }//fin de clase
}

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
    public partial class frm_addCitaMedica : Form
    {
        //variables globales
        List<Especialidad> listaDeEspecialidades = new List<Especialidad>();
        List<HorarioAtencion> listaDeHorarios = new List<HorarioAtencion>();
        Paciente objPacienteSeleccionado = new Paciente();
        HorarioAtencion objHorarioSeleccionado = new HorarioAtencion();

        //------------inicio de constructores
        public frm_addCitaMedica()
        {
            InitializeComponent();
        }

        /*
        public frm_addCitaMedica(Paciente objPacienteEnviado)
        {
            InitializeComponent();
            
            objPacienteSeleccionado = objPacienteEnviado;
            txtNombre.Text = objPacienteSeleccionado.Nombre.ToString();
            txtApellido.Text = objPacienteSeleccionado.ApellidoPaterno.ToString() +" "+ objPacienteSeleccionado.ApellidoMaterno.ToString();
            txtDNI.Text = objPacienteSeleccionado.Dni.ToString();
        }*/

        //---------------fin de constructores
        
        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad();
            ServicioHorario serviceHA = new ServicioHorario();
            try
            {
                string fecha = txtFecha.Value.ToString("MM/dd/yyyy");
                int posicionCombo = cboEspecialidad.SelectedIndex;
                especialidad = listaDeEspecialidades[posicionCombo];
                listaDeHorarios = serviceHA.listarHorariosDisponibles(fecha, especialidad.Id.ToString() );
                dataHorarioAtencion.Rows.Clear();
                if(listaDeHorarios.Count == 0 || listaDeHorarios == null )
                MessageBox.Show(this, "La lista esta vacia","PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    foreach (HorarioAtencion ha in listaDeHorarios)
                    {
                        Object[] fila = { ha.Medico.Nombre, ha.Inicio, ha.Fin, ha.Consultorio };
                        dataHorarioAtencion.Rows.Add(fila);
                    }
                }
                
            }
            catch (Exception err)
            {
                MostrarMensajeDeError();
                System.Console.WriteLine("ERROR -> presentacion -> FRM-addCitaMedica -> btn Buscar Horario Disponible " + err + "\n");
            }
        }//fin de buscar HORARIO DE ATENCION

        

        


        private void cargarEspecialidades()
        {
            try {
                //ComboBox model = new ComboBox();
                listaDeEspecialidades = new ServicioEspecialidad().listarEspecialidades();
                foreach (Especialidad objEspecialidad in listaDeEspecialidades) {
                    cboEspecialidad.Items.Add(objEspecialidad.Descripcion);
                }
                //cboEspecialidad = model;
            } catch (Exception err) {
                MostrarMensajeDeError();
                System.Console.WriteLine("ERROR -> presentacion -> FRM-addCitaMedica -> CARGAR especialidades " + err + "\n");
            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            
            frmBuscarPaciente frm = new frmBuscarPaciente();
            frm.ShowDialog();
            objPacienteSeleccionado = frm.obtenerPaciente();
            if (objPacienteSeleccionado == null)
                txtNombre.Text = "debe seleccionar un paciente por favor";
            else
            {
                txtNombre.Text = objPacienteSeleccionado.Nombre;
                txtApellido.Text = objPacienteSeleccionado.ApellidoPaterno + " " + objPacienteSeleccionado.ApellidoMaterno;
                txtDNI.Text = objPacienteSeleccionado.Dni;
                cargarEspecialidades();
                btnBuscarHorario.Enabled = true;
            }
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            CitaMedica cita = new CitaMedica();
            ServicioCitaMedica servicio = new ServicioCitaMedica();
            try
            {
                cita.Paciente = objPacienteSeleccionado;
                cita.HorarioAtencion = objHorarioSeleccionado;
                cita.HorarioAtencion.Fecha = txtFecha.Value;
                
                registros_afectados = servicio.ingresarCitaMedica(cita);
                if (registros_afectados >= 1)
                    MessageBox.Show("Su cita medica fue reservada con exito.", "PRODENT: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No puede tener mas de dos citas diarias, verifique.", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                dataHorarioAtencion.Rows.Clear();
                LimpiarCajas();
                btnGuardar.Enabled = false;
                btnBuscarHorario.Enabled = false;
            }
            catch (Exception err)
            {
                MostrarMensajeDeError();
                System.Console.WriteLine("ERROR -> presentacion -> FRM-addCitaMedica -> btn GUARDAR  " + err + "\n");
            }
        }

        private void LimpiarCajas()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
        }

        private void dataHorarioAtencion_MouseClick(object sender, MouseEventArgs e)
        {
            objHorarioSeleccionado = listaDeHorarios[int.Parse(dataHorarioAtencion.CurrentRow.Index.ToString())];
            btnGuardar.Enabled = true;
            
        }


        private void MostrarMensajeDeError()
        {
            MessageBox.Show(this, "Ocurrio un problema interno :( . \n\nIntente de nuevo o verifique con el Administrador.", "PRODENT: Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }







    }
}

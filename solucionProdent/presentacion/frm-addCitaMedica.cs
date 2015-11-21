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


        public frm_addCitaMedica(Paciente objPacienteEnviado)
        {
            InitializeComponent();
            cargarEspecialidades();
            objPacienteSeleccionado = objPacienteEnviado;
            txtNombre.Text = objPacienteSeleccionado.Nombre.ToString();
            txtApellido.Text = objPacienteSeleccionado.ApellidoPaterno.ToString() +" "+ objPacienteSeleccionado.ApellidoMaterno.ToString();
            txtDNI.Text = objPacienteSeleccionado.Dni.ToString();
        }

        //---------------fin de constructores
        
        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            
            try
            {
                dataHorarioAtencion.Rows.Clear();
                string fecha = tpFecha.Value.ToString("dd/MM/yyyy");
                Especialidad especialidad = new Especialidad();
                int posicionCombo = cboEspecialidad.SelectedIndex;
                especialidad = listaDeEspecialidades[posicionCombo];

                txtNombre.Text = especialidad.Id.ToString();

                ServicioHorario serviceHA = new ServicioHorario();
                
                listaDeHorarios = serviceHA.listarHorariosDisponibles(fecha, especialidad.Id.ToString() );
                dataHorarioAtencion.Rows.Clear();
                foreach (HorarioAtencion ha in listaDeHorarios)
                {
                    Object[] fila = { ha.Medico.Nombre, ha.Inicio, ha.Fin, ha.Consultorio };
                    dataHorarioAtencion.Rows.Add(fila);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al LISTAR los horarios disponibles. \n\nIntente de nuevo o verifique con el Administrador.",
                    "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                System.Console.WriteLine("ERROR -> presentacion -> FRM-addCitaMedica -> CARGAR especialidades " + err + "\n");
            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            
            frm_buscarPaciente frm = new frm_buscarPaciente();
            frm.ShowDialog();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            CitaMedica cita = new CitaMedica();
            cita.Paciente = objPacienteSeleccionado;
            cita.HorarioAtencion = objHorarioSeleccionado;
            try
            {
                ServicioCitaMedica servicio = new ServicioCitaMedica();
                registros_afectados = servicio.ingresarCitaMedica(cita);
                if (registros_afectados == 1)
                    MessageBox.Show("Su cita medica fue reservada con exito.", "PRODENT: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Su cita medica NO fue reservada, verifique.", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar el paciente. \n\nIntente de nuevo o verifique con el Administrador.", "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> presentacion -> FRM-addCitaMedica -> btn GUARDAR  " + err + "\n");
            }
        }

        private void dataHorarioAtencion_MouseClick(object sender, MouseEventArgs e)
        {
            objHorarioSeleccionado = listaDeHorarios[int.Parse(dataHorarioAtencion.CurrentRow.Index.ToString())];
        }










    }
}

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
    public partial class frmReporteDePacientesPorMedico : Form
    {
        //variables globales
        List<CitaMedica> listaDePacientesPorMedico = new List<CitaMedica>();

        List<Medico> listaDeMedicos = new List<Medico>();

        public frmReporteDePacientesPorMedico()
        {
            InitializeComponent();
            CargarMedicos();
        }

        public void CargarMedicos()
        {
            try
            {
                //ComboBox model = new ComboBox();
                listaDeMedicos = new ServicioMedico().listarMedicos();
                foreach (Medico medico in listaDeMedicos)
                {
                    cboMedico.Items.Add(medico.Nombre+" "+medico.ApellidoPaterno+" "+medico.ApellidoMaterno);
                }
                //cboEspecialidad = model;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> presentacion -> frmReporteDePacientesPorMedico -> CARGAR medicos " + err + "\n");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("MM/dd/yyyy");
            
            Medico medico = new Medico();
            int posicionCombo = cboMedico.SelectedIndex;
            medico = listaDeMedicos[posicionCombo];
            string  idMedico = medico.Id.ToString();

            
            try
            {
                ServicioCitaMedica servicio = new ServicioCitaMedica();
                listaDePacientesPorMedico = servicio.LisrarPacientesPorDoctor(idMedico, fecha);
                dataPacientes.Rows.Clear();
                if(listaDePacientesPorMedico.Count == 0 || listaDePacientesPorMedico == null )
                    MessageBox.Show(this, "La lista esta vacia","PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else{
                    foreach (CitaMedica cm in listaDePacientesPorMedico)
                {
                    Object[] fila = { cm.Paciente.Nombre, cm.Paciente.ApellidoPaterno, cm.Paciente.ApellidoMaterno, cm.HorarioAtencion.Inicio, cm.HorarioAtencion.Fin };
                    dataPacientes.Rows.Add(fila);
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("MM/dd/yyyy");
            //.Value.Date
            //string fecha = dtpFecha.Value.Date.ToString();
            btntest.Text = fecha;
        }
    }
}

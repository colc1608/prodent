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
    public partial class frmBuscarCitasDePaciente : Form
    {
        //Variables globales
        List<CitaMedica> listaDeCitasMedicas = new List<CitaMedica>();
        public CitaMedica objCitaMedicaSeleccionada = new CitaMedica();
        Medico medico;



        public frmBuscarCitasDePaciente()
        {
            InitializeComponent();
            medico = frm_principal.retornarMedico();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            ServicioCitaMedica servicio = new ServicioCitaMedica();
            try
            {
                listaDeCitasMedicas = servicio.ListarCitasDelDia(medico);
                dataCitaMedica.Rows.Clear();
                if(listaDeCitasMedicas.Count() == 0){
                    MessageBox.Show(this, "Hoy usted no tiene citas, vayase a su casa xD", "PRODENT: Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach (CitaMedica cm in listaDeCitasMedicas)
                {
                    Object[] fila = { cm.Paciente.Nombre, cm.Paciente.ApellidoPaterno, cm.Paciente.ApellidoMaterno, cm.HorarioAtencion.Inicio, cm.HorarioAtencion.Fin };
                    dataCitaMedica.Rows.Add(fila);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al LISTAR los pacientes disponibles. \n\nIntente de nuevo o verifique con el Administrador.",
                    "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> presentacion -> FRM-CRUDPACIENTE -> CARGAR LISTADO DE PACIENTES " + err +"\n\n");

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmAddTratamiento frm = new frmAddTratamiento(objCitaMedicaSeleccionada);
            //frm.ShowDialog();
            
        }

        private void dataCitaMedica_MouseClick(object sender, MouseEventArgs e)
        {
            objCitaMedicaSeleccionada = listaDeCitasMedicas[int.Parse(dataCitaMedica.CurrentRow.Index.ToString())];
        }
    }
}

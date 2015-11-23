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
    public partial class frmBuscarPaciente : Form
    {
        //variables globales
        private List<Paciente> listaDePacientes = new List<Paciente>();
        private Paciente objPacienteSeleccionado ;

        public Paciente obtenerPaciente()
        {
            return objPacienteSeleccionado;
        }


        public frmBuscarPaciente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cboTipo.SelectedItem.ToString();
                string valor = txtValor.Text;
                ServicioPaciente servicio = new ServicioPaciente();
                listaDePacientes = servicio.BuscarPacientes(tipo,valor);
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
                
            }
        }

        private void dataPacientes_MouseClick(object sender, MouseEventArgs e)
        {
            objPacienteSeleccionado = listaDePacientes[int.Parse(dataPacientes.CurrentRow.Index.ToString())];

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frm_addCitaMedica frm = new frm_addCitaMedica(objPacienteSeleccionado);
            frm.ShowDialog();
            //this.Close();
        }



    }
}

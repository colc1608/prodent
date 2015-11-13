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
        public frm_crudPaciente()
        {
            InitializeComponent();
            CargarListadoDePacientes();

        }
        private void CargarListadoDePacientes()
        {
            try
            {
                crudPaciente crudPaciente = new crudPaciente();
                List<Paciente> listaPacientes = crudPaciente.listarPacientes();
                dataPacientes.Rows.Clear();
                foreach (Paciente paciente in listaPacientes)
                {
                    Object[] fila = { paciente.Id, paciente.Nombre, paciente.ApellidoPaterno, paciente.ApellidoMaterno, 
                                              paciente.Dni, paciente.Direccion, paciente.Telefono , paciente.Celular, 
                                              paciente.Sexo, paciente.Correo, paciente.FechaNacimiento, paciente.Estado};
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
    }
}

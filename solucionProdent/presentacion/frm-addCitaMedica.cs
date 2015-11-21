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
        public frm_addCitaMedica()
        {
            InitializeComponent();
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            
            try
            {
                string fecha = tpFecha.Value.ToString("dd/MM/yyyy");
                
                
                ServicioHorario serviceHA = new ServicioHorario();
                List<HorarioAtencion> listaDeHorarios = new List<HorarioAtencion>();
                listaDeHorarios = serviceHA.listarHorariosDisponibles(fecha, "1");
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
                System.Console.WriteLine("ERROR -> presentacion -> FRM-CRUDPACIENTE -> CARGAR LISTADO DE PACIENTES " + err);
                //Console.WriteLine(err.ToString());
            }
        }
    }
}

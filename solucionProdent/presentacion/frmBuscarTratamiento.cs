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
    public partial class frmBuscarTratamiento : Form
    {
        //variables globales
        List<Tratamiento> listaDeTratamientos = new List<Tratamiento>();
        Tratamiento objTratamientoSeleccionado = new Tratamiento();


        public frmBuscarTratamiento()
        {
            InitializeComponent();
            CargarListadoDeTratamientos();
        }

        private void CargarListadoDeTratamientos()
        {
            try
            {
                ServicioTratamiento servicio = new ServicioTratamiento();
                listaDeTratamientos = servicio.listarTratamientos();
                dataTratamientos.Rows.Clear();
                foreach (Tratamiento tratamiento in listaDeTratamientos)
                {
                    Object[] fila = { tratamiento.Nombre, tratamiento.Precio };
                    dataTratamientos.Rows.Add(fila);
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmAddTratamiento frm = new frmAddTratamiento(objTratamientoSeleccionado);
            frm.ShowDialog();
            this.Close();
        }

        private void dataTratamientos_MouseClick(object sender, MouseEventArgs e)
        {
            objTratamientoSeleccionado = listaDeTratamientos[int.Parse(dataTratamientos.CurrentRow.Index.ToString())];
        }


    }//fin de clase
}

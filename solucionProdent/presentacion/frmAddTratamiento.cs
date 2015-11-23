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
    public partial class frmAddTratamiento : Form
    {
        //variable global
        Tratamiento objTratamiento = new Tratamiento();
        CitaMedica objCitaMedica = new CitaMedica();
        DetalleCita objDetalleCita = new DetalleCita();
        List<DetalleCita> listaDeDetalleCita = new List<DetalleCita>();



        public frmAddTratamiento()
        {
            InitializeComponent();
        }
        

        public frmAddTratamiento(Tratamiento tratamiento)
        {
            InitializeComponent();
            objTratamiento = tratamiento;
            txtDescripcion.Text = objTratamiento.Nombre+" - "+objTratamiento.Precio;
            
        }

        public frmAddTratamiento(CitaMedica citaMedica)
        {
            InitializeComponent();
            objCitaMedica = citaMedica;
            txtNombrePaciente.Text = objCitaMedica.HorarioAtencion.Medico.Nombre;
            txtFechaCitaMedica.Text= Convert.ToString(objCitaMedica.HorarioAtencion.Fecha.ToString());

        }


        //---------------------------------comienzan metodos de botones o void

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCitasDePaciente frm = new frmBuscarCitasDePaciente();
            frm.ShowDialog();
        }

        private void btnBuscarTratamientos_Click(object sender, EventArgs e)
        {
            frmBuscarTratamiento frm = new frmBuscarTratamiento();
            frm.ShowDialog();
        }

        private void btnAgregarTratamiento(object sender, EventArgs e)
        {
            objDetalleCita.Cantidad = int.Parse(txtCantidad.Text.ToString());
            
            objDetalleCita.CitaMedica = objCitaMedica;
            objDetalleCita.Tratamiento = objTratamiento;
            
            Object[] fila = { objDetalleCita.Tratamiento.Nombre, objDetalleCita.Tratamiento.Precio, objDetalleCita.Cantidad  };
            dataCitaTratamientos.Rows.Add(fila);

            listaDeDetalleCita.Add(objDetalleCita);
            
            //opcionar listar
            
        }


        private void dataCitaConTratamiento_Click(object sender, MouseEventArgs e)
        {

        }
    }
}

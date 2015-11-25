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
        
        List<DetalleCita> listaDeDetalleCita = new List<DetalleCita>();



        public frmAddTratamiento()
        {
            InitializeComponent();
        }


        /*

        public frmAddTratamiento(Tratamiento tratamiento)
        {
            InitializeComponent();
            objTratamiento = tratamiento;
            
            
        }
        
        public frmAddTratamiento(CitaMedica citaMedica)
        {
            InitializeComponent();
            objCitaMedica = citaMedica;
            txtNombrePaciente.Text = objCitaMedica.HorarioAtencion.Medico.Nombre;
            txtFechaCitaMedica.Text= Convert.ToString(objCitaMedica.HorarioAtencion.Fecha.ToString());

        }
        */



        //---------------------------------comienzan metodos de botones o void

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            frmBuscarCitasDePaciente frm = new frmBuscarCitasDePaciente();
            frm.ShowDialog();
            objCitaMedica = frm.objCitaMedicaSeleccionada;
            txtNombrePaciente.Text = objCitaMedica.HorarioAtencion.Medico.Nombre;
            txtFechaCitaMedica.Text = objCitaMedica.HorarioAtencion.Fecha.ToString();

            /*
            frmBuscarCitasDePaciente f2 = new frmBuscarCitasDePaciente(); //creamos un objeto del formulario 2
            DialogResult res = f2.ShowDialog(); //abrimos el formulario 2 como cuadro de dialogo modal

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                this.objCitaMedica = f2.objCitaMedicaSeleccionada; //asignamos al texbox el dato de la variable
            }
            */
        }

        private void btnBuscarTratamientos_Click(object sender, EventArgs e)
        {
            frmBuscarTratamiento frm = new frmBuscarTratamiento();
            frm.ShowDialog();
            this.objTratamiento = frm.objTratamientoSeleccionado;
            txtDescripcion.Text = objTratamiento.Id + " "+ objTratamiento.Nombre + " - " + objTratamiento.Precio;
        }

        private void btnAgregarTratamiento(object sender, EventArgs e)
        {
            DetalleCita objDetalleCita = new DetalleCita();
            objDetalleCita.Cantidad = int.Parse(txtCantidad.Text.ToString());
            objDetalleCita.CitaMedica = objCitaMedica;
            objDetalleCita.Tratamiento = this.objTratamiento;
            
            Object[] fila = { objDetalleCita.Tratamiento.Nombre, objDetalleCita.Tratamiento.Precio, objDetalleCita.Cantidad  };
            dataCitaTratamientos.Rows.Add(fila);

            listaDeDetalleCita.Add(objDetalleCita);
            
            //opcionar listar
            
        }


        

        private void btnGuardar_CLICK(object sender, EventArgs e)
        {
            int registros_afectados;
            ServicioDetalleCita servicio = new ServicioDetalleCita();
            try
            {

                registros_afectados = servicio.ingresarDetalleCita(this.listaDeDetalleCita);
                if (registros_afectados >= 1)
                    MessageBox.Show("Detalle ingresado correctamente", "PRODENT: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al ingresar detalle.", "PRODENT: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar el paciente. \n\nIntente de nuevo o verifique con el Administrador.", "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> CAPA PRESENTACION -> FRM-CRUDPACIENTE -> btn GUARDAR  " + err);
            }
        }
    }
}

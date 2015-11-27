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
        Medico medico;





        public frmAddTratamiento()
        {
            InitializeComponent();
            medico = frm_principal.retornarMedico();
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



        //---------------------------------comienzan metodos

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            frmBuscarCitasDePaciente frm = new frmBuscarCitasDePaciente();
            frm.ShowDialog();
            objCitaMedica = frm.objCitaMedicaSeleccionada;
            if (objCitaMedica.Id == 0 )
                txtNombrePaciente.Text = "no ha seleccionado una cita";
            else
            {
                txtNombrePaciente.Text = objCitaMedica.Paciente.Nombre + " " +objCitaMedica.Paciente.ApellidoPaterno;
                txtDNI.Text = objCitaMedica.Paciente.Dni;
                btnBuscarTratamientos.Enabled = true;
            }
            

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

            if (objTratamiento.Id == 0)
                txtDescripcion.Text = "debe seleccionar un tratamiento";
            else
            {
                btnAgregar.Enabled = true;
                txtCantidad.Enabled = true;
                txtDescripcion.Text = objTratamiento.Id + " " + objTratamiento.Nombre + " - " + objTratamiento.Precio;

            }
                
        }

        private void btnAgregarTratamiento(object sender, EventArgs e)
        {
            DetalleCita objDetalleCita = new DetalleCita();
            Decimal total = 0;

            objDetalleCita.Cantidad = int.Parse(txtCantidad.Text.ToString());
            objDetalleCita.CitaMedica = objCitaMedica;
            objDetalleCita.Tratamiento = this.objTratamiento;
            objDetalleCita.SubTotal = objDetalleCita.Cantidad * objTratamiento.Precio;



            Object[] fila = { objDetalleCita.Tratamiento.Nombre, objDetalleCita.Tratamiento.Precio, objDetalleCita.Cantidad, objDetalleCita.SubTotal };
            dataCitaTratamientos.Rows.Add(fila);

            listaDeDetalleCita.Add(objDetalleCita);


            for (int i = 0; i < listaDeDetalleCita.Count; i++)
                total += listaDeDetalleCita[i].SubTotal;
            
            
            txtTotal.Text = total.ToString();
            
            btnRegistrar.Enabled = true;

            
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

                btnAgregar.Enabled = false;
                btnRegistrar.Enabled = false;
                txtCantidad.Text = "";
                txtCantidad.Enabled = false;
                txtNombrePaciente.Text = "";
                txtDNI.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar el paciente. \n\nIntente de nuevo o verifique con el Administrador.", "PRODENT: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> CAPA PRESENTACION -> FRM-CRUDPACIENTE -> btn GUARDAR  " + err);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencia a otros proyectos
using dominio;
using persistencia;


namespace aplicacion
{
    public class ServicioDetalleCita
    {
        private conexion cn;
        private DetalleCitaDAO dao;


        public ServicioDetalleCita() 
        {
            cn = new conexion();
            dao = new DetalleCitaDAO(cn);
        }


        public int ingresarDetalleCita(List<DetalleCita> detalleCita)
        {
            try
            {
                cn.abrirConexion();
                int r = dao.ingresarDetalle(detalleCita);
                cn.cerrarConexion();
                return r;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> servicio detalle cita -> ingresar " + e + "\n ");
                throw e;
            }
        }//fin de ingresar Paciente







    }//fin de clase
}

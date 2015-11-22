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
    public class ServicioCitaMedica
    {
        private conexion cn;
        private citaMedicaDAO dao;


        public ServicioCitaMedica() 
        {
            cn = new conexion();
            dao = new citaMedicaDAO(cn);
        }


        public int ingresarCitaMedica(CitaMedica citaMedica)
        {
            try
            {
                cn.abrirConexion();
                int r = dao.ingresar(citaMedica);
                cn.cerrarConexion();
                System.Console.WriteLine("el valor de el ENTERO en aplicacion es: "+r);
                return r;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> servicio cita medica -> ingresar " + e + "\n");
                throw e;
            }
        }//fin de ingresar Paciente









    }//fin de clase
}

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
    public class ServicioTratamiento
    {
        private conexion cn;
        private TratamientoDAO dao;


        public ServicioTratamiento() 
        {
            cn = new conexion();
            dao = new TratamientoDAO(cn);
        }

        public List<Tratamiento> listarTratamientos()
        {
            try
            {
                cn.abrirConexion();
                List<Tratamiento> listaDeTratamientos = dao.listarTratamiento();
                cn.cerrarConexion();
                return listaDeTratamientos;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> Servicio tratamiento -> listar " + err + "\n ");
                throw err;
            }
        }


    }
}

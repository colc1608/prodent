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
    public class ServicioEspecialidad
    {

        private conexion cn;
        private especialidadDAO especialidadDAO;


        public ServicioEspecialidad() 
        {
            cn = new conexion();
            especialidadDAO = new especialidadDAO(cn);
        }

        public List<Especialidad> listarEspecialidades()
        {
            try
            {
                cn.abrirConexion();
                List<Especialidad> listaDeEspecialidades = especialidadDAO.listarEspecialidades();
                cn.cerrarConexion();
                return listaDeEspecialidades;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> ServicioEspecialidad -> listar " + err + "\n");
                throw err;
            }
        }






    }//fin de clase
}

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
    public class ServicioHorario
    {
        private conexion cn;
        private horarioAtencionDAO haDAO;

        public ServicioHorario()
        {
            cn = new conexion();
            haDAO = new horarioAtencionDAO(cn);
        }


        public List<HorarioAtencion> listarHorariosDisponibles(string fecha, string especialidad)
        {
            try
            {
                cn.abrirConexion();
                List<HorarioAtencion> listaDeHA = haDAO.listarHorariosDisponibles(fecha, especialidad );
                cn.cerrarConexion();
                return listaDeHA;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> servicio horario -> listar ->" + err +"\n");
                throw err;
            }
        }//fin de listar



    }//fin de clase

}

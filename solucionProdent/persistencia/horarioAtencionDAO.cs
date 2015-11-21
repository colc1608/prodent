using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace persistencia
{
    public class horarioAtencionDAO
    {
        conexion cn;

        public horarioAtencionDAO(conexion cn)
        {
            this.cn = cn;
        }


        public List<HorarioAtencion> listarHorariosDisponibles(string fecha, string especialidad)
        {
            List<HorarioAtencion> listaDeHorariosDisponibles = new List<HorarioAtencion>();
            try
            {
                String sentenciaSQL =   " select m.nombre, ha.inicio, ha.fin, ha.consultorio, m.id as 'idMedico', ha.id as 'idHorario' "
                                        + " from horarioAtencion ha, medico m "
                                        + " where "
                                        + " m.id = ha.idMedico and "
                                        + " m.idespecialidad = " + especialidad + " and "
                                        + " ha.fecha = ' " + fecha + " ' and "
                                        + " ha.estado = 1 "
                                        + " order by ha.inicio; ";
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    HorarioAtencion objHorario;
                    objHorario = crearObjetoHorarioAtencion(resultado);
                    listaDeHorariosDisponibles.Add(objHorario);
                }
                resultado.Close();
                return listaDeHorariosDisponibles;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> horarioAtencionDAO -> listar " + err);
                throw err;
            }
        }//fin de listar horario disponible



        public HorarioAtencion crearObjetoHorarioAtencion(SqlDataReader resultado)
        {

            HorarioAtencion ha = new HorarioAtencion();
            Medico me = new Medico();
            me.Nombre = resultado.GetString(0);
            ha.Inicio = resultado.GetDateTime(1);
            ha.Fin = resultado.GetDateTime(2);
            ha.Consultorio = resultado.GetString(3);
            me.Id = resultado.GetInt32(4);
            ha.Id = resultado.GetInt32(5);
            ha.Medico = me;

            return ha;
        }



    }//fin de clase
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias adiconales
using dominio;
using System.Data.SqlClient;


namespace persistencia
{
    public class citaMedicaDAO
    {
        conexion cn;

        public citaMedicaDAO(conexion con)
        {
            this.cn = con;
        }


        public int ingresar(CitaMedica cm)
        {
            int registros_afectados;
            String sentenciaSQL = " insert into citaMedica(idHorarioAtencion, idPaciente) values(@idHorarioAtencion, @idPaciente) ";
            try
            {
                SqlCommand comando = cn.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@idHorarioAtencion", cm.HorarioAtencion.Id);
                comando.Parameters.AddWithValue("@idPaciente", cm.Paciente.Id);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> citaMedicaDAO -> ingresar " + err + "\n");
                throw err;
            }
        }//fin de ingresar cita medica


        public List<CitaMedica> ListarCitasDelDia(Medico medico)
        {
            List<CitaMedica> listaDeCitasDePaciente = new List<CitaMedica>();
            try
            {
                String sentenciaSQL =" select cm.id as idCita, p.nombre, p.apellidoPaterno, p.apellidoMaterno, p.dni, ha.inicio, ha.fin "
                                    +" from horarioAtencion ha, citaMedica cm, paciente p, medico m  "
                                    +" where "
                                    +" cm.idPaciente = p.id and  "
                                    +" cm.idHorarioAtencion = ha.id and  "
                                    +" ha.idMedico = m.id and  "
                                    +" m.id = '"+medico.Id+"' and  "
                                    + " ha.fecha = ( SELECT CAST(getdate() as DATE) ) ;  "; 
                                    //+" ha.fecha = (SELECT CAST(getdate() as DATE) );  "; 
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    CitaMedica cm = new CitaMedica();
                    Paciente p = new Paciente();
                    HorarioAtencion ha = new HorarioAtencion();
                    cm.Id = resultado.GetInt32(0);
                    p.Nombre = resultado.GetString(1);
                    p.ApellidoPaterno = resultado.GetString(2);
                    p.ApellidoMaterno = resultado.GetString(3);
                    p.Dni = resultado.GetString(4);
                    ha.Inicio = resultado.GetString(5);
                    ha.Fin = resultado.GetString(6);
                    cm.Paciente = p;
                    cm.HorarioAtencion = ha;
                    
                    listaDeCitasDePaciente.Add(cm);
                }
                resultado.Close();
                return listaDeCitasDePaciente;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> citaMedicaDAO -> ListarCitasDelDia() " + err + "\n\n ");
                throw err;
            }
        }//fin de buscar

        public List<CitaMedica> ListarPacientesPorMedico(string idMedico, string fecha)
        {
            List<CitaMedica> listaDeCitasDePaciente = new List<CitaMedica>();
            try
            {
                String sentenciaSQL =   " select p.nombre, p.apellidoPaterno, p.apellidoMaterno, ha.inicio, ha.fin "
                                        + " from horarioAtencion ha, citaMedica cm, paciente p, medico m "
                                        + " where "
                                        + " cm.idpaciente = p.id and "
                                        + " cm.idHorarioAtencion = ha.id and "
                                        + " ha.idMedico = m.id and "
                                        + " m.id = '"+idMedico+"' and "
                                        + " ha.fecha = '"+fecha+"' ";
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    CitaMedica cm = new CitaMedica();
                    Paciente p = new Paciente();
                    HorarioAtencion ha = new HorarioAtencion();
                    p.Nombre = resultado.GetString(0);
                    p.ApellidoPaterno = resultado.GetString(1);
                    p.ApellidoMaterno = resultado.GetString(2);
                    ha.Inicio = resultado.GetString(3);
                    ha.Fin = resultado.GetString(4);
                    cm.HorarioAtencion = ha;
                    cm.Paciente = p;

                    listaDeCitasDePaciente.Add(cm);
                }
                resultado.Close();
                return listaDeCitasDePaciente;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> citaMedicaDAO -> ListarPacientesPorMedico " + err + "\n ");
                throw err;
            }
        }//fin de buscar

        //---------------------------------
        public List<CitaMedica> ListarCitasDeUnPaciente(string idPaciente, string fecha)
        {
            List<CitaMedica> listaDeCitasDePaciente = new List<CitaMedica>();
            try
            {
                String sentenciaSQL = " select p.nombre, p.apellidoPaterno, p.apellidoMaterno, ha.inicio, ha.fin "
                                        + " from horarioAtencion ha, citaMedica cm, paciente p, medico m "
                                        + " where "
                                        + " cm.idpaciente = p.id and "
                                        + " cm.idHorarioAtencion = ha.id and "
                                        + " ha.idMedico = m.id and "
                                        + " p.id = '" + idPaciente + "' and "
                                        + " ha.fecha = '" + fecha + "' ";
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    CitaMedica cm = new CitaMedica();
                    Paciente p = new Paciente();
                    HorarioAtencion ha = new HorarioAtencion();
                    p.Nombre = resultado.GetString(0);
                    p.ApellidoPaterno = resultado.GetString(1);
                    p.ApellidoMaterno = resultado.GetString(2);
                    ha.Inicio = resultado.GetString(3);
                    ha.Fin = resultado.GetString(4);
                    cm.HorarioAtencion = ha;
                    cm.Paciente = p;

                    listaDeCitasDePaciente.Add(cm);
                }
                resultado.Close();
                return listaDeCitasDePaciente;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> citaMedicaDAO -> ListarPacientesPorMedico " + err + "\n ");
                throw err;
            }
        }//fin de buscar


        



    }//fin de clase
}

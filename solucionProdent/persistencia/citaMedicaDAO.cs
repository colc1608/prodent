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
                System.Console.WriteLine("ERROR -> persistencia -> cita Medica DAO -> ingresar " + err + "\n");
                throw err;
            }
        }//fin de ingresar cita medica


        public List<CitaMedica> buscarCitasDePaciente(Paciente paciente)
        {
            List<CitaMedica> listaDeCitasDePaciente = new List<CitaMedica>();
            try
            {
                String sentenciaSQL =   " select cm.id, m.nombre, ha.fecha, ha.inicio, ha.fin  "
                                        +" from horarioAtencion ha, citaMedica cm, paciente p, medico m "
                                        +" where "
                                        +" ha.idMedico = m.id and "
                                        +" cm.idPaciente = p.id and "
                                        +" cm.idHorarioAtencion = ha.id and "
                                        + " p.dni = '" + paciente.Dni + "' ; "; 
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    CitaMedica cm = new CitaMedica();
                    Medico m = new Medico();
                    HorarioAtencion ha = new HorarioAtencion();
                    cm.Id = resultado.GetInt32(0);
                    m.Nombre = resultado.GetString(1);
                    ha.Fecha = resultado.GetDateTime(2);
                    ha.Inicio = resultado.GetString(3);
                    ha.Fin = resultado.GetString(4);
                    ha.Medico = m;
                    cm.HorarioAtencion = ha;
                    
                    listaDeCitasDePaciente.Add(cm);
                }
                resultado.Close();
                return listaDeCitasDePaciente;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> buscarCitasDePaciente DAO -> listar " + err + "\n ");
                throw err;
            }
        }//fin de buscar



    }//fin de clase
}

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

        public citaMedicaDAO(conexion cn)
        {
            this.cn = cn;
        }


        public int ingresar(CitaMedica cm)
        {
            int registros_afectados;
            String sentenciaSQL = " insert into citaMedica(idHorarioAtencion,idPaciente) values(@idHorarioAtencion,@idPaciente) ";
            try
            {
                SqlCommand comando = cn.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@idPaciente", cm.Paciente.Id);
                comando.Parameters.AddWithValue("@idHorarioAtencion", cm.HorarioAtencion.Id);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> cita Medica DAO -> ingresar " + err + "\n");
                throw err;
            }
        }//fin de ingresar paciente






    }//fin de clase
}

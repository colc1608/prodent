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
    public class DetalleCitaDAO
    {

        conexion cn;

        public DetalleCitaDAO(conexion con)
        {
            this.cn = con;
        }

        public int ingresar(List<DetalleCita> detalleCita)
        {
            int registros_afectados = 0;
            try
            {
                String sentenciaSQL = " insert into detalleCitaMedica(idCitaMedica, idTratamiento, cantidad ) " +
                                    " values(@idCitaMedica, @idTratamiento, @cantidad); ";
                for (int i = 0; i < detalleCita.Count; i++)
                {
                    SqlCommand comando = cn.obtenerComandoSQL(sentenciaSQL);
                    comando.Parameters.AddWithValue("@idCitaMedica", detalleCita[i].CitaMedica.Id);
                    comando.Parameters.AddWithValue("@idTratamiento", detalleCita[i].Tratamiento.Id);
                    comando.Parameters.AddWithValue("@cantidad", detalleCita[i].Cantidad);
                    registros_afectados = comando.ExecuteNonQuery();
                    
                }

                return registros_afectados;
                
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> detalleCitaDAO -> ingresar " + err + "\n");
                throw err;
            }
        }//fin de ingresar detalleCita

    }
}

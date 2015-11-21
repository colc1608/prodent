using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias adicionales
using dominio;
using System.Data.SqlClient;

namespace persistencia
{
    public class especialidadDAO
    {
        conexion cn;

        public especialidadDAO(conexion cn)
        {
            this.cn = cn;
        }

        public List<Especialidad> listarEspecialidades()
        {
            List<Especialidad> listaDeEspecialidades = new List<Especialidad>();
            try
            {
                String sentenciaSQL = "select id, nombre from especialidad where estado = '1'; ";
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Especialidad objEspecialidad = new Especialidad();
                    objEspecialidad.Id = resultado.GetInt32(0);
                    objEspecialidad.Descripcion = resultado.GetString(1);
                    listaDeEspecialidades.Add(objEspecialidad);
                }
                resultado.Close();
                return listaDeEspecialidades;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> especialidadDAO -> listar " + err + "\n");
                throw err;
            }
        }//fin de listar


        

    }//fin de clase
}

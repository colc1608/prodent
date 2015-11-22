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
    public class TratamientoDAO
    {
        conexion cn;

        public TratamientoDAO(conexion con)
        {
            this.cn = con;
        }

        public List<Tratamiento> listarTratamiento()
        {
            List<Tratamiento> listaDeTratamientos = new List<Tratamiento>();
            try
            {
                String sentenciaSQL = "select id, nombre, precio from tratamiento where estado = '1'; ";
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Tratamiento objTratamiento = new Tratamiento();
                    
                    objTratamiento.Id = resultado.GetInt32(0);
                    objTratamiento.Nombre = resultado.GetString(1);
                    objTratamiento.Precio = resultado.GetDecimal(2);
                    System.Console.WriteLine("id: " + objTratamiento.Id + " nombre: " + objTratamiento.Nombre + " precio: " + objTratamiento.Precio + "\n ");
                    listaDeTratamientos.Add(objTratamiento);
                }
                resultado.Close();
                return listaDeTratamientos;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> tratamiento DAO -> listar " + err + "\n");
                throw err;
            }
        }//fin de listar


    }
}

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
    public class medicoDAO
    {
        conexion cn;

        public medicoDAO(conexion con)
        {
            this.cn = con;
        }


        public List<Medico> listarMedicos()
        {
            List<Medico> listaDeMedicos = new List<Medico>();
            try
            {
                String sentenciaSQL = "select id, nombre, apellidoPaterno, apellidoMaterno from medico where estado = '1' ";
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Medico objMedico = new Medico();
                    objMedico.Id = resultado.GetInt32(0);
                    objMedico.Nombre = resultado.GetString(1);
                    objMedico.ApellidoPaterno = resultado.GetString(2);
                    objMedico.ApellidoMaterno = resultado.GetString(3);
                    
                    listaDeMedicos.Add(objMedico);
                }
                resultado.Close();
                return listaDeMedicos;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> medicoDAO -> listarMedicos " + err + "\n");
                throw err;
            }
        }//fin de listar

    }
}

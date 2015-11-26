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
                System.Console.WriteLine("ERROR -> persistencia -> medicoDAO -> listarMedicos " + err + "\n\n");
                throw err;
            }
        }//fin de listar


        public Medico datosMedico(Usuario usuario)
        {
            Medico objMedico = new Medico();
            try
            {
                String sentenciaSQL =" select m.id as idMedico, u.id as idUsuario, m.nombre, m.apellidoPaterno "
                                    +" from medico m, usuario u where u.id = m.idUsuario and u.id = '"+usuario.Id+"'; ";
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Usuario objUsuario = new Usuario();

                    objMedico.Id = resultado.GetInt32(0);
                    objUsuario.Id = resultado.GetInt32(1);
                    objMedico.Nombre = resultado.GetString(2);
                    objMedico.ApellidoPaterno = resultado.GetString(3);

                    objMedico.Usuario = objUsuario;

                }
                resultado.Close();
                return objMedico;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> medicoDAO -> datosMedico " + err + "\n\n");
                throw err;
            }
        }//fin de validarLogin








    }
}

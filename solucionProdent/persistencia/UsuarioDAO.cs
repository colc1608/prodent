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
    public class UsuarioDAO
    {
        conexion cn;

        public UsuarioDAO(conexion con)
        {
            this.cn = con;
        }

        public Usuario validarLogin(Usuario usuario)
        {
            Usuario objUsuario = new Usuario();
            try
            {
                String sentenciaSQL = " select u.id,u.usuario from usuario u where u.usuario = '"+usuario.User+"' and u.clave = '"+usuario.Clave+"'; "; 
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    objUsuario.Id = resultado.GetInt32(0);
                    objUsuario.User = resultado.GetString(1);

                }
                resultado.Close();
                return objUsuario;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> UsuarioDAO -> validarLogin " + err + "\n");
                throw err;
            }
        }//fin de validarLogin
















    }//fin de clase
}

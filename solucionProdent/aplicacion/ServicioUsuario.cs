using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencia a otros proyectos
using dominio;
using persistencia;


namespace aplicacion
{
    public class ServicioUsuario
    {
        private conexion cn;
        private UsuarioDAO dao;


        public ServicioUsuario() 
        {
            cn = new conexion();
            dao = new UsuarioDAO(cn);
        }

        public Usuario validarLogin(Usuario usuario)
        {
            try
            {
                cn.abrirConexion();
                Usuario objUsuario = dao.validarLogin(usuario);
                cn.cerrarConexion();
                return objUsuario;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> ServicioUsuario -> validarLogin " + err + "\n \n");
                throw err;
            }
        }
    }//fin de clase
}

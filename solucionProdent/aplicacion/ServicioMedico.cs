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
    public class ServicioMedico
    {
        private conexion cn;
        private medicoDAO dao;


        public ServicioMedico() 
        {
            cn = new conexion();
            dao = new medicoDAO(cn);
        }


        public List<Medico> listarMedicos()
        {
            try
            {
                cn.abrirConexion();
                List<Medico> listaDeMedicos = dao.listarMedicos();
                cn.cerrarConexion();
                return listaDeMedicos;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> ServicioMedico -> listarMedicos " + err + "\n\n");
                throw err;
            }
        }

        public Medico crearInstancia(Usuario usuario)
        {
            try
            {
                cn.abrirConexion();
                Medico objMedico = dao.datosMedico(usuario);
                cn.cerrarConexion();
                return objMedico;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> ServicioMedico -> crearInstancia " + err + "\n\n");
                throw err;
            }
        }









    }//fin de clase
}

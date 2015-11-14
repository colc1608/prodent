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
    public class crudPaciente
    {
        private conexion cn;
        private pacienteDAO pacienteDAO;


        public crudPaciente() 
        {
            cn = new conexion();
            pacienteDAO = new pacienteDAO(cn);
        }


        public List<Paciente> listarPacientes()
        {
            try
            {
                cn.abrirConexion();
                List<Paciente> listaPacientes = pacienteDAO.listarPacientes();
                cn.cerrarConexion();
                return listaPacientes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ingresarPaciente(Paciente paciente)
        {
            try
            {
                cn.abrirConexion();
                int r = pacienteDAO.ingresar(paciente);
                cn.cerrarConexion();
                return r;
            }
            catch (Exception e)
            {
                throw e;
            }
        }//fin de ingresar Paciente

        public int modificarPaciente(Paciente paciente)
        {
            try
            {
                cn.abrirConexion();
                int r = pacienteDAO.modificar(paciente);
                cn.cerrarConexion();
                return r;
            }
            catch (Exception e)
            {
                throw e;
            }
        }//fin de modificar


        public int eliminarPaciente(Paciente paciente)
        {
            try
            {
                cn.abrirConexion();
                int r = pacienteDAO.eliminar(paciente);
                cn.cerrarConexion();
                return r;
            }
            catch (Exception e)
            {
                throw e;
            }
        }//fin de modificar





    }//fin de clase
}

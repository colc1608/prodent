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
    public class ServicioPaciente
    {
        private conexion cn;
        private pacienteDAO pacienteDAO;


        public ServicioPaciente() 
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
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> Servicio paciente -> listar " + err + "\n"); 
                throw err;
            }
        }

        public List<Paciente> BuscarPacientes(string tipo, string valor)
        {
            try
            {
                cn.abrirConexion();
                List<Paciente> listaPacientes = pacienteDAO.buscarPaciente(tipo, valor);
                cn.cerrarConexion();
                return listaPacientes;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> Servicio paciente -> buscar " + err + "\n");
                throw err;
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
                System.Console.WriteLine("ERROR -> aplicacion -> crud paciente -> ingresar " + e); 
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
                System.Console.WriteLine("ERROR -> aplicacion -> crud paciente -> modificar " + e); 
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
                System.Console.WriteLine("ERROR -> aplicacion -> crud paciente -> eliminar " + e); 
                throw e;
            }
        }//fin de modificar





    }//fin de clase
}

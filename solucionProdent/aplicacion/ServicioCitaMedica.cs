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
    public class ServicioCitaMedica
    {
        private conexion cn;
        
        private citaMedicaDAO dao;
        private CitaMedica cm = new CitaMedica();

        public ServicioCitaMedica() 
        {
            cn = new conexion();
            
            dao = new citaMedicaDAO(cn);
        }


        public int ingresarCitaMedica(CitaMedica citaMedica)
        {
            int r = 0;
            try
            {
                
                if (cm.MasDeDosCitas(citaMedica)){
                    return r;
                } 
                else
                {
                    cn.abrirConexion();
                    r = dao.ingresar(citaMedica);
                    cn.cerrarConexion();
                    return r;
                }
                
                    
                
            }
            catch (Exception e)
            {
                System.Console.WriteLine("ERROR -> aplicacion -> servicio cita medica -> ingresar " + e + "\n ");
                throw e;
            }
        }//fin de ingresar Paciente

        public List<CitaMedica> buscarCitasMedicasDePaciente(Paciente paciente)
        {
            try
            {
                cn.abrirConexion();
                List<CitaMedica> listaPacientes = dao.buscarCitasDePaciente(paciente);
                cn.cerrarConexion();
                return listaPacientes;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion ->  servicio cita medica -> buscarCitasMedicasDePaciente " + err + "\n ");
                throw err;
            }
        }//fin de buscar citaS de paciente


        public List<CitaMedica> LisrarPacientesPorDoctor(string idMedico, string fecha)
        {
            try
            {
                cn.abrirConexion();
                List<CitaMedica> listaPacientes = dao.ListarPacientesPorMedico(idMedico, fecha);
                cn.cerrarConexion();
                return listaPacientes;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion ->  servicio cita medica -> LisrarPacientesPorDoctor " + err + "\n ");
                throw err;
            }
        }//fin de buscar citaS de paciente








    }//fin de clase
}

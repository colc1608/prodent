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
                cn.abrirConexion();
                Paciente paciente = new Paciente();
                paciente.Citas = dao.ListarCitasDeUnPaciente(citaMedica.Paciente.Id.ToString(), citaMedica.HorarioAtencion.Fecha.ToString() );

                if (paciente.masDeDosCitas()){
                    return r;
                } 
                else
                {
                    
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

        public List<CitaMedica> ListarCitasDelDia(Medico medico)
        {
            try
            {
                cn.abrirConexion();
                List<CitaMedica> listaDeCitas = dao.ListarCitasDelDia(medico);
                cn.cerrarConexion();
                return listaDeCitas;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> aplicacion ->  servicio cita medica -> ListarCitasDelDia() " + err + "\n\n ");
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

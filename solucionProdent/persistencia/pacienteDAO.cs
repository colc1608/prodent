using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace persistencia
{
    public class pacienteDAO
    {
        conexion cn;

        public pacienteDAO(conexion cn) {
            this.cn = cn;
        }
        
        
        public List<Paciente> listarPacientes()
        {
            List<Paciente> listaDePacientes = new List<Paciente>();
            String sentenciaSQL = "select * from paciente";
            try
            {
                SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Paciente objPaciente;
                    objPaciente = crearObjetoPaciente(resultado);
                    listaDePacientes.Add(objPaciente);
                }
                resultado.Close();
                return listaDePacientes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public Paciente crearObjetoPaciente(SqlDataReader resultado)
        {
            
            Paciente paciente = new Paciente();

            paciente.Id = resultado.GetInt32(0);
            paciente.Nombre = resultado.GetString(1);
            paciente.ApellidoPaterno = resultado.GetString(2);
            paciente.ApellidoMaterno = resultado.GetString(3);
            paciente.Dni = resultado.GetString(4);
            paciente.Direccion = resultado.GetString(5);
            paciente.Telefono = resultado.GetString(6);
            paciente.Celular = resultado.GetString(7);
            paciente.Sexo = resultado.GetString(8);
            paciente.Correo = resultado.GetString(9);
            paciente.FechaNacimiento = resultado.GetDateTime(10);
            paciente.Estado = resultado.GetString(11);
            
            return paciente;
        }
    }
}

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

        public int ingresar(Paciente paciente)
        {
            int registros_afectados;
            String sentenciaSQL = "insert into paciente (nombre, apellidoPaterno,apellidoMaterno,dni,direccion,telefono,celular,sexo,correo,fechaNacimiento) "
                + " values (@nombre,@apellidoPaterno,@apellidoMaterno,@dni,@direccion,@telefono,@celular,@sexo,@correo,@fechaNacimiento);";
            try
            {
                SqlCommand comando = cn.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(paciente, comando);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> pacienteDAO -> ingresar " + err + "\n");
                throw err;
            }
        }//fin de ingresar paciente


        public int modificar(Paciente paciente)
        {
            int registros_afectados;
            String sentenciaSQL = "update Paciente set " +
                " nombre = @nombre, " +
                " apellidoPaterno = @apellidoPaterno,  " +
                " apellidoMaterno = @apellidoMaterno,  " +
                " dni = @dni,  " +
                " direccion = @direccion,  " +
                " telefono = @telefono, " +
                " celular = @celular,  " +
                " sexo = @sexo, " +
                " correo = @correo, " +
                " fechaNacimiento = @fechaNacimiento " +
                " where id = @id; ";
            try
            {
                SqlCommand comando = cn.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(paciente, comando);
                comando.Parameters.AddWithValue("@id", paciente.Id);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> pacienteDAO -> modificar " + err + "\n");
                throw err;
            }
        }//fin de mofificar

        public int eliminar(Paciente paciente)
        {
            int registros_afectados;
            String sentenciaSQL = "update Paciente set estado = 0 where id = @id; ";
            try
            {
                SqlCommand comando = cn.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@id", paciente.Id);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> pacienteDAO -> eliminar " + err + "\n");
                throw err;
            }
        }


        public List<Paciente> listarPacientes()
        {
            List<Paciente> listaDePacientes = new List<Paciente>();
            try
            {
                String sentenciaSQL = "select * from paciente where estado = '1' ";
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
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> pacienteDAO -> listar " + err +"\n");
                throw err;
            }
        }//fin de listar


        public List<Paciente> buscarPaciente(string tipo, string valor)
        {
            List<Paciente> listaDePacientes = new List<Paciente>();
            try
            {
                String sentenciaSQL = " select * from paciente p where p."+ tipo+" like '%"+valor+"%'; ";
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
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> pacienteDAO -> listar " + err + "\n");
                throw err;
            }
        }//fin de buscar



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


        private void asignarParametros(Paciente paciente, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("@nombre", paciente.Nombre);
            comando.Parameters.AddWithValue("@apellidoPaterno", paciente.ApellidoPaterno);
            comando.Parameters.AddWithValue("@apellidoMaterno", paciente.ApellidoMaterno);
            comando.Parameters.AddWithValue("@dni", paciente.Dni);
            comando.Parameters.AddWithValue("@direccion", paciente.Direccion);
            comando.Parameters.AddWithValue("@telefono", paciente.Telefono);
            comando.Parameters.AddWithValue("@celular", paciente.Celular);
            comando.Parameters.AddWithValue("@sexo", paciente.Sexo);
            comando.Parameters.AddWithValue("@correo", paciente.Correo);
            comando.Parameters.AddWithValue("@fechaNacimiento", paciente.FechaNacimiento);
        }





    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia
{
    public class conexion
    {
        private SqlConnection cn;
        private SqlTransaction transaccion;

        public void abrirConexion()
        {
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = "Data Source=ppi7dowad9.database.windows.net;Initial Catalog=prodent;Integrated Security=false;User ID=clopezc;Password=123456a+;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
                //Data Source=ppi7dowad9.database.windows.net;Initial Catalog=prodent;Integrated Security=False;User ID=clopezc;Password=123456a+;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False
                //"Data Source=(local);Initial Catalog=prodent;Integrated Security=true";
                cn.Open();
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> conexion -> abrir conexion " + err); 
                throw err;
                
            }

        }

        public void cerrarConexion()
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void iniciarTransaccion()
        {
            try
            {
                abrirConexion();
                transaccion = cn.BeginTransaction();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void terminarTransaccion()
        {
            try
            {
                transaccion.Commit();
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void cancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlDataReader ejecutarConsulta(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = cn.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = sentenciaSQL;
                comando.CommandType = CommandType.Text;
                SqlDataReader resultado = comando.ExecuteReader();
                return resultado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlCommand obtenerComandoSQL(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = cn.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = sentenciaSQL;
                comando.CommandType = CommandType.Text;
                return comando;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlCommand obtenerComandoSP(String procedimiento_almacenado)
        {
            try
            {
                SqlCommand comando = cn.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = procedimiento_almacenado;
                comando.CommandType = CommandType.StoredProcedure;
                return comando;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}

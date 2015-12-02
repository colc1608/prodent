using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias adicionales
using System.Data.SqlClient;
using System.Data;


namespace dominio
{
    public class CitaMedica
    {
        

        private int id;
        private HorarioAtencion horarioAtencion;
        private Paciente paciente;
        private Asistente asistente;
        private double costo;
        private string estado;



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public HorarioAtencion HorarioAtencion
        {
            get { return horarioAtencion; }
            set { horarioAtencion = value; }
        }
        

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }
        

        internal Asistente Asistente
        {
            get { return asistente; }
            set { asistente = value; }
        }
        

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }




        //public Boolean MasDeDosCitas(CitaMedica cita)
        //{
        //    //List<CitaMedica> listaDeCitasDePaciente = new List<CitaMedica>();
        //    int num = 0;
        //    try
        //    {
        //        String sentenciaSQL = " select count(dni) as dni from (select p.dni "
        //                            + " from horarioAtencion ha, citaMedica cm, paciente p, medico m  "
        //                            + " where  "
        //                            + " ha.idMedico = m.id and  "
        //                            + " cm.idPaciente = p.id and  "
        //                            + " cm.idHorarioAtencion = ha.id and  "
        //                            + " p.dni like '%4444%' and "
        //                            + " ha.fecha = '01-01-2016') x ";
        //        SqlDataReader resultado = cn.ejecutarConsulta(sentenciaSQL);
        //        while (resultado.Read())
        //        {
        //            num = resultado.GetInt16(0);
        //            /*CitaMedica cm = new CitaMedica();
        //            Paciente p = new Paciente();
        //            p.Dni = resultado.GetString(0);
        //            cm.paciente = p;
        //            listaDeCitasDePaciente.Add(cm);*/
        //        }
        //        resultado.Close();
        //        /*
        //        int cont = 0;
        //        for (int i = 0; i < listaDeCitasDePaciente.Count; i++ )
        //        {
        //            if (listaDeCitasDePaciente[i].paciente.Dni.Equals(cita.paciente.Dni))
        //                cont++;
        //        }
        //        */
        //        if (num > 2)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception err)
        //    {
        //        System.Console.WriteLine("ERROR -> dominio -> CitaMedica -> MasDeDosCitas " + err + "\n ");
        //        throw err;
        //    }
        //}//fin de buscar







        public Boolean MasDeDosCitas(CitaMedica cita)
        {
            //List<CitaMedica> listaDeCitasDePaciente = new List<CitaMedica>();
            int num = 0;
            try
            {
                SqlConnection sqlConnection1 = new SqlConnection("Data Source=ppi7dowad9.database.windows.net;Initial Catalog=prodent;Integrated Security=false;User ID=clopezc;Password=123456a+;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
                SqlCommand cmd = new SqlCommand();
                Object returnValue;

                cmd.CommandText =" select count(dni) as dni from (select p.dni "
                                +" from horarioAtencion ha, citaMedica cm, paciente p, medico m  "
                                +" where  "
                                +" ha.idMedico = m.id and  "
                                +" cm.idPaciente = p.id and  "
                                +" cm.idHorarioAtencion = ha.id and  "
                                +" p.dni like '%"+cita.paciente.Dni+"%' and "
                                +" ha.fecha = '"+cita.horarioAtencion.Fecha+"') x ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                returnValue = cmd.ExecuteScalar();

                sqlConnection1.Close();

                System.Console.WriteLine("el valor que llego de la BD es --> "+returnValue);

                num = int.Parse(returnValue.ToString());

                if (num < 2)
                    return false;
                else
                    return true;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> dominio -> CitaMedica -> MasDeDosCitas " + err + "\n ");
                throw err;
            }
        }//fin de buscar





    }
}

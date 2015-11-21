using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class HorarioAtencion
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private Medico medico;

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private DateTime inicio;

        public DateTime Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        private DateTime fin;

        public DateTime Fin
        {
            get { return fin; }
            set { fin = value; }
        }
        private string consultorio;

        public string Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        
    }
}

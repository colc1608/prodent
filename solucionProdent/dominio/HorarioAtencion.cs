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
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }




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

        

        

        private string inicio;

        public string Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        private string fin;

        public string Fin
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

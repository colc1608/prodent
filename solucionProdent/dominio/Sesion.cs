using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Sesion
    {
        private static Medico sesionMedico;

        
        public Sesion()
        {

        }

        public static Medico crearMedico()
        {
            if (sesionMedico == null)
                sesionMedico = new Medico();
            return sesionMedico;
        }


        public static Medico SesionMedico
        {
            get { return Sesion.sesionMedico; }
            set { Sesion.sesionMedico = value; }
        }
    }
}

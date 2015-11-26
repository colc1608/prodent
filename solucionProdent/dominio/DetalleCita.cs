using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class DetalleCita
    {
        private int id;
        private CitaMedica citaMedica;
        private Tratamiento tratamiento;
        private int cantidad;
        private decimal subTotal;
        private decimal total;

        
        








        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public CitaMedica CitaMedica
        {
            get { return citaMedica; }
            set { citaMedica = value; }
        }
        

        public Tratamiento Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }
        

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }






    }
}

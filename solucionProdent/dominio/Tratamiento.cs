using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Tratamiento
    {
        private int id;
        private string nombre;
        private decimal precio;
        private string estado;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


    }
}

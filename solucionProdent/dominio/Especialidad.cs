using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Especialidad
    {
        private int id;
        private string nombre;
        private string descripcion;
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
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }





    }
}

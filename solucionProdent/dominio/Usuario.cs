using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Usuario
    {
        private int id;
        private string user;
        private string clave;
        private string tipoUsuario;
        private string intentos;
        private string estado;





        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        

        public string User
        {
            get { return user; }
            set { user = value; }
        }


        

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        

        public string Intentos
        {
            get { return intentos; }
            set { intentos = value; }
        }
        

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}

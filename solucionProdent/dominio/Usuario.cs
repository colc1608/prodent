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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }


        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string tipoUsuario;

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        private string intentos;

        public string Intentos
        {
            get { return intentos; }
            set { intentos = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}

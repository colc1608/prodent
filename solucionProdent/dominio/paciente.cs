using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Paciente
    {
        private int id;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string dni;
        private string direccion;
        private string telefono;
        private string celular;
        private string sexo;
        private string correo;
        private string estado;
        private DateTime fechaNacimiento;
        private List<CitaMedica> citas;




        public Boolean masDeDosCitas()
        {
            if (citas.Count >= 2)
                return true;
            return false;
        }









        public List<CitaMedica> Citas
        {
            get { return citas; }
            set { citas = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

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
        

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
        

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        
        

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Medico
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellidoPaterno;

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        private string apellidoMaterno;

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        
    }
}

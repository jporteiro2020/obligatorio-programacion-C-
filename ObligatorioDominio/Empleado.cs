using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class Empleado
    {
        private int id;
        private static int ultId = 1;
        private string nombre;
        private string apellido;
        private string cedula;
        private DateTime fechaNacimiento;
        private DateTime fechaContratacion;
        private string categoria;
        private decimal sueldoHora;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public DateTime FechaContratacion
        {
            get
            {
                return fechaContratacion;
            }

            set
            {
                fechaContratacion = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public decimal SueldoHora
        {
            get
            {
                return sueldoHora;
            }

            set
            {
                sueldoHora = value;
            }
        }

        //Método Constructor
        public Empleado(string nombre, string apellido, string cedula, DateTime fechaNacimiento, DateTime fechaContratacion, string categoria, decimal sueldoHora)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.FechaNacimiento = fechaNacimiento;
            this.FechaContratacion = fechaContratacion;
            this.Categoria = categoria;
            this.SueldoHora = sueldoHora;
            this.id = ultId;
            Empleado.ultId++;
        }

        public override string ToString()
        {
            return "ID: " + this.id + " " + " Nombre: " + this.nombre + "" + " Apellido: " + this.apellido + "" + " Cedula: " + this.cedula + "" + " Fecha de Nacimiento: " + this.fechaNacimiento + " Fecha de Contratacion: " + this.fechaContratacion + " Categoria: " + this.categoria + " Sueldo Hora: " + this.sueldoHora;
        }
    }
}

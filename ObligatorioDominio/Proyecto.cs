using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public abstract class Proyecto
    {
        private string nombre;
        private DateTime fechaComienzo;
        private DateTime fechaFinalizacion;
        private decimal duracionDiasEstimado;
        private List<Empleado> empleados = new List<Empleado>();
        Cliente cliente;

        //Properties
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

        public DateTime FechaComienzo
        {
            get
            {
                return fechaComienzo;
            }

            set
            {
                fechaComienzo = value;
            }
        }

        public DateTime FechaFinalizacion
        {
            get
            {
                return fechaFinalizacion;
            }

            set
            {
                fechaFinalizacion = value;
            }
        }

        public decimal DuracionDiasEstimado
        {
            get
            {
                return duracionDiasEstimado;
            }

            set
            {
                duracionDiasEstimado = value;
            }
        }

        public List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }

            set
            {
                empleados = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        //Método Constructor
        public Proyecto(string nombre, DateTime fechaComienzo, DateTime fechaFinalizacion, decimal duracionDiasEstimado, Empleado empleado, Cliente cliente)
        {
            this.nombre = nombre;
            this.fechaComienzo = fechaComienzo;
            this.fechaFinalizacion = fechaFinalizacion;
            this.duracionDiasEstimado = duracionDiasEstimado;
            empleados.Add(empleado);
            this.Cliente = cliente;
        }

        public void AgregarEmpleadoALista(Empleado e)
        {
            this.empleados.Add(e); 
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + " " + " Fecha Comienzo: " + this.fechaComienzo + "" + " Fecha Finalizacion: " + this.fechaFinalizacion + " Cliente: " + this.Cliente;
        }

    }
}

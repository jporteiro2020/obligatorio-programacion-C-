using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class PorHora : Proyecto
    {
        private static decimal valorHoraExtra;
        /*private List<Ausencia> ausencias = new List<Ausencia>();*/ //En esta entrega no va a haber ausencias

        public static decimal ValorHoraExtra
        {
            get
            {
                return valorHoraExtra;
            }

            set
            {
                valorHoraExtra = value;
            }
        }

        //Método Constructor
        public PorHora(string nombre, DateTime fechaComienzo, DateTime fechaFinalizacion, decimal duracionDiasEstimado, Empleado empleado, Cliente cliente) : base(nombre, fechaComienzo, fechaFinalizacion, duracionDiasEstimado, empleado, cliente)
        {
            this.Nombre = nombre;
            this.FechaComienzo = fechaComienzo;
            this.FechaFinalizacion = fechaFinalizacion;
            this.DuracionDiasEstimado = duracionDiasEstimado;
        }

        public override string ToString()
        {
            return "Valor hora extra: " + PorHora.valorHoraExtra;
        }
    }
}

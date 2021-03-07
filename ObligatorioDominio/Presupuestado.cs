using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class Presupuestado:Proyecto
    {
        private decimal montoInicialACobrar;
        /*private decimal costo;*/ //Para esta entrega, este atributo no se usa

        //Método Constructor
        public Presupuestado(decimal montoInicialACobrar, string nombre, DateTime fechaComienzo, DateTime fechaFinalizacion, decimal duracionDiasEstimado, Empleado empleado, Cliente cliente) : base(nombre, fechaComienzo, fechaFinalizacion, duracionDiasEstimado, empleado, cliente)
        {
            this.montoInicialACobrar = montoInicialACobrar;
        }

        public override string ToString()
        {
            return "Monto inicial a cobrar: " + this.montoInicialACobrar;
        }
    }
}

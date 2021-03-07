using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class Ausencia
    {
        private Empleado empleado;
        private decimal horasAusencia;

        //Método Constructor
        public Ausencia(int id, Empleado empleado, decimal horasAusencia)
        {
            this.empleado = empleado;
            this.horasAusencia = horasAusencia;
        }
    }
}

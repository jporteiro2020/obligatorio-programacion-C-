using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class Cliente
    {
        private int rut;
        private string nombre;
        private DateTime fechaComienzoRelacionLaboral;
        private List<Proyecto> proyectos = new List<Proyecto>();

        public int Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
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

        public DateTime FechaComienzoRelacionLaboral
        {
            get
            {
                return fechaComienzoRelacionLaboral;
            }

            set
            {
                fechaComienzoRelacionLaboral = value;
            }
        }

        public List<Proyecto> Proyectos
        {
            get
            {
                return proyectos;
            }

            set
            {
                proyectos = value;
            }
        }

        //Método Constructor
        public Cliente(int rut, string nombre, DateTime fechaComienzoRelacionLaboral, Proyecto proyecto)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.FechaComienzoRelacionLaboral = fechaComienzoRelacionLaboral;
            Proyectos.Add(proyecto);
        }

        public void AgregarProyectoALista(Proyecto p)
        {
            this.proyectos.Add(p);
        }

        public override string ToString()
        {
            return "Identificador del cliente: " + this.rut + " " + " Nombre: " + this.nombre + " Fecha comienzo de la relacion laboral: " + this.fechaComienzoRelacionLaboral;
        }
    }
}

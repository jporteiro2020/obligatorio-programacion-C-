using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio;

namespace Obligatorio
{
    class Program
    {
        private static Sistema sistema = new Sistema();
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 12)
            {
                MostrarMenu();
                Console.WriteLine("Ingrese la opción seleccionada");
                int.TryParse(Console.ReadLine(), out opcion);
                VerificarOpcion(opcion);
            }
        }
        static void MostrarMenu()
        {
            Console.WriteLine("1-Alta Empleado");
            Console.WriteLine("2-Alta Cliente");
            Console.WriteLine("3-Alta Proyecto Por Hora");
            Console.WriteLine("4-Alta Proyecto Presupuestado");
            Console.WriteLine("5-Listar Empleado por categoria");
            Console.WriteLine("6-Listar Proyecto por fecha");
            Console.WriteLine("7-Cantidad de proyectos por cliente");
            Console.WriteLine("8-Modificar Empleado");
            Console.WriteLine("9-Listar Proyectos");
            Console.WriteLine("10-Asignar valor de hora extra");
            Console.WriteLine("11-Listar Clientes Por Antiguedad");
            Console.WriteLine("12-Salir");
        }
        static void VerificarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AltaEmpleado();
                    break;
                case 2:
                    AltaCliente();
                    break;
                case 3:
                    AltaProyectoPorHora();
                    break;
                case 4:
                    AltaProyectoPresupuestado();
                    break;
                case 5:
                    ListarEmpleadoPorCategoria();
                    break;
                case 6:
                    ListarProyectoPorFecha();
                    break;
                case 7:
                    ListadoCantidadProyectosPorCliente();
                    break;
                case 8:
                    ModificarEmpleado();
                    break;
                case 9:
                    ListadoProyectos();
                    break;
                case 10:
                    ValorHoraExtra();
                    break;
                case 11:
                    ListarClienteAntiguedad();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        static void AltaEmpleado()
        {
            Console.WriteLine("Alta de Empleado");
            Console.WriteLine("Ingrese nombre del Empleado");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido del empleado");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese cedula del empleado");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento del empleado");
            DateTime fechaNacimiento;
            DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);
            Console.WriteLine("Ingrese fecha de contratacion del empleado");
            DateTime fechaContratacion;
            DateTime.TryParse(Console.ReadLine(), out fechaContratacion);
            Console.WriteLine("Ingrese categoria del empleado (Junior, Semi-Senior, Senior, Tech Lead)");
            string categoria = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo hora del empleado");
            decimal sueldoHora;
            decimal.TryParse(Console.ReadLine(), out sueldoHora);
            Console.WriteLine("Lista de Proyectos");
            Console.WriteLine(sistema.ListarProyecto());
            Console.WriteLine("Ingrese nombre del proyecto seleccionado");
            string proyectoNombre = Console.ReadLine();
            Console.WriteLine(sistema.AltaEmpleado(nombre, apellido, cedula, fechaNacimiento, fechaContratacion, categoria, sueldoHora, proyectoNombre));
        }
        static void AltaCliente()
        {
            Console.WriteLine("Alta Cliente");
            Console.WriteLine("Ingrese RUT");
            int rut;
            int.TryParse(Console.ReadLine(), out rut);
            Console.WriteLine("Ingrese nombre del Cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de comienzo de la relacion laboral");
            DateTime fechaComienzoRelacionLaboral;
            DateTime.TryParse(Console.ReadLine(), out fechaComienzoRelacionLaboral);
            Console.WriteLine(sistema.ListarProyecto());
            Console.WriteLine("Ingrese el nombre del proyecto seleccionado");
            string nombreProyecto = Console.ReadLine();
            Console.WriteLine(sistema.AltaCliente(rut, nombre, fechaComienzoRelacionLaboral, nombreProyecto));
        }
        static void AltaProyectoPorHora()
        {
            Console.WriteLine("Alta de Proyecto Por Hora");
            Console.WriteLine("Ingrese nombre del proyecto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de comienzo del proyecto");
            DateTime fechaComienzo;
            DateTime.TryParse(Console.ReadLine(), out fechaComienzo);
            Console.WriteLine("Ingrese la fecha de finalizacion del proyecto");
            DateTime fechaFinalizacion;
            DateTime.TryParse(Console.ReadLine(), out fechaFinalizacion);
            Console.WriteLine("Ingrese la duracion estimado en dias del proyecto");
            decimal duracionDiasEstimado;
            decimal.TryParse(Console.ReadLine(), out duracionDiasEstimado);
            Console.WriteLine("Lista de Empleados");
            Console.WriteLine(sistema.ListarEmpleado());
            Console.WriteLine("Ingrese el codigo del empleado seleccionado");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("Lista de Clientes");
            Console.WriteLine(sistema.ListarCliente());
            Console.WriteLine("Ingrese el codigo del empleado seleccionado");
            int rut;
            int.TryParse(Console.ReadLine(), out rut);
            Console.WriteLine(sistema.AltaProyectoPorHora(nombre, fechaComienzo, fechaFinalizacion, duracionDiasEstimado, id, rut));
        }
        static void AltaProyectoPresupuestado()
        {
            Console.WriteLine("Alta de Proyecto Presupuestado");
            Console.WriteLine("Ingrese nombre del proyecto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de comienzo del proyecto");
            DateTime fechaComienzo;
            DateTime.TryParse(Console.ReadLine(), out fechaComienzo);
            Console.WriteLine("Ingrese la fecha de finalizacion del proyecto");
            DateTime fechaFinalizacion;
            DateTime.TryParse(Console.ReadLine(), out fechaFinalizacion);
            Console.WriteLine("Ingrese la duracion estimado en dias del proyecto");
            decimal duracionDiasEstimado;
            decimal.TryParse(Console.ReadLine(), out duracionDiasEstimado);
            Console.WriteLine("Lista de Empleados");
            Console.WriteLine(sistema.ListarEmpleado());
            Console.WriteLine("Ingrese el codigo del empleado seleccionado");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("Lista de Clientes");
            Console.WriteLine(sistema.ListarCliente());
            Console.WriteLine("Ingrese el codigo del empleado seleccionado");
            int rut;
            int.TryParse(Console.ReadLine(), out rut);
            Console.WriteLine("Ingrese el monto inicial a cobrar");
            decimal montoInicial;
            decimal.TryParse(Console.ReadLine(), out montoInicial);
            Console.WriteLine(sistema.AltaProyectoPresupuestado(montoInicial, nombre, fechaComienzo, fechaFinalizacion, duracionDiasEstimado, id, rut));
        }

        static void ListarEmpleadoPorCategoria()
        {
            Console.WriteLine("Filtrar Empleado por Categoria");
            Console.WriteLine("Ingrese la categoria (Junior, Semi-Senior, Senior, Tech Lead)");
            string categoria = Console.ReadLine();
            Console.WriteLine(sistema.ListarEmpleadoPorCategoria(categoria));
        }

        static void ListarProyectoPorFecha()
        {
            Console.WriteLine("Listar proyecto por fecha");
            Console.WriteLine("Ingrese una fecha");
            DateTime fecha;
            DateTime.TryParse(Console.ReadLine(), out fecha);
            Console.WriteLine(sistema.ListarProyectoPorFecha(fecha));
        }

        static void ListadoCantidadProyectosPorCliente()
        {
            Console.WriteLine("Listar cantidad de proyectos por cliente");
            Console.WriteLine(sistema.CantidadProyectoCliente());
        }

        static void ModificarEmpleado()
        {
            Console.WriteLine("Modificar Empleado");
            Console.WriteLine("Lista de Empleados");
            Console.WriteLine(sistema.ListarEmpleado());
            Console.WriteLine("Ingrese el codigo del empleado seleccionado");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("Ingrese el nombre del empleado");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del empleado");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la cedula del empleado");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento del empleado");
            DateTime fechaNacimiento;
            DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);
            Console.WriteLine("Ingrese la fecha de contratacion del empleado");
            DateTime fechaContrato;
            DateTime.TryParse(Console.ReadLine(), out fechaContrato);
            Console.WriteLine("Ingrese categoria del empleado");
            string categoria = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo por hora del empleado");
            decimal sueldoHora;
            decimal.TryParse(Console.ReadLine(), out sueldoHora);
            Console.WriteLine(sistema.ModificarEmpleado(id, nombre, apellido, cedula, fechaNacimiento, fechaContrato, categoria, sueldoHora));
        }

        static void ListadoProyectos()
        {
            Console.WriteLine("Listar todos los proyectos");
            Console.WriteLine(sistema.ListarProyecto());
        }

        static void ValorHoraExtra()
        {
            Console.WriteLine("Asignar valor de la hora extra");
            Console.WriteLine("Ingrese hora extra");
            decimal valorHoraExtra;
            decimal.TryParse(Console.ReadLine(), out valorHoraExtra);
            Console.WriteLine(sistema.AsignarValorHoraExtra(valorHoraExtra));
        }

        static void ListarClienteAntiguedad()
        {
            Console.WriteLine("Listar Cliente por antiguedad");
            Console.WriteLine("Ingrese una fecha");
            DateTime fecha;
            DateTime.TryParse(Console.ReadLine(), out fecha);
            Console.WriteLine(sistema.ClientesAntiguedad(fecha));
        }
    }


}

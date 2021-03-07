using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    public class Sistema
    {
        private List<Empleado> empleados = new List<Empleado>();
        private List<Proyecto> proyectos = new List<Proyecto>();
        private List<Cliente> clientes = new List<Cliente>();

        //Precarga de datos
        public Sistema()
        {
            //Precarga de Clientes
            AltaCliente(216216220, "TILVENOR", new DateTime(2011, 1, 4), "TILVENOR");
            AltaCliente(212087091, "ABI TECNOLOGIA", new DateTime(2015, 10, 11), "ABI TECNOLOGIA");
            AltaCliente(210120011, "ETALDIA", new DateTime(2018, 7, 5), "ETALDIA");
            AltaCliente(210340042, "ILISOL", new DateTime(2019, 1, 7), "ILISOL");
            AltaCliente(210320036, "NABIPAL", new DateTime(2015, 6, 10), "NABIPAL");
            AltaCliente(210640019, "QUARK", new DateTime(2017, 5, 16), "QUARK");
            AltaCliente(210821254, "RADIMIX", new DateTime(2015, 2, 25), "RADIMIX");
            AltaCliente(210310016, "TERCIR", new DateTime(2014, 8, 10), "TERCIR");
            AltaCliente(210258201, "ZARDOX", new DateTime(2012, 9, 15), "ZARDOX");
            AltaCliente(210832208, "MICRUS", new DateTime(2010, 6, 21), "MICRUS");

            //Precarga de empleados

            AltaEmpleado("Juan", "Alvarez", "52365536", new DateTime(1992, 11, 20), new DateTime(2018, 3, 15), "Junior", 450, "TILVENOR");
            AltaEmpleado("Pablo", "Lopez", "42365284", new DateTime(1986, 8, 15), new DateTime(2011, 4, 11), "Tech Lead", 750, "ETALDIA");
            AltaEmpleado("Santiago", "Diaz", "52526481", new DateTime(1990, 8, 20), new DateTime(2015, 11, 20), "Senior", 650, "MICRUS");
            AltaEmpleado("Maria", "Gonzalez", "56834562", new DateTime(1992, 7, 24), new DateTime(2019, 3, 4), "Semi-Senior", 500, "MICRUS");
            AltaEmpleado("Ricardo", "Aguirre", "42880442", new DateTime(1985, 08, 25), new DateTime(2012, 11, 13), "Semi-Senior", 500, "MICRUS");
            AltaEmpleado("Jimena", "Martinez", "40042823", new DateTime(1987, 10, 15), new DateTime(2013, 1, 24), "Tech Lead", 750, "QUART");
            AltaEmpleado("Enrique", "Larrosa", "32201564", new DateTime(1971, 12, 10), new DateTime(2012, 10, 4), "Tech Lead", 750, "TILVENOR");
            AltaEmpleado("Tomas", "Rodriguez", "48253213", new DateTime(1988, 12, 1), new DateTime(2018, 8, 24), "Semi-Senior", 500, "ZARDOX");
            AltaEmpleado("Sara", "Pereira", "47647225", new DateTime(1983, 8, 15), new DateTime(2014, 1, 21), "Tech Lead", 750, "QUART");

            //Precarga de Proyectos
            AltaProyectoPorHora("TILVENOR", new DateTime(2012, 1, 1), new DateTime(2012, 2, 9), 40, 1, 216216220);
            AltaProyectoPorHora("ETALDIA", new DateTime(2018, 7, 20), new DateTime(2018, 10, 10), 90, 2, 216216220);
            AltaProyectoPorHora("ILISOL", new DateTime(2019, 2, 19), new DateTime(2019, 10, 5), 50, 3, 212087091);
            AltaProyectoPorHora("TIL", new DateTime(2013, 1, 23), new DateTime(2014, 2, 9), 40, 4, 210120011);
            AltaProyectoPorHora("QUARK", new DateTime(2017, 6, 20), new DateTime(2018, 10, 5), 85, 5, 210120011);
            AltaProyectoPorHora("QUART", new DateTime(2019, 2, 19), new DateTime(2019, 10, 5), 50, 6, 210120011);
            AltaProyectoPorHora("TILVENOR", new DateTime(2015, 1, 16), new DateTime(2016, 4, 8), 40, 7, 210340042);
            AltaProyectoPorHora("ETAL", new DateTime(2018, 7, 2), new DateTime(2019, 1, 10), 75, 8, 210340042);
            AltaProyectoPorHora("ZARDOX", new DateTime(2012, 11, 5), new DateTime(2013, 5, 4), 50, 1, 210320036);
            AltaProyectoPorHora("ZARD", new DateTime(2014, 9, 21), new DateTime(2015, 10, 16), 30, 2, 210320036);

            AltaProyectoPresupuestado(50000, "ABI TECNOLOGIA", new DateTime(2016, 3, 15), new DateTime(2016, 5, 20), 65, 1, 210832208);
            AltaProyectoPresupuestado(45000, "NABIPAL", new DateTime(2015, 7, 19), new DateTime(2015, 12, 5), 80, 1, 210832208);
            AltaProyectoPresupuestado(35000, "MICRUS", new DateTime(2011, 3, 1), new DateTime(2012, 3, 21), 91, 2, 210258201);
            AltaProyectoPresupuestado(45520, "MICRO", new DateTime(2013, 7, 26), new DateTime(2013, 12, 10), 50, 2, 210258201);
            AltaProyectoPresupuestado(55160, "RADIMIX", new DateTime(2016, 3, 15), new DateTime(2016, 8, 20), 65, 3, 210258201);
            AltaProyectoPresupuestado(70150, "RADIOMIX", new DateTime(2017, 7, 31), new DateTime(2018, 5, 25), 35, 2, 210258201);
            AltaProyectoPresupuestado(34000, "TECNOLOGIA", new DateTime(2017, 2, 14), new DateTime(2016, 9, 15), 44, 5, 210821254);
            AltaProyectoPresupuestado(20000, "TERCIR", new DateTime(2015, 11, 3), new DateTime(2016, 8, 11), 74, 7, 210821254);
            AltaProyectoPresupuestado(15030, "TERCER", new DateTime(2016, 9, 19), new DateTime(2017, 5, 23), 55, 4, 210821254);
            AltaProyectoPresupuestado(44560, "NABI", new DateTime(2017, 4, 8), new DateTime(2017, 6, 14), 36, 2, 210821254);

        }

        #region Empleado

        //Alta Empleado
        public string AltaEmpleado(string nombre, string apellido, string cedula, DateTime fechaNacimiento, DateTime fechaContratacion, string categoria, decimal sueldoHora, string proyecto)
        {
            string alta = "El Empleado no se dio de alta";

            if (nombre != "" && apellido != "" && cedula != "" && fechaNacimiento != null && fechaContratacion != null && fechaContratacion > fechaNacimiento && categoria != "" && sueldoHora > 0 && proyecto != "")
            {
                if (categoria == "Junior" || categoria == "Semi-Senior" || categoria == "Senior" || categoria == "Tech Lead")
                {
                    Empleado empleado = BuscarEmpleadoCedula(cedula);
                    Proyecto p = BuscarProyecto(proyecto);

                    if (empleado == null)
                    {
                        if (p != null)
                        {
                            Empleado e = new Empleado(nombre, apellido, cedula, fechaNacimiento, fechaContratacion, categoria, sueldoHora);
                            empleados.Add(e);
                            p.AgregarEmpleadoALista(e);
                            alta = "El Empleado se dio de alta exitosamente";
                        }
                        else
                        {
                            Empleado e = new Empleado(nombre, apellido, cedula, fechaNacimiento, fechaContratacion, categoria, sueldoHora);
                            empleados.Add(e);
                            alta = "El Empleado se dio de alta exitosamente, pero no el proyecto seleccionado no existe";
                        }
                    }
                    else
                    {
                        alta = "La cedula ingresada ya existe en el sistema";
                    }
                    
                }
                else
                {
                    alta = "La categoria ingresada no es correcta. Las categorias son: Junior, Semi-Senior, Senior y Tech Lead";
                }
                
            }
            else
            {
                alta = "Los datos ingresados no son correctos";
            }

            return alta;

        }

        //Listar a todos los empleados por categoria y si no se ingresa una categoria listar a todos los empleados
        public string ListarEmpleadoPorCategoria(string categoria)
        {
            string listaEmpleadosCategoria = "";
            foreach (Empleado e in empleados)
            {
                if (e.Categoria == categoria || categoria == "")
                {
                    listaEmpleadosCategoria += "ID: " + e.Id + " Nombre: " + e.Nombre + " Apellido: " + e.Apellido + " Cedula: " + e.Cedula + " Categoria: " + e.Categoria + "\n";
                }
                else
                {
                    listaEmpleadosCategoria = "Debe ingresar una categoria correcta (Junior, Semi-Senior, Senior, Tech Lead) o puede no ingresar ningun valor)";
                }
            }

            return listaEmpleadosCategoria;
            
        }

        //Listar todos los empleados
        public string ListarEmpleado()
        {
            string listaEmpleados = "";
            foreach (Empleado e in empleados)
            {
                listaEmpleados += "ID: " + e.Id + " Nombre: " + e.Nombre + " Apellido: " + e.Apellido + " Cedula: " + e.Cedula + " Categoria: " + e.Categoria + "\n";

            }
            return listaEmpleados;
        }

        //Buscar si existe o no el empleado
        private Empleado BuscarEmpleado(int id)
        {
            Empleado empleado = null;
            int i = 0;
            while (i < empleados.Count && empleado == null)
            {
                if (empleados[i].Id == id)
                {
                    empleado = empleados[i];
                }
                i++;
            }
            return empleado;
        }

        private Empleado BuscarEmpleadoCedula(string cedula)
        {
            Empleado empleado = null;
            int i = 0;
            while (i < empleados.Count && empleado == null)
            {
                if (empleados[i].Cedula == cedula)
                {
                    empleado = empleados[i];
                }
                i++;
            }
            return empleado;
        }

        #endregion

        #region Cliente

        //Alta Cliente
        public string AltaCliente(int rut, string nombre, DateTime fechaComienzoRelacionLaboral, string nombreProyecto)
        {

            string alta = "El Cliente no se dio de alta";

            if (nombre != "" && fechaComienzoRelacionLaboral != null && nombreProyecto != "")
            {
                Cliente cliente = BuscarCliente(rut);
                Proyecto proyecto = BuscarProyecto(nombreProyecto);

                if (cliente == null && proyecto == null)
                {
                    Cliente c = new Cliente(rut, nombre, fechaComienzoRelacionLaboral, proyecto);
                    clientes.Add(c);
                    alta = "El Cliente se dio de alta exitosamente";
                }
            }
            else
            {
                alta = "Los datos ingresados no son correctos";
            }

            return alta;

        }

        //Buscar si existe o no un cliente
        private Cliente BuscarCliente(int rut)
        {
            Cliente cliente = null;
            int i = 0;
            while (i < clientes.Count && cliente == null)
            {
                if (clientes[i].Rut == rut)
                {
                    cliente = clientes[i];
                }
                i++;
            }
            return cliente;
        }

        /*Retorna una lista con la cantidad de proyectos del cliente*/
        public string CantidadProyectoCliente()
        {
            string cantidadProyectoCliente = "";
            foreach (Cliente c in clientes)
            {
                cantidadProyectoCliente += "Nombre: " + c.Nombre + " RUT: " + c.Rut + " Fecha comienzo relacion laboral: " + c.FechaComienzoRelacionLaboral + " Cantidad de proyectos: " + c.Proyectos.Count + "\n";

            }
            return cantidadProyectoCliente;
        }

        /*Modificación de los datos de un cliente dado*/
        public string ModificarEmpleado(int idEmpleado, string nombre, string apellido, string cedula, DateTime fechaNacimiento, DateTime fechaContratacion, string categoria, decimal sueldoHora)
        {
            string modificacion = "No se pudo modificar el cliente";
            foreach (Empleado e in empleados)
            {
                if (e.Id == idEmpleado)
                {
                    if (nombre != "" && apellido != "" && cedula != "" && fechaNacimiento != null && fechaNacimiento < DateTime.Now && fechaContratacion != null && categoria != "" && sueldoHora > 0)
                    {
                        e.Nombre = nombre;
                        e.Apellido = apellido;
                        e.Cedula = cedula;
                        e.FechaNacimiento = fechaNacimiento;
                        e.FechaContratacion = fechaContratacion;
                        e.Categoria = categoria;
                        e.SueldoHora = sueldoHora;

                        modificacion = "Se pudo modificar el cliente";
                    }

                }

            }
            return modificacion;
        }

        //Dada una fecha, se listaran los clientes con esa antiguedad
        public string ClientesAntiguedad(DateTime antiguedad)
        {
            string clientesAntiguedad = "";
            foreach (Cliente c in this.clientes)
            {
                if (antiguedad >= c.FechaComienzoRelacionLaboral)
                {
                    clientesAntiguedad += "Nombre: " + c.Nombre + " RUT: " + c.Rut + " Fecha Comienzo relacion laboral: " + c.FechaComienzoRelacionLaboral + "\n";
                }
            }

            return clientesAntiguedad;
        }

        //Listar todos los proyectos
        public string ListarCliente()
        {
            string listaClientes = "";
            foreach (Cliente c in clientes)
            {
                listaClientes += "Nombre: " + c.Nombre + " RUT: " + c.Rut + "\n";

            }
            return listaClientes;
        }

        #endregion

        #region Proyecto

        //Alta Proyecto Por Hora
        public string AltaProyectoPorHora(string nombre, DateTime fechaComienzo, DateTime fechaFinalizacion, decimal duracionDiasEstimado, int idEmpleado, int rut)
        {
            string alta = "El Proyecto Por hora no se dio de alta";
            if (nombre != "" && fechaComienzo != null && fechaFinalizacion != null && fechaFinalizacion > fechaComienzo && duracionDiasEstimado > 0 && idEmpleado > 0)
            {
                Empleado empleado = BuscarEmpleado(idEmpleado);
                Proyecto proyecto = BuscarProyecto(nombre);
                Cliente cliente = BuscarCliente(rut);
                if (empleado != null && proyecto == null && cliente != null)
                {
                    PorHora p = new PorHora(nombre, fechaComienzo, fechaFinalizacion, duracionDiasEstimado, empleado, cliente);
                    this.proyectos.Add(p);
                    cliente.AgregarProyectoALista(p);
                    alta = "El Proyecto Por Hora se dio de alta exitosamente";
                }
            }
            else
            {
                alta = "Los datos ingresados no son correctos";
            }
            return alta;
        }

        //Alta Proyecto Presupuestado
        public string AltaProyectoPresupuestado(decimal montoInicialACobrar, string nombre, DateTime fechaComienzo, DateTime fechaFinalizacion, decimal duracionDiasEstimado, int idEmpleado, int rut)
        {
            string alta = "El Proyecto Presupuestado no se dio de alta";
            if (montoInicialACobrar > 0 && nombre != "" && fechaComienzo != null && fechaFinalizacion != null && fechaFinalizacion > fechaComienzo && duracionDiasEstimado > 0 && idEmpleado > 0 && rut > 0)
            {
                Empleado empleado = BuscarEmpleado(idEmpleado);
                Proyecto proyecto = BuscarProyecto(nombre);
                Cliente cliente = BuscarCliente(rut);
                if (empleado != null && proyecto == null && cliente != null)
                {
                    Presupuestado p = new Presupuestado(montoInicialACobrar, nombre, fechaComienzo, fechaFinalizacion, duracionDiasEstimado, empleado, cliente);
                    this.proyectos.Add(p);
                    cliente.AgregarProyectoALista(p);
                    alta = "El Proyecto Presupuestado se dio de alta exitosamente";
                }
            }
            else
            {
                alta = "Los datos ingresados no son correctos";
            }
            return alta;
        }

        //Listar todos los proyectos dado una fecha de comienzo del proyecto
        public string ListarProyectoPorFecha(DateTime fecha)
        {
            string listaProyectosFecha = "";
            foreach (Proyecto p in proyectos)
            {
                if (p.FechaComienzo == fecha)
                {
                    listaProyectosFecha += "Nombre: " + p.Nombre + " Fecha Comienzo: " + p.FechaComienzo + " Fecha Finalizacion: " + p.FechaFinalizacion + " Cliente " + p.Cliente + "\n";
                }
            }
            return listaProyectosFecha;
         }

        //Listar todos los proyectos
        public string ListarProyecto()
        {
            string listaProyectos = "";
            foreach (Proyecto p in proyectos)
            {
                listaProyectos += "Nombre: " + p.Nombre + " Fecha Comienzo: " + p.FechaComienzo + " Fecha Finalizacion: " + p.FechaFinalizacion + " Cliente " + p.Cliente + "\n";

            }
            return listaProyectos;
        }

        //Buscar si existe o no el proyecto
        private Proyecto BuscarProyecto(string nombre)
        {
            Proyecto proyecto = null;
            int i = 0;
            while (i < proyectos.Count && proyecto == null)
            {
                if (proyectos[i].Nombre == nombre)
                {
                    proyecto = proyectos[i];
                }
                i++;
            }
            return proyecto;
        }

        //Se asigna valor de la hora extra
        public string AsignarValorHoraExtra(decimal valorHoraExtra)
        {
            string modificacion = "No se pudo asignar el valor de la hora extra";

            if (valorHoraExtra > 0)
            {
                PorHora.ValorHoraExtra = valorHoraExtra;

                modificacion = "Se modifico el valor de la hora extra exitosamente";
            }


            return modificacion;
        }

        #endregion

    }

}


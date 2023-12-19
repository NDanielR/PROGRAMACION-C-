//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS

using System;
using System.Globalization;
using System.Linq;

namespace Ejerccio_7_Nelson_Daniel_Ramirez
{

    class Programa
    {
        static void Main()

        {
            
            string NombrePaciente;
            int CantidadClientes, EtapaPaciente;
            List<Paciente> Pacientes = new List<Paciente>();

            while (true)
            {
                Console.Write("Ingrese la cantidad de clientes a valorar: ");
                if (int.TryParse(Console.ReadLine(), out CantidadClientes) && CantidadClientes > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cantidad de clientes no es un valor entero. Ingrese un número entero.");
                }
            }

            for (int i = 0; i < CantidadClientes; i++)
            {
                Console.Write("Ingrese el nombre del paciente: ");
                NombrePaciente = Console.ReadLine();
                Console.Write("Ingrese la edad del empleado: ");

                if (int.TryParse(Console.ReadLine(), out EtapaPaciente))
                {
                    Pacientes.Add(new Paciente { Nombre = NombrePaciente, Edad = EtapaPaciente });
                }
                else
                {
                    Console.WriteLine("Edad no válida. Ingrese un número entero.");
                    i--; // Descuenta al for para repetir la que quedo mal
                }
            }

            //// Calculamos la edad promedio
            //decimal PromedioEdades = CalcularEdadPromedio(Empleados);

            //Console.WriteLine("La edad promedio de los empleados es: " + PromedioEdades);

            //// Encontrar los dos empleados más cercanos al promedio
            //var EmpleadosCercanos = EncontrarEmpleadosCercanos(Empleados, PromedioEdades);

            //Console.WriteLine("Los empleados con edades más cercanas al promedio son:");
            //foreach (var Empleado in EmpleadosCercanos)
            //{
            //    Console.WriteLine("Nombre: " + Empleado.Nombre + ", Edad: " + Empleado.Edad);
            //}
        }

        static void CalcularPrimeraDosis (int Dosis1,List<Paciente> Pacientes)
        {
            
            int valorBuscado=1;
            int cantidad = Pacientes.Count(numero => numero == valorBuscado);
            int cantidad = Pacientes.Count(numero => numero == valorBuscado);

        }

    

    class Paciente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
   
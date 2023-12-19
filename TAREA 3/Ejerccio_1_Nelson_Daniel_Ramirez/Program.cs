//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS

using System;

namespace ejerccio_1_Nelson_Daniel_Ramirez
{ 


class Programa
{
    static void Main()
    {
        int CantidadEmpleados;

        while (true)
        {
            Console.Write("Ingrese la cantidad de empleados a valorar: ");
            if (int.TryParse(Console.ReadLine(), out CantidadEmpleados) && CantidadEmpleados > 0)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Cantidad de empleados no es un valor entero. Ingrese un número entero.");
            }
        }

        List<Empleado> Empleados = new List<Empleado>();

        for (int i = 0; i < CantidadEmpleados; i++)
        {
            Console.Write("Ingrese el nombre del empleado: ");
            string NombreEmpleado = Console.ReadLine();

            Console.Write("Ingrese la edad del empleado: ");
            if (int.TryParse(Console.ReadLine(), out int EdadEmpleado))
            {
                Empleados.Add(new Empleado { Nombre = NombreEmpleado, Edad = EdadEmpleado });
            }
            else
            {
                Console.WriteLine("Edad no válida. Ingrese un número entero.");
                i--; // Descuenta al for para repetir la que quedo mal
            }
        }

        // Calculamos la edad promedio
        decimal PromedioEdades = CalcularEdadPromedio(Empleados);

        Console.WriteLine("La edad promedio de los empleados es: " + PromedioEdades);

        // Encontrar los dos empleados más cercanos al promedio
        var EmpleadosCercanos = EncontrarEmpleadosCercanos(Empleados, PromedioEdades);

        Console.WriteLine("Los empleados con edades más cercanas al promedio son:");
        foreach (var Empleado in EmpleadosCercanos)
        {
            Console.WriteLine("Nombre: " + Empleado.Nombre + ", Edad: " + Empleado.Edad);
        }
    }

    static decimal CalcularEdadPromedio(List<Empleado> Empleados)
    {
        if (Empleados.Count == 0)
            return 0;

        int SumaEdades = Empleados.Sum(Empleado => Empleado.Edad);
        return (decimal)SumaEdades / Empleados.Count;
    }

    static List<Empleado> EncontrarEmpleadosCercanos(List<Empleado> empleados, decimal promedio)
    {
        return empleados.OrderBy(Empleado => Math.Abs(Empleado.Edad - promedio)).Take(2).ToList();
    }
}

    class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}

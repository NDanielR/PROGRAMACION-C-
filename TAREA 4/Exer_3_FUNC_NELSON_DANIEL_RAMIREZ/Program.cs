//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS
using System;
using System.Globalization;


namespace Exer_3_FUNC_NELSON_DANIEL_RAMIREZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalTemperaturas;
            List<decimal> TemperaturasList = new List<decimal>();

            while (true)
            {
                Console.WriteLine("Ingrese la cantidad de temperaturas a evaluar: ");
                if (int.TryParse(Console.ReadLine(), out TotalTemperaturas))
                {
                    Console.WriteLine("Cantidad de temperaturas evaluadas: " + TotalTemperaturas);
                    break;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un número entero válido.");
                }
            }

            IngresarTemperaturas(TotalTemperaturas, TemperaturasList);
            MostrarResultados(TotalTemperaturas, TemperaturasList);
        }

        static void IngresarTemperaturas(int TotalTemperaturas, List<decimal> TemperaturasList)
        {
            string TemperaturaIngresada;
            decimal Temperatura;

            for (int i = 0; i < TotalTemperaturas; i++) 
            {
                Console.WriteLine($"Ingrese temperatura {i + 1}");
                TemperaturaIngresada = Console.ReadLine();

                if (decimal.TryParse(TemperaturaIngresada, NumberStyles.Any, CultureInfo.InvariantCulture, out Temperatura))
                {
                    TemperaturasList.Add(Temperatura);
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un número decimal válido.");
                    i--;
                }
            }
        }

        static void MostrarResultados(int totalTemperaturas, List<decimal> TemperaturasList)
        {
            decimal SumaTemp, PromedioTemp, TemperaturaMax, TemperaturaMin;
            SumaTemp = TemperaturasList.Sum();
            PromedioTemp = TemperaturasList.Average();
            TemperaturaMax = TemperaturasList.Max();
            TemperaturaMin = TemperaturasList.Min();

            Console.WriteLine($"\nTemperaturas evaluadas:{totalTemperaturas}");
            Console.WriteLine($"\nSuma total de temperaturas:{SumaTemp}");
            Console.WriteLine($"\nTemperatura promedio:{PromedioTemp}");
            Console.WriteLine($"\nTemperatura máxima:{TemperaturaMax}");
            Console.WriteLine($"\nTemperatura mínima:{TemperaturaMin}");
            Console.WriteLine($"\nLista de temperaturas:");

            foreach (decimal TempImpresa in TemperaturasList)
            {
                Console.WriteLine($"\n{TempImpresa}");
            }
        }
    }
}


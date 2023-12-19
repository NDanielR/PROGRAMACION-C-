//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS


using System;
using System.Globalization;//libreria usada para que el . y , no generen conflicto.

namespace EJERCICO_3_NELSON_DANIEL_RAMIREZ
{
    class Program
    {



        static void Main(string[] args)

        {
            string TemperaturaIngresada;
            int TotalTemperaturas;
            List<decimal> Temperaturaslist = new List<decimal>();
            decimal Temperatura,SumaTemp,PromedioTemp,TemperaturaMax,TemperaturaMin;

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

            for (int i = 0; i < TotalTemperaturas; i++)
            {
                Console.WriteLine($"Ingrese temperatura {i + 1}");
                TemperaturaIngresada= Console.ReadLine();
                

                if (decimal.TryParse(TemperaturaIngresada, NumberStyles.Any,CultureInfo.InvariantCulture,out Temperatura))//esta linea me ayuda para que cuando el numero lo escriba con . o , sera tomado como decimal.
                {
                    Temperaturaslist.Add(Temperatura);
                }

                else
                {
                    Console.WriteLine("El valor ingresado no es un número decimal válido.");
                    i--;
                }             
            }
            SumaTemp = Temperaturaslist.Sum();
            PromedioTemp = Temperaturaslist.Average();
            TemperaturaMax = Temperaturaslist.Max();    
            TemperaturaMin = Temperaturaslist.Min();    
            Console.WriteLine($"\nTemperaturas evaluadas:{TotalTemperaturas}");
            Console.WriteLine($"\nSuma total de temperaturas:{SumaTemp}");
            Console.WriteLine($"\nTemperatura promedio:{PromedioTemp}");
            Console.WriteLine($"\nTemperatura maxima:{TemperaturaMax}");
            Console.WriteLine($"\nTemperatura minima:{TemperaturaMin}");
            Console.WriteLine($"\nLista de temperaturas:");
            foreach (decimal TempImpresa in Temperaturaslist)
            {
                Console.WriteLine($"\n{TempImpresa}");
            }
        }
    }
}

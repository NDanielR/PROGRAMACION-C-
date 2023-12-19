//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS

using System;

namespace Tarea_2_Nelson_Daniel_Ramirez
{
    class Program
    {



        static void Main(string[] args)
        {
            string Ahorro,Meses;
            int Inversion, NumeroMeses;
            decimal GananciaPorMes, TotalGanancias,TotalCapitalGanancia;

            while (true)
            {
                Console.Write("Por favor, ingresa el valor a invetir: ");

                Ahorro = Console.ReadLine();

                if (int.TryParse(Ahorro, out Inversion) && Inversion >= 1)
                {

                    Console.WriteLine("El valor invertido es de: " + Inversion);
                    break;
                }
                else
                {

                    Console.WriteLine("El valor ingresado no es un número entero válido.");
                }
            }

            while (true) 
            {
                Console.Write("Por favor, ingresa el numero de meses de la inversion: ");

                Meses = Console.ReadLine();

                if (int.TryParse(Meses, out NumeroMeses) && NumeroMeses >=1)
                {

                    Console.WriteLine("El numero de meses es: " + NumeroMeses);
                    break;

                }
                else
                {

                    Console.WriteLine("El valor ingresado no es un número entero válido.");
                }
            }

            GananciaPorMes = (decimal)Inversion * 7 / 100;
            TotalGanancias = GananciaPorMes * (decimal)NumeroMeses;
            TotalCapitalGanancia = TotalGanancias + Inversion;
            Console.WriteLine("Tu ganancia por mes =" + GananciaPorMes);
            Console.WriteLine("Tus ganancias totales son de =" + TotalGanancias);
            Console.WriteLine("Tu total capital + ganacias es de =" +  TotalCapitalGanancia);


         

                Console.ReadKey();
        }
    }
}

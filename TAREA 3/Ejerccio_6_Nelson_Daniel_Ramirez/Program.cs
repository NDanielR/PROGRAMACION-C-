//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS

using System;

namespace ejerccio_6_Nelson_Daniel_Ramirez
{

    class Programa
    {
        static decimal AreaCuadrado(decimal Lado)
        {
            return Lado * Lado;
        }

        static void Main()
        {
            Console.WriteLine("Programa para calcular el área y el perímetro de un cuadrado");

            while (true)
            {
                Console.Write("Ingresa el valor del lado del cuadrado: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal Lado))
                {
                    decimal Area = AreaCuadrado(Lado);
                    decimal Perimetro = 4 * Lado;
                    Console.WriteLine($"Área del cuadrado: {Area}");
                    Console.WriteLine($"Perímetro del cuadrado: {Perimetro}");
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un valor válido.");
                    continue; 
                }

                bool RespuestaValida = false;
                do
                {
                    Console.Write("¿Deseas calcular el área y el perímetro de otro cuadrado? (Si/No): ");
                    string Respuesta = Console.ReadLine();

                    if (Respuesta == "SI" || Respuesta == "si")
                    {
                        RespuestaValida = true;
                    }
                    else if (Respuesta == "NO" || Respuesta == "no")
                    {
                        RespuestaValida = true;
                        Console.WriteLine("Gracias. ¡Hasta luego!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Respuesta no válida.");
                    }
                } while (!RespuestaValida);
            }
        }
    }
}
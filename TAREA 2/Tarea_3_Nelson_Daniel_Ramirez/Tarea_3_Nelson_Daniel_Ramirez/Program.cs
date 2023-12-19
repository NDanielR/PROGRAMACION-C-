//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS

using System;

namespace Tarea_3_Nelson_Daniel_Ramirez
{
    class Program
    { 
        
        static void Main()
        {
            int[,] Matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Matriz[i, j] = CapturarNumero();
                }
            }

            
            int SumaDiagonal1 = 0, SumaDiagonal2 = 0;
            double PromedioDiagonal1 = 0, PromedioDiagonal2 = 0;

            for (int i = 0; i < 3; i++)
            {
                SumaDiagonal1 += Matriz[i, i];
                SumaDiagonal2 += Matriz[i, 2 - i];
            }

            PromedioDiagonal1 = SumaDiagonal1 / 3;
            PromedioDiagonal2 = SumaDiagonal2 / 3;

            ImprimirMatriz(Matriz);
            Console.WriteLine("Suma de la diagonal 1:" + SumaDiagonal1);
            Console.WriteLine("Promedio de la diagonal 1:" + PromedioDiagonal1);
            Console.WriteLine("Suma de la diagonal 2:" + SumaDiagonal2);
            Console.WriteLine("Promedio de la diagonal 2:" + PromedioDiagonal2);

            if (SumaDiagonal1 > SumaDiagonal2)
            {
                Console.WriteLine("La diagonal 1 de ubicacion 0,0 tiene la suma mayor.");
            }
            else if (SumaDiagonal2 > SumaDiagonal1)
            {
                Console.WriteLine("La diagonal 2 de ubicacion 0,3 tiene la suma mayor.");
            }
            else
            {
                Console.WriteLine("Ambas diagonales son iguales.");
            }
        }

       static int CapturarNumero()
        {
            int Numero;
            while (true)
            {
                Console.Write("Ingrese un número entre 100 y 200: ");
                if (int.TryParse(Console.ReadLine(), out Numero) && Numero >= 100 && Numero <= 200)
                {
                    return Numero;
                }
                else
                {
                    Console.WriteLine("El número debe estar en el rango de 100 a 200. Intente de nuevo.");
                }
            }
        }

        static void ImprimirMatriz(int[,] Matriz)
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
//Convertir un número en una matriz de dígitos invertida

namespace EJERCICIO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Entrada;
            int Numero;
            char[] Digitos;

            Console.WriteLine("Ingrese numero");
            Entrada= Console.ReadLine();

            if (int.TryParse(Entrada, out Numero))
            { 
                Digitos = Numero.ToString().ToCharArray();
                Console.WriteLine("Digitos del numero");

                for (int i = 0; i < Digitos.Length; i++)
                
                {
                    Console.Write(Digitos[i] + ",");
                }

                Console.Write(" ---> ");

                for (int i = Digitos.Length - 1; i >= 0; i--)
                
                {
                    Console.Write(Digitos[i] + ",");
                }
            }
            
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }
    }
}



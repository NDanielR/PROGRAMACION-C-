//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS

using System; 

namespace Tarea_1_Nelson_Daniel_Ramirez
{
    class Program 
    {
        

        
        static void Main(string[] args)
        {
            string Palabra;
            decimal ConsumoBasico, Descuento, Subtotal, Iva, TotalPagar;

            Console.Write("Por favor, ingresa el valor base del producto: ");

            Palabra = Console.ReadLine();

            if (decimal.TryParse(Palabra, out ConsumoBasico))
            {

                Console.WriteLine("El valor base es de: " + ConsumoBasico);
            }
            else
            {
            
                Console.WriteLine("El valor ingresado no es un número decimal válido.");
            }

            if(ConsumoBasico>=50000 && ConsumoBasico<=99999)
            {

                Descuento = ConsumoBasico * 5 / 100;
                Subtotal = ConsumoBasico - Descuento;
                Iva = Subtotal * 19 / 100;
                TotalPagar = Subtotal + Iva;
                Console.WriteLine("Tienes el 5% de descuento por su compra.");
                Console.WriteLine("Su descuento es de: " + Descuento);
                Console.WriteLine("Subtotal de la compra: " + Subtotal);
                Console.WriteLine("El valor del iva es de: " + Iva);
                Console.WriteLine("Total a pagar: " + TotalPagar);
                Console.WriteLine("Gracias por tu compra, vuelve pronto");

            }

            if (ConsumoBasico >= 100000 && ConsumoBasico <= 149999)
            {
                
                Descuento = ConsumoBasico * 10 / 100;
                Subtotal = ConsumoBasico - Descuento;
                Iva = Subtotal * 19 / 100;
                TotalPagar = Subtotal + Iva;
                Console.WriteLine("Tienes el 10% de descuento por su compra.");
                Console.WriteLine("Su descuento es de: " + Descuento);
                Console.WriteLine("Subtotal de la compra: " + Subtotal);
                Console.WriteLine("El valor del iva es de: " + Iva);
                Console.WriteLine("Total a pagar: " + TotalPagar);
                Console.WriteLine("Gracias por tu compra, vuelve pronto");
            
            }

            if (ConsumoBasico >= 150000)
            {

                Descuento = ConsumoBasico * 15 / 100;
                Subtotal = ConsumoBasico - Descuento;
                Iva = Subtotal * 19 / 100;
                TotalPagar = Subtotal + Iva;
                Console.WriteLine("Tienes el 15% de descuento por su compra.");
                Console.WriteLine("Su descuento es de: " + Descuento);
                Console.WriteLine("Subtotal de la compra: " + Subtotal);
                Console.WriteLine("El valor del iva es de: " + Iva);
                Console.WriteLine("Total a pagar: " + TotalPagar);
                Console.WriteLine("Gracias por tu compra, vuelve pronto");
            
            }

            else
            
               if (ConsumoBasico <= 49999)
            {

                Descuento = ConsumoBasico * 0 / 100;
                Subtotal = ConsumoBasico - Descuento;
                Iva = Subtotal * 19 / 100;
                TotalPagar = Subtotal + Iva;
                Console.WriteLine("Su compra no tiene descuento");
                Console.WriteLine("Su descuento es de: " + Descuento);
                Console.WriteLine("Subtotal de la compra: " + Subtotal);
                Console.WriteLine("El valor del iva es de: " + Iva);
                Console.WriteLine("Total a pagar: " + TotalPagar);
                Console.WriteLine("Gracias por tu compra, vuelve pronto");
            
            }

           
            Console.ReadKey();
        }
    }
}

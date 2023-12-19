namespace Proyecto_Final_Nelson_Daniel_R
{
    using System;

    namespace Ejercicio_1_Nelson_Daniel_Ramirez
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int CantidadEstudiantes;
                double TotalValorSinDescuento, TotalDescuentosAplicados;
                int totalIngSistemas, totalPsicologia, totalEconomia, totalComSocial, totalAdmEmp;

                while (true)
                {
                    Console.Write("Ingrese la cantidad de estudiantes a valorar: ");
                    if (int.TryParse(Console.ReadLine(), out CantidadEstudiantes) && CantidadEstudiantes > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad de estudiantes no es un valor entero. Ingrese un número entero.");
                    }
                }

                IngresarEstudiante(CantidadEstudiantes, out totalIngSistemas, out totalPsicologia, out totalEconomia, out totalComSocial, out totalAdmEmp);

                TotalValorSinDescuento = CalcularTotalSinDescuento(totalIngSistemas, totalPsicologia, totalEconomia, totalComSocial, totalAdmEmp);
                TotalDescuentosAplicados = CalcularTotalDescuentos(totalIngSistemas, totalPsicologia, totalEconomia, totalComSocial, totalAdmEmp);

                Console.WriteLine($"Total Estudiantes De Ingenieria De Sistemas Es: {totalIngSistemas}.");
                Console.WriteLine($"Total Estudiantes De Psicologia Es: {totalPsicologia}.");
                Console.WriteLine($"Total Estudiantes De Economia Es: {totalEconomia}.");
                Console.WriteLine($"Total Estudiantes De Comunicacion social: {totalComSocial}.");
                Console.WriteLine($"Total Estudiantes De Administracion De Empresas Es: {totalAdmEmp}.");

                Console.WriteLine($"\nel total pagado por los estudiantes sin aplicar descuentos es:{TotalValorSinDescuento}");
                Console.WriteLine($"\nel total de descuentos aplicados por la universidad es:{TotalDescuentosAplicados}");
            }

            static void IngresarEstudiante(int CantidadEstudiantes, out int totalIngSistemas, out int totalPsicologia, out int totalEconomia, out int totalComSocial, out int totalAdmEmp)
            {
                int Programa, Pago;
                string NombreEstudiante;

                totalIngSistemas = 0;
                totalPsicologia = 0;
                totalEconomia = 0;
                totalComSocial = 0;
                totalAdmEmp = 0;

                for (int i = 0; i < CantidadEstudiantes; i++)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    NombreEstudiante = Console.ReadLine();

                    Console.WriteLine("\nseleccione el programa a matricular: ");
                    Console.WriteLine("\nIngenieria de sistemas-----------1");
                    Console.WriteLine("Psicologia-----------------------2");
                    Console.WriteLine("Economia-------------------------3");
                    Console.WriteLine("Comunicacion Social--------------4");
                    Console.WriteLine("Admin. De Empresas---------------5");

                    if (int.TryParse(Console.ReadLine(), out Programa) && Programa <= 5 && Programa > 0)
                    {
                        Console.WriteLine("\nSeleccione el metodo de pago: ");
                        Console.WriteLine("Efectivo---------------------1");
                        Console.WriteLine("Online-----------------------2");

                        if (int.TryParse(Console.ReadLine(), out Pago) && (Pago == 1 || Pago == 2))
                        {
                            switch (Programa)
                            {
                                case 1:
                                    totalIngSistemas++;
                                    break;
                                case 2:
                                    totalPsicologia++;
                                    break;
                                case 3:
                                    totalEconomia++;
                                    break;
                                case 4:
                                    totalComSocial++;
                                    break;
                                case 5:
                                    totalAdmEmp++;
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Metodo de pago no válido. Ingrese 1 para Efectivo o 2 para Online.");
                            i--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Programa no válido. Ingrese un numero de 1 a 5.");
                        i--;
                    }
                }
            }

            static double CalcularTotalSinDescuento(int totalIngSistemas, int totalPsicologia, int totalEconomia, int totalComSocial, int totalAdmEmp)
            {
                double VxCredito = 200000;
                int CSistemas = 20, CPsicologia = 16, CEconomia = 18, CComSocial = 18, CAdmEmp = 20;

                double TotalSinDescuento = VxCredito * (CSistemas * totalIngSistemas + CPsicologia * totalPsicologia + CEconomia * totalEconomia + CComSocial * totalComSocial + CAdmEmp * totalAdmEmp);

                return TotalSinDescuento;
            }

            static double CalcularTotalDescuentos(int totalIngSistemas, int totalPsicologia, int totalEconomia, int totalComSocial, int totalAdmEmp)
            {
                double VxCredito = 200000;

                double DescuentoSistemas = (VxCredito * 0.18 * totalIngSistemas);
                double DescuentoPsicologia = (VxCredito * 0.12 * totalPsicologia);
                double DescuentoEconomia = (VxCredito * 0.10 * totalEconomia);
                double DescuentoComSocial = (VxCredito * 0.05 * totalComSocial);
                double DescuentoAdmEmp = (VxCredito * 0.15 * totalAdmEmp);

                double TotalDescuentos = DescuentoSistemas + DescuentoPsicologia + DescuentoEconomia + DescuentoComSocial + DescuentoAdmEmp;

                return TotalDescuentos;
            }
        }
    }

}

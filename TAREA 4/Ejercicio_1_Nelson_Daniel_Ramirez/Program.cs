//NOMBRE: NELSON DANIELRAMIREZ HERNANDEZ
//GRUPO: 213022_297
//PROGRAMA: ING DE SISTEMAS
//Cantidad de estudiantes inscritos por programa académico.
//Total de créditos inscritos en el tercer período académico del 2020.
//Valor total pagado por los estudiantes sin tener en cuenta el
//descuento.
//Valor total de descuentos aplicados por la universidad a los
//estudiantes.
//Valor neto de las inscripciones del primer semestre del 2020.
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Ejercicio_1_Nelson_Daniel_Ramirez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadEstudiantes;
            double TotalValorSinDescuento, TotalDescuentosAplicados;
            List<Estudiante> ListaEstudiantes = new List<Estudiante>();


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

            IngresarEstudiante(CantidadEstudiantes, ListaEstudiantes);
            var ResultadosSis = ResultadosIngSistemas(ListaEstudiantes);
            var ResultadosPsi = ResultadosPsicologia(ListaEstudiantes);
            var ResultadosEco = ResultadosEconomia(ListaEstudiantes);
            var ResultadosCom = ResultadosComunicacionSocial(ListaEstudiantes);
            var ResultadosAdm = ResultadosAdministracionEmpresas(ListaEstudiantes);
            TotalValorSinDescuento = ResultadosSis.Item1 + ResultadosPsi.Item1 + ResultadosEco.Item1 + ResultadosCom.Item1 + ResultadosAdm.Item1;
            TotalDescuentosAplicados = ResultadosSis.Item4 + ResultadosPsi.Item4 + ResultadosEco.Item4 + ResultadosCom.Item4 + ResultadosAdm.Item4;
            Console.WriteLine($"Total Estudiantes De Ingenieria De Sistemas Es: {ResultadosSis.Item2}.");
            Console.WriteLine($"Total Creditos Inscritos De Ingenieria De Sistemas Es: {ResultadosSis.Item3}.");
            Console.WriteLine($"Total Descuentos De Ingenieria De Sistema Es:{ResultadosSis.Item4}");
            Console.WriteLine($"Total Estudiantes De Psicologia Es: {ResultadosPsi.Item2}.");
            Console.WriteLine($"Total Creditos Inscritos De Psicologia Es: {ResultadosPsi.Item3}.");
            Console.WriteLine($"Total Descuentos De Psicologia Es:{ResultadosPsi.Item4}");
            Console.WriteLine($"Total Estudiantes De Economia Es: {ResultadosEco.Item2}.");
            Console.WriteLine($"Total Creditos Inscritos De Economia Es: {ResultadosEco.Item3}.");
            Console.WriteLine($"Total Descuentos De Economia Es:{ResultadosEco.Item4}");
            Console.WriteLine($"Total Estudiantes De Comunicacion social: {ResultadosCom.Item2}.");
            Console.WriteLine($"Total Creditos Inscritos De Comunicacion Social Es: {ResultadosCom.Item3}.");
            Console.WriteLine($"Total Descuentos De Comunicacion Social Es:{ResultadosCom.Item4}");
            Console.WriteLine($"Total Estudiantes De Administracion De Empresas Es: {ResultadosAdm.Item2}.");
            Console.WriteLine($"Total Creditos Inscritos De Administracion De Empresas Es: {ResultadosAdm.Item3}.");
            Console.WriteLine($"Total Descuentos De Administracion Empresas Es:{ResultadosAdm.Item4}");
            Console.WriteLine($"\nel total pagado por los estudiantes sin aplicar descuentos es:{TotalValorSinDescuento}");
            Console.WriteLine($"\nel total de descuentos aplicados por la universidad es:{TotalDescuentosAplicados}");
            MostrarResultados(ListaEstudiantes);
          
        }

        static void IngresarEstudiante (int CantidadEstudiantes, List<Estudiante> ListaEstudiantes)
        {
            int Programa, Pago;
            string NombreEstudiante;
            

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
                        ListaEstudiantes.Add(new Estudiante { Nombre = NombreEstudiante, Programa = Programa, Pago = Pago});                        
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


        static (double, int, int, double, int) ResultadosIngSistemas (List<Estudiante> ListaEstudiantes)
        {
            int TotalIngSistemas = 0,Sistemas = 1, CSistemas = 20, TotalCreditos, EstudiantesConDescuento;
            double VxCredito = 200000, TotalSinDescuento, TPEstudiantesD;

            TotalIngSistemas = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == Sistemas);
            EstudiantesConDescuento = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == Sistemas && Estudiante.Pago == 1 );
            TotalCreditos = CSistemas * TotalIngSistemas;
            TPEstudiantesD = ((VxCredito * CSistemas) * 0.18) * EstudiantesConDescuento;
            TotalSinDescuento = VxCredito * TotalCreditos;
                              
            return (TotalSinDescuento,TotalIngSistemas,TotalCreditos, TPEstudiantesD, EstudiantesConDescuento);
        }
        static (double, int, int, double) ResultadosPsicologia(List<Estudiante> ListaEstudiantes) 
        {
            int TotalPsicologia = 0, Psicologia = 2, CPsicologia = 16, TotalCreditos, EstudiantesConDescuento;
            double VxCredito = 200000, TotalSinDescuento, TPEstudiantesD;

            TotalPsicologia = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == Psicologia);
            EstudiantesConDescuento = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == Psicologia && Estudiante.Pago == 1);
            TotalCreditos = CPsicologia * TotalPsicologia;
            TotalSinDescuento = VxCredito * TotalCreditos;
            TPEstudiantesD = ((VxCredito * CPsicologia) * 0.12) * EstudiantesConDescuento;
                    
            return (TotalSinDescuento, TotalPsicologia, TotalCreditos, TPEstudiantesD);
        }

        static (double, int, int, double) ResultadosEconomia(List<Estudiante> ListaEstudiantes)
        {
            int TotalEconomia = 0, Economia = 3, CEconomia = 18, TotalCreditos, EstudiantesConDescuento; 
            double VxCredito = 200000, TotalSinDescuento, TPEstudiantesD;

            TotalEconomia = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == Economia);
            EstudiantesConDescuento = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == Economia && Estudiante.Pago == 1);
            TotalCreditos = CEconomia * TotalEconomia;
            TotalSinDescuento = VxCredito * TotalCreditos;
            TPEstudiantesD = ((VxCredito * CEconomia) * 0.10) * EstudiantesConDescuento;
            
            return (TotalSinDescuento,TotalEconomia,TotalCreditos, TPEstudiantesD);
        }

        static (double, int, int, double) ResultadosComunicacionSocial(List<Estudiante> ListaEstudiantes)
        {
            int TotalComSocial = 0, ComSocial = 4, CComSocial = 18, TotalCreditos, EstudiantesConDescuento; 
            double VxCredito = 200000, TotalSinDescuento, TPEstudiantesD;

            TotalComSocial = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == ComSocial);
            EstudiantesConDescuento = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == ComSocial && Estudiante.Pago == 1);
            TotalCreditos = CComSocial * TotalComSocial;
            TotalSinDescuento = VxCredito * TotalCreditos;
            TPEstudiantesD = ((VxCredito * CComSocial) * 0.05) * EstudiantesConDescuento;
            
            return (TotalSinDescuento, TotalComSocial, TotalCreditos, TPEstudiantesD);
        }

        static (double, int, int, double) ResultadosAdministracionEmpresas(List<Estudiante> ListaEstudiantes)
        {
            int TotalAdmEmp = 0, AdmEmp = 5, CAdmEmp = 20, TotalCreditos, EstudiantesConDescuento;
            double VxCredito = 200000, TotalSinDescuento, TPEstudiantesD;

            TotalAdmEmp = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == AdmEmp);
            EstudiantesConDescuento = ListaEstudiantes.Count(Estudiante => Estudiante.Programa == AdmEmp && Estudiante.Pago == 1);
            TotalCreditos = CAdmEmp * TotalAdmEmp;
            TotalSinDescuento = VxCredito * TotalCreditos;
            TPEstudiantesD = ((VxCredito * CAdmEmp) * 0.15) * EstudiantesConDescuento;
            
            return (TotalSinDescuento, TotalAdmEmp, TotalCreditos,TPEstudiantesD);
        }

        static void MostrarResultados(List<Estudiante> ListaEstudiantes)
        {
            
            Console.WriteLine("\nLista de estudiantes:");

            foreach (Estudiante estudiante in ListaEstudiantes)
            {
                Console.WriteLine($"Usuario: {estudiante.Nombre},------{estudiante.Programa},------{estudiante.Pago}");
            }
        }

    }

    class Estudiante
    {
        public string Nombre { get; set; }
        public int Programa { get; set; }
        public int Pago { get; set; }
    }
}
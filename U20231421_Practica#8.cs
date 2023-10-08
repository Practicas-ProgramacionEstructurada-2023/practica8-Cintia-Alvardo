using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú de Opciones");
                Console.WriteLine("1. Sumar dos números enteros.");
                Console.WriteLine("2. Calcular salario.");
                Console.WriteLine("3. Calcular salario neto.");
                Console.WriteLine("4. Salir");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("\nIngresa el primer número: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Ingrese el segundo número: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            SumaDosNumeros(num1, num2);
                            break;

                        case 2:
                            Console.Write("\nIngrese el número de horas trabajadas: ");
                            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Ingrese el precio por horas: ");
                            double precioPorHora = Convert.ToDouble(Console.ReadLine());

                            CalcularSalario(horasTrabajadas, precioPorHora);
                            break;

                        case 3:
                            Console.Write("\nIngrese el número de horas trabajadas: ");
                            int hTrabajadas = Convert.ToInt32(Console.ReadLine());

                             Console.Write("Ingrese el precio por horas: ");
                            double precioPHora = Convert.ToDouble(Console.ReadLine());

                            CalcularSalarioNeto(hTrabajadas, precioPHora);
                            break;

                        case 4:
                        Console.WriteLine("\nSaliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nOpción no válida intente de nuevo. ");
                }

            } while (opcion != 4);
        }
        static void SumaDosNumeros(int num1, int num2)
        {
            int suma = num1 + num2;
            Console.WriteLine("\nLa Suma es: " + suma);
        }

        static void CalcularSalario(int horasTrabajadas, double precioPorHora)
        {
            double salario = horasTrabajadas * precioPorHora;

            Console.WriteLine("\nEl salario es: $" + salario);
        }

        static void CalcularSalarioNeto(int hTrabajadas, double precioPHora)
        {
            double salarioNeto = hTrabajadas * precioPHora;
            double limiteISSS = 30;

            if (salarioNeto > 1000)
            {
                salarioNeto -= limiteISSS;
            }
            Console.WriteLine("\nEl slario es: $" + salarioNeto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSelecCap5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            Console.WriteLine("\n1. Ejercicios del Capitulo 5\n2. Ejercicios del Capitulo 6.\n3. Ejercicios del Capitulo 8\n4.Salir.");
            Console.WriteLine("\nDigite la opción deseada: ");
            respuesta = Convert.ToInt32(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.Clear();
                int r;
                Cap5Ejer4_5 c = new Cap5Ejer4_5();
                Console.WriteLine("\n1. Factorial 4.\n2. Numero A Letra 5.\n3. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.CincoCuatro();
                        break;
                    case 2:
                        Console.Clear();
                        String numero = "";
                        Console.Write("Digite el número: ");
                        numero = Console.ReadLine();
                        c.CincoCinco(numero, true);
                        Console.WriteLine(c.CincoCinco(numero, true));
                        break;
                    case 3:
                        break;
                }
            }
            else if (respuesta == 2)
            {
                Console.Clear();
                int r;
                Cap7Ejer1_2_5 c = new Cap7Ejer1_2_5();
                Console.WriteLine("\n1. Ejercicio 1.\n2. Ejercicio 2.\n3. Ejercicio 5.\n4. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.SieteUno();
                        break;
                    case 2:
                        Console.Clear();
                        c.SieteDos();
                        break;
                    case 3:
                        Console.Clear();
                        c.SieteCinco();
                        break;
                    case 4:
                        break;
                }
            }

            else if (respuesta == 3)
            {
                Console.Clear();
                int r;
                Cap8Ejer3_5 c = new Cap8Ejer3_5();
                Console.WriteLine("\n1. Ejercicio 3.\n2. Ejercicio 5.\n3. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.OchoTres();
                        break;
                    case 2:
                        Console.Clear();
                        c.OchoCinco();
                        break;
                    case 3:
                        break;
                }
            }

            else if (respuesta == 4)
                System.Environment.Exit(-1);
        }
    }
}
using System;

namespace Buscador_Numero_Naturales_Perfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            long control;
            long i;
            long j;
            long rangoini;
            long rangomax;
            Console.WriteLine("Bienvenido al Buscador de Numeros Naturales Perfectos");
            Console.WriteLine("");
            Console.WriteLine("Por favor indique el rango inicial de busqueda");
            rangoini = int.Parse(Console.ReadLine());
            if (rangoini < 2)
            {
                rangoini = 2;
            }
            Console.WriteLine("Ahora indique el rango Maximo de busqueda");
            rangomax = long.Parse(Console.ReadLine());
            if (rangomax < rangoini)
            {
                Console.WriteLine("Por favor indica un número mayor al rango inicial");
                rangomax = long.Parse(Console.ReadLine());
            }
            for (i = rangoini; i <= rangomax; i++)
            {
                control = 0;
                if (i % 2 == 0)
                {
                    for (j = 1; j <= Decimal.Truncate(i / 2); j++)
                    {
                        if (i % j == 0)
                        {
                            control = control + j;
                        }
                    }
                }
                if (control == 6)
                {
                    Console.WriteLine("El número " + i + " es natural perfecto.");
                    i = 27;
                }
                else
                {
                    if (control == 28)
                    {
                        Console.WriteLine("El número " + i + " es natural perfecto.");
                        i = 495;
                    }
                    else
                    {
                        if (control == 496)
                        {
                            Console.WriteLine("El número " + i + " es natural perfecto.");
                            i = 8127;
                        }
                        else
                        {
                            if (control == 8128)
                            {
                                Console.WriteLine("El número " + i + " es natural perfecto.");
                                i = 33550335;
                            }
                            else
                            {
                                if (control == 33550336)
                                {
                                    Console.WriteLine("El número " + i + " es natural perfecto.");
                                    i = 8589869055;
                                }
                                else
                                {
                                    if (control == 8589869056)
                                    {
                                        Console.WriteLine("El número " + i + " es natural perfecto.");
                                        i = rangomax;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

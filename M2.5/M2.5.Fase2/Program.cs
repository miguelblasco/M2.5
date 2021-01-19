using System;
using System.Collections.Generic;
using System.Linq;

namespace M2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumeros;

            arrNumeros = new int[15]; //inicialización array
                                      //array con los datos del enunciado

            arrNumeros[0] = 2;
            arrNumeros[1] = 6;
            arrNumeros[2] = 8;
            arrNumeros[3] = 4;
            arrNumeros[4] = 5;
            arrNumeros[5] = 5;
            arrNumeros[6] = 9;
            arrNumeros[7] = 2;
            arrNumeros[8] = 1;
            arrNumeros[9] = 8;
            arrNumeros[10] = 7;
            arrNumeros[11] = 5;
            arrNumeros[12] = 9;
            arrNumeros[13] = 6;
            arrNumeros[14] = 4;



            IEnumerable<int> numerosPares = from numero in arrNumeros where numero % 2 == 0 select numero;

            
            Console.WriteLine("1.-Cálculo de la nota media: \n");

            var total = numerosPares.Sum();
            var avg = numerosPares.Average();
            Console.WriteLine(avg);

            Console.WriteLine("\n");
            Console.WriteLine("2.-Cálculo de la nota máxima: \n");

            var notaMax = numerosPares.Max();
            Console.WriteLine(notaMax);

            Console.WriteLine("\n");
            Console.WriteLine("3.-Cálculo de la nota mínima: \n");

            var notaMin = numerosPares.Min();
            Console.WriteLine(notaMin);
        }
    }
}


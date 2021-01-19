using System;
using System.Collections.Generic;
using System.Linq;

namespace M2._5.Fase3
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


            Console.WriteLine("Se muestran los números > 5 del array: \n");

            IEnumerable<int> numSupCinco = from numero in arrNumeros where numero > 5 select numero;

            foreach (int i in numSupCinco)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Se muestran los números < 5 del array: \n");

            IEnumerable<int> numInfCinco = from numero in arrNumeros where numero < 5 select numero;

            foreach (int i in numInfCinco)
            {
                Console.WriteLine(i);
            }
        }
    }
}
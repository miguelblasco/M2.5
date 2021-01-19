using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrNombres = new List<string>() //creación array del enunciado
            {
                 "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol"
            };

            Console.WriteLine("\n");
            Console.WriteLine("Array de nombres que muestra los que empiezan por la letra 'O': \n");

            IEnumerable<string> startArrNombres = from inicial in arrNombres
                                                  where inicial.Contains('O')
                                                  select inicial;

            foreach (string arrNombre in startArrNombres)
                Console.WriteLine(arrNombre);

            Console.WriteLine("\n");
            Console.WriteLine("Array de nombres que muestra los que tienen 4 ó más letras: \n");

            // var mNames = listOfNames.Where(x => x.Length <= 4);

            public CharEnumerator GetEnumerator();




            Console.WriteLine("\n");
            Console.WriteLine("Array de nombres ordenado de forma descendente: \n");

            List<string> sortedArrNombres = arrNombres.OrderByDescending(nombre => nombre).ToList();

            foreach (string arrNombre in sortedArrNombres)
                Console.WriteLine(arrNombre);

        }
    }
}

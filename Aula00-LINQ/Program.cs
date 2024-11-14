using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula00_LINQ
{

    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            var pares = from n in numeros
                        where n % 2 == 0
                        select n;

            foreach (var numero in pares)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Pressione Enter...");
            Console.ReadKey();
        }
    }
}

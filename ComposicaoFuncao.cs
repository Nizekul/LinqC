//using FuncaoAltaOrdemLINQ;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// Composição de funções
//namespace FuncaoAltaOrdemLINQ
//{
//    internal class Program2
//    {
//        static void Main()
//        {
//            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

//            // Exemplo 1: Dobrar cada número e depois filtrar os pares
//            var resultado1 = numeros.Select(num => num * 3).Where(num => num % 2 == 0);
//            Console.WriteLine(string.Join(", ", resultado1));

//            // Exemplo 2: Elevar ao quadrado e pegar os primeiros 3
//            var resultado2 = numeros.Select(num => num * num).Take(3);
//            Console.WriteLine(string.Join(", ", resultado2));

//            // Exemplo 3: Filtrar os ímpares, dobrar e depois ordenar
//            var resultado3 = numeros.Where(num => num % 2 != 0).Select(num => num * 2).OrderBy(num => num);
//            Console.WriteLine(string.Join(", ", resultado3));

//            Console.ReadKey();
//        }
//    }
//}

//using System;

//public static class CurryingExample
//{
//   // Função original que soma três números
//   public static int Soma(int a, int b, int c)
//   {
//       return a + b + c;
//   }

//   // Função curried que soma dois números e retorna uma nova função
//   public static Func<int, Func<int, int>> CurriedSoma = a => b => a + b;

//   public static Func<int, Func<int, Func<int, int>>> CurriedSoma3Num = a => b => c => a + b + c;

//   static void Main()
//   {
//       // Usando a função original
//       int resultado1 = Soma(1, 2, 3);
//       Console.WriteLine($"Resultado 1: {resultado1}");

//       // Usando a função curried
//       var funcaoParcial = CurriedSoma(1);
//       int resultado2 = funcaoParcial(2);
//       Console.WriteLine($"Resultado 2: {resultado2}");

//       // Ou em uma única linha
//       int resultado3 = CurriedSoma(2)(2);
//       Console.WriteLine($"Resultado 3: {resultado3}");

//       // Soma 3 numeros
//       int resultado = CurriedSoma3Num(1)(2)(3);
//       Console.WriteLine($"Resultado: {resultado}");

//       Console.ReadKey();
//   }
//}
//using FuncaoAltaOrdemLINQ;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Pessoa
//{
//    public string Nome { get; }
//    public int Idade { get; }

//    public Pessoa(string nome, int idade)
//    {
//        Nome = nome;
//        Idade = idade;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Pessoa pessoa1 = new Pessoa("Alice", 30);
//        Console.WriteLine($"Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");

//        // Isso não é possível porque os atributos são somente leitura
//        // pessoa1.Nome = "Bob";
//        // pessoa1.Idade = 25;

//        Pessoa pessoa2 = new Pessoa("Bob", 25);
//        Console.WriteLine($"Nome: {pessoa2.Nome}, Idade: {pessoa2.Idade}");

//        Console.ReadKey();
//    }
//}
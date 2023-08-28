using FuncaoAltaOrdemLINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuncaoAltaOrdemLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de objetos de Livros
            var livrosBiblioteca = new List<LivroBO>();

            // Adicionando Livros a lista
            livrosBiblioteca.Add(new LivroBO { Titulo = "Livro - 1", Emprestado = false });
            livrosBiblioteca.Add(new LivroBO { Titulo = "Livro - 2", Emprestado = true });
            livrosBiblioteca.Add(new LivroBO { Titulo = "Livro - 3", Emprestado = false });
            livrosBiblioteca.Add(new LivroBO { Titulo = "Livro - 4", Emprestado = true });

            //Console.WriteLine("----> Livros Cadastrados <----");

            //var livros = livrosBiblioteca.Select(livro => $"Livro: {livro.Titulo}");
            //Console.WriteLine(string.Join(Environment.NewLine, livros));

            ////ImprimeLista(livros);

            //var livrosEmprestados = livrosBiblioteca.Where(livro => livro.Emprestado);
            ////bool isEmprestado(LivroBO livrobo){
            ////    return livrobo.Emprestado;
            ////}
            //Console.WriteLine("----> Livros Emprestados <----");
            //ImprimeLista(livrosEmprestados);

            //// Primeiro livro emprestado - Obs se n tiver o primero elemento
            //var primeiroLivroEmprestado = livrosBiblioteca.First(livro => livro.Emprestado);
            //Console.WriteLine($"Primeiro livro emprestado: {primeiroLivroEmprestado.Titulo}");

            //// Primeiro Livro
            //var primeiroLivroEmprestadoOuNulo = livrosBiblioteca.FirstOrDefault(livro => livro.Emprestado);
            //if (primeiroLivroEmprestadoOuNulo != null)
            //{
            //    Console.WriteLine($"Primeiro livro emprestado: {primeiroLivroEmprestadoOuNulo.Titulo}");
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum livro emprestado encontrado.");
            //}

            //// verifica se so tem 1
            //var livroUnico = livrosBiblioteca.Single(livro => livro.Titulo == "Livro - 2");
            //Console.WriteLine($"Livro único encontrado: {livroUnico.Titulo}");

            //// verifica se so tem 1 mas se n tiver tranquilo
            //var livroUnicoOuNulo = livrosBiblioteca.SingleOrDefault(livro => livro.Titulo == "Livro - 5");
            //if (livroUnicoOuNulo != null)
            //{
            //    Console.WriteLine($"Livro único encontrado: {livroUnicoOuNulo.Titulo}");
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum livro único encontrado.");
            //}

            //// ordena a lista
            //var livrosOrdenadosPorTitulo = livrosBiblioteca.OrderBy(livro => livro.Titulo);
            //ImprimeLista(livrosOrdenadosPorTitulo);

            //// ordena a lista decrescente
            //var livrosOrdenadosPorTituloDesc = livrosBiblioteca.OrderByDescending(livro => livro.Titulo);
            //ImprimeLista(livrosOrdenadosPorTituloDesc);

            //// skipa quantos quiser
            //var livrosAposPrimeirosDois = livrosBiblioteca.Skip(2);
            //ImprimeLista(livrosAposPrimeirosDois);

            //// pega uma qnt de elementos
            //var primeirosDoisLivros = livrosBiblioteca.Take(3);
            //ImprimeLista(primeirosDoisLivros);

            //// Reduce
            //int totalEmprestados = livrosBiblioteca.Aggregate(0, (total, livro) => total + (livro.Emprestado ? 1 : 0));
            //Console.WriteLine($"Total de livros emprestados: {totalEmprestados}");


            int totalEmprestados = ContarLivrosEmprestados(livrosBiblioteca, 0);

            Console.WriteLine($"Total de livros emprestados: {totalEmprestados}");

            void ImprimeLista(IEnumerable<LivroBO> lista)
            {
                foreach (var livrobo in lista)
                {
                    Console.WriteLine($"Livro: {livrobo.Titulo}");
                }
            }


            Console.ReadKey();

        }

        static int ContarLivrosEmprestados(List<LivroBO> livros, int index)
        {
            if (index >= livros.Count)
            {
                return 0; // Condição de parada: chegamos ao final da lista
            }

            int emprestadosNesteLivro = livros[index].Emprestado ? 1 : 0;
            int emprestadosNosProximosLivros = ContarLivrosEmprestados(livros, index + 1);

            return emprestadosNesteLivro + emprestadosNosProximosLivros;
        }
    }
}
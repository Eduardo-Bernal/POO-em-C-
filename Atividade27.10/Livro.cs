
using System.Security.Cryptography.X509Certificates;

namespace Atividade27._10
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }


        public int AnoPublicacao { get; set; }
        // {
        //     get
        //     {
        //         return AnoPublicacao;
        //     }
        //     set
        //     {
        //         if (value > 0)
        //         {
        //             AnoPublicacao = value;
        //         }
        //         else
        //         {
        //             Console.WriteLine("Erro! ANo de publicacao é invalido!");
        //         }
        //     }
        // }
        public Double Preco { get; set; }
        public bool EstaDisponivel { get; set; } = true;

        // CONSTRUTOR
        // é um metodo especial, usado para inicializar o estado do objeto.

        public Livro(String tituloConstrutor, string autorConstrutor, int AnoConstrutor, double precoConstrutor)
        {
            //this.Titulo = titulo
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = AnoConstrutor;
            Preco = precoConstrutor;

            //definindo valor inicial como true
            EstaDisponivel = true;

            Console.WriteLine($"Novo livro: {tituloConstrutor} criado e disponivel");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("*** DETALHES DO LIVRO ***");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicacao: {AnoPublicacao}");
            Console.WriteLine($"Preço: {Preco:F2}");// F2 Formata com duas casa decimais


            if (EstaDisponivel)

            {
                Console.WriteLine("Status: Disponivel para Emprestimo");
            }
            else
            {
                Console.WriteLine("Status: Emprestado! (Indisponivel)");
            }
        }

            public void Emprestar()
        {
            if (EstaDisponivel)
            {
                EstaDisponivel = false;
                Console.WriteLine("Status: Disponivel para Emprestimo");

            }
            else
            {
            Console.WriteLine("Status: Disponivel para Emprestimo");
            }
        }
        }
    }

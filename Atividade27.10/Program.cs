namespace Atividade27._10;

class Program
{
    static void Main(string[] args)
    {
        //SEM CONSTRUTOR
        // Livro novoLivro = new Livro();// Sem parametros

        // Console.WriteLine($"Titulo: {novoLivro.Titulo}");
        // Console.WriteLine($"Ano: {novoLivro.AnoPublicacao}");
        // Console.WriteLine($"Disponivel: {novoLivro.EstaDisponivel}");

        // //Colocando valores manualmente
        // novoLivro.Titulo = "O poder do Construtor";
        // novoLivro.Autor = "Parceiro de Programacao";
        // novoLivro.AnoPublicacao = 2025;
        // novoLivro.Preco = 59.90;
        // novoLivro.EstaDisponivel = true;

        // Console.WriteLine("Exibindo detalhes: ");
        // novoLivro.ExibirDetalhes();


        //COM CONSTRUTOR
        Console.WriteLine("Sistemas de controle de biblioteca");

        //criando objeto novo com construtor
        Livro livro1 = new Livro("A arte da Guerra", "Sun Tzu", 1950, 45.90);
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899, 30.50);

        // Interacao com os livros - emprestar / ver detalhes
        Console.WriteLine("Interagindo com o livro 1");
        livro1.ExibirDetalhes();
        livro1.Emprestar();
        livro1.ExibirDetalhes();
        livro1.Emprestar();

        Console.WriteLine("\n Interagindo com livro 2");
        livro2.ExibirDetalhes();
        livro2.Preco = 32.99;
        Console.WriteLine($"Atualizacao de preco: {livro2.Titulo} ajustado para R${livro2.Preco:F2}");
        livro2.ExibirDetalhes();
    }
}

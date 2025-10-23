// Define o namespace (um tipo de “pasta” ou agrupamento lógico de classes)
namespace Aula_de_POO
{
    // Classe principal do programa
    class Program
    {
        // Método principal — é o primeiro a ser executado quando o programa roda
        static void Main(string[] args)
        {
            // Cria um novo objeto do tipo Pessoa e já define os valores de Nome e Idade
            Pessoa p = new Pessoa
            {
                Nome = "Eduardo",
                Idade = 18
            };

            // Cria um novo objeto do tipo Aluno (que herda de Pessoa)
            // Além de nome e idade, também tem o atributo Curso
            Aluno a = new Aluno
            {
                Nome = "Paulo",
                Idade = 20,
                Curso = "Desenvolvimento de Sistemas"
            };

            // Chama o método Apresentar da classe Pessoa
            // Mostra uma mensagem com o nome e idade da pessoa
            p.Apresentar();

            // Chama o método Apresentar da classe Aluno
            // Mostra uma mensagem com nome, idade e curso do aluno
            a.Apresentar();
        }
    }
}

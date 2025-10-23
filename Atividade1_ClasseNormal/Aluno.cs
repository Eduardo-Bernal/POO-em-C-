// Mesmo namespace da Pessoa para que as classes se “enxerguem”
namespace Aula_de_POO
{
    // Classe Aluno herda da classe Pessoa
    // Isso significa que Aluno tem todos os atributos e métodos de Pessoa
    public class Aluno : Pessoa
    {
        // Novo atributo exclusivo da classe Aluno
        public string Curso;

        // Sobrescreve (override) o método Apresentar da classe Pessoa
        // Assim, o Aluno pode se apresentar de um jeito diferente
        public override void Apresentar()
        {
            // Mostra nome, idade e curso
            Console.WriteLine($"Sou o(a) {Nome}, tenho {Idade} anos e estudo {Curso}.");
        }
    }
}

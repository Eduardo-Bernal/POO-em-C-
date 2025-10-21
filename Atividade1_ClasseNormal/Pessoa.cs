// Mesmo namespace para manter tudo organizado
namespace Aula_de_POO
{
    // Declaração da classe Pessoa (classe "pai" ou base)
    public class Pessoa
    {
        // Atributo público que armazena o nome da pessoa
        public string Nome;

        // Atributo público que guarda a idade da pessoa
        public int Idade;

        // O modificador "virtual" permite que o método seja sobrescrito (alterado) em uma classe filha
        public virtual void Apresentar()
        {
            // Mostra uma mensagem no console com o nome e idade
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}

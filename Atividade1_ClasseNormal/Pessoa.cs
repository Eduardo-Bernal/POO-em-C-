namespace Aula_de_POO
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        //Virtual - vamos utilizar o metodo em outra classe, podendo sobrescrever
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
namespace Aula_de_POO
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o(a) {Nome}, tenho {Idade} anos e estudo {Curso}.");
        }
    }
}
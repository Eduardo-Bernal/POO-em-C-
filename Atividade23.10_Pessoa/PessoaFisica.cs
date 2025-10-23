namespace Atividade23._10_Pessoa
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; } = string.Empty;

        public DateTime DataNascimento { get; set; }

        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa fisica: {Nome}, CPF: {CPF} - Pagando imposto...");
        }
    }
}
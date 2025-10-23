namespace Atividade23._10_Pessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;

                public override void PagarImposto()
        {
            Console.WriteLine($"Razao Social: {RazaoSocial}, CNPJ: {CNPJ} - Pagando imposto...");
        }
    }
}
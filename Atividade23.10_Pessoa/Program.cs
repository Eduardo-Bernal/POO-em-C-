namespace Atividade23._10_Pessoa;

class Program
{
    static void Main(string[] args)
    {
        PessoaFisica pf = new PessoaFisica
        {
            Nome = "Eduardo Bernal",
            CPF = "48976698099",
            DataNascimento = new DateTime(2007, 7, 17)
        };

        pf.AdicionarEndereco(new Endereco
        {
            Rua = "Rua das flores",
            Numero = 100,
            Cidade = "Sao paulo",
            Estado = "SP",
            Cep = "02450-333",
            Comercial = false
        });

        PessoaJuridica pj = new PessoaJuridica
        {
            Nome = "Loja Exemplo",
            RazaoSocial = "Loja exemplo",
            CNPJ = "12.345.678/0001-99",

        };

        pj.AdicionarEndereco(new Endereco
        {
            Rua = "Jardins",
            Numero = 100,
            Cidade = "Santo andre",
            Estado = "SP",
            Cep = "02450-333",
            Comercial = true
        });

        pf.PagarImposto();
        pj.PagarImposto();


    }
}

namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        //Metodo abstrato obriga a classe filha a implementar o metodo
        //e usar override
        public abstract double CalcularArea();
        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica.");
        }
    }
}
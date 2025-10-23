using System.Net.Http.Headers;

namespace Atividade3_Interface;

class Program
{
    static void Main(string[] args)
    {
        Cachorro c = new Cachorro();
        Gato g = new Gato();

        c.EmitirSom();
        g.EmitirSom();
    }
}

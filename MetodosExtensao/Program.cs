using System;

namespace MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o que você quer inverter: ");
            string frase = Console.ReadLine();            
            Console.WriteLine("Sua nova frase: {0}", frase.InverterCaixas(false));
            Console.WriteLine("Uma frase qualquer".InverterCaixas(true));
        }
    }
}

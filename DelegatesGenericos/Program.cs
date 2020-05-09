using System;
using System.Reflection;

namespace DelegatesGenericos
{
    class Program
    {
        //Declaração verbosa
        //delegate T CalculoMatemático<T>(T a, T b);
        
        static void Main(string[] args)
        {
            Program p = new Program();
            //CalculoMatemático<int> calculo = new CalculoMatemático<int>(p.Somar);
            //ExibirInformacoesClaculo(calculo);
            Func<int, int, int> calculo = p.Somar;
            Action<int> impressao = p.ImprimirResultado;  
            Console.WriteLine(p.Somar(2, 11));
            impressao(calculo(1, 11));
        }

        /*
        static void ExibirInformacoesClaculo<T>(CalculoMatemático<T> calculo)
        {
            Console.WriteLine(calculo.Target);
            Console.WriteLine(calculo.Method);
        }
        */

        void ImprimirResultado<T>(T resultado)
        {
            Console.WriteLine(resultado);
        }

        int Somar(int a, int b)
        {
            return a + b;
        }

        decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }
    }
}

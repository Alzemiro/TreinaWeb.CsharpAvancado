using System;

namespace DelegatesMulticast
{
    class Program
    {
        delegate void VerificacaoIdade(int idade);
        static VerificacaoIdade verificadorIdade;
        static void Main(string[] args)
        {
            //Usuario informa se ele é homem ou mulher
            //Usuario tb informa a idade

            //Se for homem:
            //Se tiver menos de 21 anos: "Você ainda está crescendo"
            //Se ele tiver mais que 21 anos: "Você já cresceu"
            //Se ele tiver menos que 25 anos: "Você pode carregar bastante peso"
            //Se ele tiver menos que 25 anos: "Você não pode carregar tanto peso"

            //Se for mulher:
            //Se tiver menos de 18 anos: "Você ainda está crescendo"
            //Se ele tiver mais que 18 anos: "Você já cresceu"
            //Se ele tiver menos que 30 anos: "Você pode carregar bastante peso"
            //Se ele tiver menos que 30 anos: "Você não pode carregar tanto peso"

            Console.WriteLine("Digite seu sexo: ");
            string sexoUsuario = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());

            if (sexoUsuario.Equals("H"))
            {
                verificadorIdade = new VerificacaoIdade(VarificaIdadeHomem);
                verificadorIdade += VarificaCarregamentoHomem;
            }
            else
            {
                verificadorIdade = new VerificacaoIdade(VarificaIdadeMulher);
                verificadorIdade += VarificaCarregamentoMulher;
            }
            verificadorIdade(idadeUsuario);

        }

        // Homens
        static void VarificaIdadeHomem(int idade)
        {
            if(idade < 21)
            {
                Console.WriteLine("Você ainda está crescendo");
            }
            else
            {
                Console.WriteLine("Você já cresceu");
            }
        }

        static void VarificaCarregamentoHomem(int idade)
        {
            if (idade > 25)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
        }

        static void VarificaIdadeMulher(int idade)
        {
            if (idade < 18)
            {
                Console.WriteLine("Você ainda está crescendo");
            }
            else
            {
                Console.WriteLine("Você já cresceu");
            }
        }

        static void VarificaCarregamentoMulher(int idade)
        {
            if (idade > 30)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
        }
    }
}

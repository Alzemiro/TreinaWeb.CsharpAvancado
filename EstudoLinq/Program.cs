using System;
using System.Linq;
using System.Collections.Generic;

namespace EstudoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = CarregarListaPessoa();
            //1. Todas as pessoas com mais de 2 irmãos
            /*IEnumerable<Pessoa> pessoasMaisDoisIrmaos = from pessoa in pessoas
                                                        where pessoa.QuantidadeIrmaos > 2
                                                     select pessoa;
            */

            var pessoasMaisDoisIrmaos = pessoas.Where(w => w.QuantidadeIrmaos > 2);

            foreach(Pessoa p in pessoasMaisDoisIrmaos)
            {
                Console.WriteLine("{0}, {1}, {2}", p.Nome, p.Idade, p.QuantidadeIrmaos);
            }

            //2. Nome e idade de todas as pessoas maiores de idade
            /*var pessoasMaioresIdade = from pessoa in pessoas
                                      where pessoa.Idade > 18
                                      orderby pessoa.Idade descending
                                      select new { pessoa.Nome, pessoa.Idade };*/
            var pessoasMaioresIdade = pessoas
                                         .Where(w => w.Idade > 18)
                                         .OrderByDescending(ob => ob.Nome.Length)
                                         .ThenBy(tb => tb.Idade)
                                         .Select(s => new { s.Nome, s.Idade });
            Console.WriteLine("*****************************************");
            foreach (var p in pessoasMaioresIdade)
            {
                Console.WriteLine("{0}, {1}", p.Nome, p.Idade);
            }
            
        }

        static List<Pessoa> CarregarListaPessoa()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa
            {
                Nome = "João",
                Idade = 18,
                QuantidadeIrmaos = 2
            });
            pessoas.Add(new Pessoa
            {
                Nome = "Maria",
                Idade = 30,
                QuantidadeIrmaos = 0
            });
            pessoas.Add(new Pessoa
            {
                Nome = "José",
                Idade = 50,
                QuantidadeIrmaos = 6
            });
            return pessoas;
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeIrmaos { get; set; }

    }
}

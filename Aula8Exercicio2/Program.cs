using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Aula8Exercicio2
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            List<Produto> produtos = carregaProdutos();            
            
            Action<List<Produto>, List<Produto>> Exibir = (p1, p2) => 
            {
                var resultado = from produto in p1
                                join produto2 in p2 on produto._descricao equals produto2._descricao
                                select new { produto._descricao, 
                                            valorAntigo = produto._valor, 
                                            valorNovo = produto2._valor };
                foreach(var p in resultado)
                {
                    Console.WriteLine("{0}: Valor sem desconto {1}, Valor com desconto {2}", 
                                        p._descricao, 
                                        p.valorAntigo.ToString("C"),
                                        p.valorNovo.ToString("C"));
                }                 
                               
            };

            Func<List<Produto>, List<Produto>> Desconto = (lista) => 
            {
                foreach(var p in lista)
                {
                    if(p._quantidade > 100)
                    {
                        p._valor = p._valor - (p._valor * 0.1M);
                    }
                    
                }                
                return lista;
            };

            List<Produto> comDesconto = Desconto(produtos);
            Exibir(carregaProdutos(), comDesconto);                   

            
        }
        static List<Produto> carregaProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto
            {
                _descricao = "Azeite",
                _valor = 5.00M,
                _quantidade = 200
            });
            produtos.Add(new Produto
            {
                _descricao = "Arroz",
                _valor = 4.85M,
                _quantidade = 30
            });
            produtos.Add(new Produto
            {
                _descricao = "Mingau",
                _valor = 12.78M,
                _quantidade = 101
            });
            return produtos;
        }
        

    }

    class Produto
    {
        public string _descricao { get; set; }
        public decimal _valor { get; set; }
        public int _quantidade { get; set; }        

    }
}

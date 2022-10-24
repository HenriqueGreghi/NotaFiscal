using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TesteNota
{
    public class Produto
    {
        public string Nome;
        public int Quantidade;
        public decimal Preco;
        public decimal ValorTotal=0;

        public Produto()
        {

        }

        public Produto(string nome, int quantidade, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }
        public List<Produto> listProdutos = new List<Produto>();
        public void Lista()
        {
            
            Console.Write("Quantos produtos deseja cadastrar? ");
            int cadastro = int.Parse(Console.ReadLine());
            for (int i = 0; i < cadastro; i++)
            {
                
                Console.Write("Nome do produto:");
                Nome = Console.ReadLine();
                Console.Write("Quantidade:");
                Quantidade = int.Parse(Console.ReadLine());
                Console.Write("Preço:");
                Preco = decimal.Parse(Console.ReadLine());

                listProdutos.Add(new Produto(Nome, Quantidade, Preco));
            }
        }
        public void ImprimirLista()
        {
            
            foreach (var product in listProdutos)
            {
                Console.WriteLine($"{product.Nome}        {product.Quantidade}            {product.Preco.ToString("C")}");
            }
        }
        public void Calculo()
        {
            foreach (var product in listProdutos)
            {
               ValorTotal += product.Quantidade * product.Preco;
            }

            Console.WriteLine($"Total da Nota Fiscal: R$ {ValorTotal.ToString("C")}");
        }
    }
}

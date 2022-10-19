using System;
using System.Collections.Generic;

namespace TesteNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            PessoaFisica pessoaFisica = new PessoaFisica();
            Rodape rodape = new Rodape();
            Produto produto = new Produto();

            NotaFiscal nota = new NotaFiscal();
            string pessoa;


            Console.WriteLine("Pessoa Fisica ou Jutidica");
            pessoa = Console.ReadLine().ToUpper();


            if (pessoa == "FISICA")
            {
                
                Console.WriteLine("Entre com seu nome:");
                pessoaFisica.Nome = Console.ReadLine();
                Console.WriteLine("Entre com CPF:");
                pessoaFisica.Cpf = Console.ReadLine();

            }
            else
            {
                
                Console.WriteLine("Entre com seu nome:");
                pessoaJuridica.Nome = Console.ReadLine();
                Console.WriteLine("Entre com seu CNPJ:");
                pessoaJuridica.Cnpj = Console.ReadLine();


            }

           
            produto.Lista();

            nota.Imprimir();

            if (pessoa == "FISICA")
            {
                
                Console.WriteLine("Cliente: "+ pessoaFisica.Nome);
                Console.WriteLine("CPF: "+ pessoaFisica.Cpf);

            }
            else
            {
                
                Console.WriteLine("Cliente: "+ pessoaJuridica.Nome);
                Console.WriteLine("CNPJ: "+ pessoaJuridica.Cnpj);


            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Produto          Quantidade          Preço");
            
            produto.ImprimirLista();
            
            Console.WriteLine();
            Console.WriteLine();
            
            produto.Calculo();
            rodape.Rodpe();


        }
    }
}

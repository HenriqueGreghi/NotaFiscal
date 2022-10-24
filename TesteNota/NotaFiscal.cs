using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;


namespace TesteNota
{
    internal class NotaFiscal
    {
       

        Cabecalho cabecalho = new Cabecalho();
        Produto produto = new Produto();   
        Rodape rodape = new Rodape();
        PessoaFisica pessoaFisica = new PessoaFisica();
        PessoaJuridica pessoaJuridica = new PessoaJuridica();
       

        

        string pessoa;

        public void Pessoa()
        {
            
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

        }
        public void ProdutoLista()
        {
            produto.Lista();
        }

        public void Imprimir()
        {
            

            Console.WriteLine("********************* NOTA FISCAL DE SAÍDA **********************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Número: " + cabecalho.NumeroNota);

            if (pessoa == "FISICA")
            {
                
                Console.WriteLine("Cliente: " + pessoaFisica.Nome);
                Console.WriteLine("CPF: "+ pessoaFisica.Cpf );
            }
            else
            {
                
                Console.WriteLine("Cliente: " + pessoaJuridica.Nome);
                Console.WriteLine("CNPJ: "+ pessoaJuridica.Cnpj);
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Produto               Quantidade               Preço");
            produto.ImprimirLista();

            Console.WriteLine();
            Console.WriteLine();

            produto.Calculo();
            rodape.Rodpe();

        }
    }
}

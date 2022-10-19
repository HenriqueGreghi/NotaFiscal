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

        Rodape Rodape = new Rodape();


        public void Imprimir()
        {
            Console.WriteLine("********************* NOTA FISCAL DE SAÍDA **********************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Número: " + cabecalho.NumeroNota);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_fundamentos_csharp.Topicos.OperadoresCondicionais
{
    public class OperadoresCondicionais
    {
        public static void Compras()
        {
            int quantidadeEstoque = 10;
            int quantidadeCompra = 5;

            System.Console.WriteLine($"Qtd em estoque: {quantidadeEstoque}");
            System.Console.WriteLine($"Qtd de compra: {quantidadeCompra}");

            if(quantidadeEstoque >= quantidadeCompra)
            {
                System.Console.WriteLine("Venda realizada.");
            }
            else
            {
                System.Console.WriteLine("Venda não realizada. Quantidade insuficiente em estoque.");
            }
        }

        public static void Vogal()
        {
            System.Console.WriteLine("Digite uma letra: ");
            string letra = System.Console.ReadLine();

            switch(letra)
            {
                case "a":
                    System.Console.WriteLine($"A vogal é 'a'");
                    break;

                case "e":
                    System.Console.WriteLine($"A vogal é 'e'");
                    break;

                case "i":
                    System.Console.WriteLine($"A vogal é 'i'");
                    break;

                case "o":
                    System.Console.WriteLine($"A vogal é 'o'");
                    break;

                case "u":
                    System.Console.WriteLine($"A vogal é 'u'");
                    break;

                default:
                    System.Console.WriteLine($"Não foi encontrado alguma vogal.");
                    break;
                    
            }
        }
         
    }
}
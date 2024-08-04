using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_fundamentos_csharp.OperadoresAtribuicao
{
    public class OperadoresAtribuicao
    {
        public static void ExemploOperadoresAtribuicao()
        {
            int a = 10;
            int b = 20;

            int c = a + b;

            // Atribuindo um novo valor à variavel 'c'
            c = 50;
            
            System.Console.WriteLine($"O valor de 'c' é: {c}");
        }

        public static void ConversaoTipos()
        {
            // Tipos de variáveis
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

            // Conversões de Tipo
            //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
            


            // CONVERSÃO 'STRING' --> 'INT'

            // Casting
            // CONVERT (recomendado) - Consegue lidar com valores nulos 'null'
            int a = Convert.ToInt32("5"); // Converte o String "5" para um Int32
            int b = Convert.ToInt32(null); // Converte o 'null' para o valor 0 (zero)

            // PARSE - NÃO aceita valores nulos 'null'
            int c = int.Parse("10"); // Converte o String "10" para um Int32
            
            System.Console.WriteLine("\nCONVERSÃO 'STRING' --> 'INT'");
            System.Console.WriteLine($"O valor de 'a': {a} : ({a.GetType().Name})");
            System.Console.WriteLine($"O valor de 'b' [null]: {b} : ({b.GetType().Name})");
            System.Console.WriteLine($"O valor de 'c': {c} : ({c.GetType().Name})");


            // CONVERSÃO 'INT' --> 'STRING'
            int valor = 100;
            string valorConvertido = valor.ToString();

            System.Console.WriteLine("\nCONVERSÃO 'INT' --> 'STRING'");
            System.Console.WriteLine($"O valor é: {valorConvertido} : ({valorConvertido.GetType().Name})");

            // Cast implícito
            // 1. Nesse caso, o valor da variavel 'y' não possui capacidade
            //    de armazenar o valor da variavel 'x' do tipo long
            // 2. Como resposta é retornado um Exception
            
            //long x = long.MaxValue;
            //int y = Convert.ToInt32(x);

            System.Console.WriteLine("\nCAST IMPLICITO");
            int x = int.MaxValue;
            long y = Convert.ToInt32(x);

            System.Console.WriteLine($"X: {y} : {y.GetType().Name}");


            // CONVERSÃO NO MODO SEGURO (sem exceptions)
            string info = "15x";
            int z = 0;

            // Caso a conversão da variavel 'w' de erro, é retornado (out)
            // o valor da variavel 'z'
            int.TryParse(info, out z);

            System.Console.WriteLine("\nTryParse");
            System.Console.WriteLine($"O valor de 'Z' é: {z} --> {z.GetType().Name}");

        }
    }
}
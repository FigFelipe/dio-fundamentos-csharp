using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_fundamentos_csharp.Topicos.OperadoresAritmeticos
{
    public class OperadoresAritmeticos
    {
        int x = 0;
        int y = 0;

        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public static void Dividir(int x, int y)
        {
            System.Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public static void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public static void Resto(int x, int y)
        {
            System.Console.WriteLine($"{x} % {y} = {x % y}");
        }

        public static void Potencia(int numeroBase, int expoente)
        {
            double resultado = Math.Pow(numeroBase, expoente);

            System.Console.WriteLine($"{numeroBase} ^ {expoente} = {resultado}");
        }

        public static void Seno(double angulo)
        {
            // Informar o angulo em 'rad'
            double radiano = angulo * Math.PI / 180;

            double seno = Math.Sin(radiano);

            System.Console.WriteLine($"Seno {angulo} = {Math.Round(seno, 4)}");
        }

        public static void Cosseno(double angulo)
        {
            // Informar o angulo em 'rad'
            double radiano = angulo * Math.PI / 180;

            double cosseno = Math.Cos(radiano);

            System.Console.WriteLine($"Cosseno {angulo} = {Math.Round(cosseno, 4)}");
        }

        public static void Tangente(double angulo)
        {
            // Informar o angulo em 'rad'
            double radiano = angulo * Math.PI / 180;

            double tangente = Math.Cos(radiano);

            System.Console.WriteLine($"Tangente {angulo} = {Math.Round(tangente, 4)}");
        }

        public static void Incremento(int numero)
        {
            // ++numero (incrementa o numero, depois exibe o valor do numero)
            // numero++ (exibe o valor do numero, depois incrementa)

            System.Console.WriteLine($"Incremento {numero} = {++numero}");
        }

        public static void Decremento(int numero)
        {
            // --numero (decrementa o numero, depois exibe o valor do numero)
            // numero-- (exibe o valor do numero, depois decrementa)

            System.Console.WriteLine($"Decremento {numero} = {--numero}");
        }


        public static void RaizQuadrada(double radicando)
        {
            double raizQuadrada = Math.Sqrt(radicando);

            System.Console.WriteLine($"Raiz quadrada {radicando} = {Math.Round(raizQuadrada, 4)}");
        }
        
        
    }
}
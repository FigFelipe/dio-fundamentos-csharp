using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_fundamentos_csharp.Topicos.ArraysListas
{
    public class ArraysListas
    {
        public static void ExemploArrays()
        {
            // Exemplos de declaração
            // 1. Um vetor do tipo 'int' com 4 posições (zero à 3)
            int[] array = new int[3];

            // 2. Vetor do tipo 'int' com 4 posições implicitas, já instanciado
            int[] vetorX = new int[] {42, 47, 75, 61};

            // 3. Vetor do tipo 'string', já instanciado
            string[] nomes = {"Jan", "Fev"};


            // Acessando os valores do array através do índice específico
            System.Console.WriteLine($"Indice [0]: {vetorX[0]}");

            // Exibir o tamanho do vetor
            System.Console.WriteLine($"O vetor 'vetorX[]' tem o tamanho de {vetorX.Length} elemento(s).");

            // FOR
            // Acessando todos os indices do vetor

            System.Console.WriteLine("\n--> FOR");

            for(int i = 0; i < vetorX.Length; i++)
            {
                System.Console.WriteLine($"vetorX [{i}]: {vetorX[i]}");
            }

            // FOREACH
            // Acessando os valores percorrendo todo o vetor
            int aux = 0;

            System.Console.WriteLine("\n--> FOREACH");

            foreach(int valor in vetorX)
            {
                System.Console.WriteLine($"vetorX [{aux}]: {valor}");

                aux++;
            }

        }
    }
}
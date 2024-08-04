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
            string[] meses = {"Jan", "Fev"};

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

            // Redimensionando o tamanho do array
            // Ex.: dobrar o valor do array 'vetorX'
            // Em resumo, o Array.Resize realiza uma copia do array informado
            // para um novo array com o tamanho informado
            Array.Resize(ref vetorX, vetorX.Length * 2);

            System.Console.WriteLine($"\nTamanho atualizado do vetorX: {vetorX.Length}");

        }

        public static void CopiarArray()
        {
            int[] x = new int[4];

            x[0] = 20;
            x[1] = 31;
            x[2] = 42;
            x[3] = 53;
            
            int[] vetorTamanhoDobrado = new int[x.Length * 2];

            // Copiando o vetor
            Array.Copy(x, vetorTamanhoDobrado, x.Length);

            // Verificando o tamanho total do novo vetor copiado
            System.Console.WriteLine($"\nTamanho do vetor copiado: {vetorTamanhoDobrado.Length} elemento(s)\n");

            // Percorrendo os valores do vetor copiado

            int aux = 0;

            foreach(int valor in vetorTamanhoDobrado)
            {
                System.Console.WriteLine($"Elemento [{aux}] : {valor}");

                aux++;
            }
        }

        public static void ExemploListas()
        {
            // A lista possui um tipo e tamanho dinamico
            // Não é necessario gerenciar o tamanho da lista

            // Criando uma lista com o nome 'listaString' do tipo 'string'
            List<string> listaString = new List<string>();

            // Adicionando elementos à lista
            listaString.Add("SP");
            listaString.Add("CE");
            listaString.Add("RS");
            listaString.Add("CE");
            
            // Verificando o tamanho da lista
            System.Console.WriteLine($"Numero total de elementos da lista: {listaString.Count}");

            // Retorna a primeira ocorrencia do elemento na busca
            System.Console.WriteLine($"Busca [CE]: {listaString.Find(x => x.Contains("CE"))}");

            // Removendo um elemento da lista
            listaString.Remove("RS");

            // Percorrendo os elementos da lista
            foreach(string estado in listaString)
            {
                System.Console.WriteLine(estado);
            }

        }
    }
}
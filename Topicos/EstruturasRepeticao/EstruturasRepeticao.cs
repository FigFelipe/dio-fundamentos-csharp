using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace dio_fundamentos_csharp.Topicos.EstruturasRepeticao
{
    public class EstruturasRepeticao
    {
        public static void Tabuada(int numero)
        {
            int multiplicador = 0;

            System.Console.WriteLine("[TABUADA] Informe um numero para escrever a tabuada...: ");

            numero = Convert.ToInt32(Console.ReadLine());

            // Obs.: NAO UTILIZAR O COMANDO 'Console.Clear()' no VSCode
            //       O mesmo está repetindo informações dos laços 'FOR' e 'WHILE'
            // Ação: Após finalização da execução, utilizar o comando 'cls'
            //       no própio terminal
            //Console.Clear();

            // Utilizando o laço 'FOR' (para)
            System.Console.WriteLine("\n--> FOR");

            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            // Utilizando o 'While' (enquanto)
            System.Console.WriteLine("\n--> WHILE");

            while (multiplicador <= 10)
            {
                System.Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");

                multiplicador++;
            }

            // Utilizando o 'Do-While' (faça-enquanto)
            System.Console.WriteLine("\n--> DO-WHILE");

            multiplicador = 0; // Reset

            do
            {
                System.Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");

                multiplicador++;

            } while (multiplicador <= 10);
        }

        public static void MenuInterativo()
        {
            string opcao;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                //Console.Clear();

                System.Console.WriteLine("1 - Cadastrar cliente");
                System.Console.WriteLine("2 - Buscar cliente");
                System.Console.WriteLine("3 - Apagar cliente");
                System.Console.WriteLine("4 - Encerrar");
                System.Console.WriteLine("Digite a sua opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        System.Console.WriteLine("\n--> Cadastro de cliente\n");
                        break;

                    case "2":
                        System.Console.WriteLine("\n--> Busca de cliente\n");
                        break;

                    case "3":
                        System.Console.WriteLine("\n--> Apagar cliente\n");
                        break;

                    case "4":
                        System.Console.WriteLine("\n--> Encerrar\n");
                        exibirMenu = false;
                        break;

                    default:
                        System.Console.WriteLine("Opção inválida.");
                        break;
                }
            }

            System.Console.WriteLine("O programa foi encerrado.");
        }
    }
}
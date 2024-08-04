using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_fundamentos_csharp.Models;

namespace dio_fundamentos_csharp.Fundamentos
{
    public class Fundamentos
    {

        public void Exemplo()
        {
            // Cases:
            // 1. camelCase (C# - variável)
            // 2. PascalCase (C# - nome de classe, propiedade, método)
            //
            // 3. snake_case (Não utilizado em C#)
            // 4. spinal-case (Não utilizado em C#)

            // Tipos de variáveis 
            string apresentacao = "Olá, seja bem vindo";

            int quantidade = 1;
            quantidade = 10;

            double altura = 1.80;
            decimal preco = 25.80M;

            bool condicao = true;

            DateTime dataAtual = DateTime.Now;
            dataAtual = dataAtual.AddDays(5);

            System.Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
            System.Console.WriteLine("Apresentação [string]: " + apresentacao);
            System.Console.WriteLine("Quantidade [int]: " + quantidade);
            System.Console.WriteLine("Altura [double - com duas casas decimais]: " + altura.ToString("0.00"));
            System.Console.WriteLine("Preço [decimal]: " + preco);
            System.Console.WriteLine("Condição [bool]: " + condicao);

            // Instanciando um novo objeto do tipo 'PessoaFisica'
            PessoaFisica pessoa = new PessoaFisica();
            PessoaFisica pessoaRepresentacao = new PessoaFisica();

            // Atribuindo valores ás propiedades definidas na classe 'PessoaFisica'
            pessoa.Nome = "Teste";
            pessoa.Idade = 1;

            // Acessando o método da classe 'PessoaFisica'
            pessoa.Apresentar();
        }

    }
}
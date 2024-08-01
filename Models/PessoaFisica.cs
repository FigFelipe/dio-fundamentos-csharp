using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_fundamentos_csharp.Models
{
    public class PessoaFisica
    {
        // Atributos
        // Dica: utilizar o snippet 'prop' para adicionar as propiedades do objeto
        public string Nome { get; set; }
        public int Idade { get; set; }


        // Metodos
        public void Apresentar()
        {
            System.Console.WriteLine($"Meu nome é: {Nome}, {Idade} ano(s).");
        }
        
    }
}
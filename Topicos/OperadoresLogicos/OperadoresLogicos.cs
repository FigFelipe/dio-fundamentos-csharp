using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_fundamentos_csharp.Topicos.OperadoresLogicos
{
    public class OperadoresLogicos
    {
        public static void OperadorLogico()
        {
            bool x = true;
            bool y = false;

            System.Console.WriteLine($"x = {x}");
            System.Console.WriteLine($"y = {y}");

            // OR (Ou)
            System.Console.WriteLine($"X or Y = {x || y}");

            // AND (e)
            System.Console.WriteLine($"X and Y = {x && y}");

            // NOT (negação, inversão)
            System.Console.WriteLine($"NOT X = {!x}");
            System.Console.WriteLine($"NOT Y = {!y}");
            
        } 
    }
}
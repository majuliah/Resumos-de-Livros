using static System.Console;
using System;
using System.Linq;

namespace Capitulo03
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("---MICROSOFT STUDIES COMPANY---");
            string empresa = " Meu nome é Majúlia! ";
            
            WriteLine("O TRIM retira espaços antes e depois das expressões: ");
            WriteLine($"Expressão sem espaços: {empresa.Trim()}");
        }
    }
}

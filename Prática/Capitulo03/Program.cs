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
            
            WriteLine("Length devolve a quantidade de caracteres:");
            WriteLine($"Tamanho do texto: {empresa.Length}");
            
            WriteLine("ToUpper deixa tudo em maiúsculo: ");
            WriteLine($"Empresa com toUpper: {empresa.ToUpper()}");
            
            WriteLine("ToLower deixa tudo em minúsculo: ");
            WriteLine($"Empresa com ToLower {empresa.ToLower()}");
            
            
            
            
            
            
        }
    }
}

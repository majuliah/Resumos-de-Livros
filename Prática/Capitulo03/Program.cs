﻿using static System.Console;
using System;
using System.Linq;

namespace Capitulo03
{
    class Program
    {
        static void Main(string[] args)
        {
           /* WriteLine("---MICROSOFT STUDIES COMPANY---");
            string empresa = " Meu nome é Majúlia! ";
            
            WriteLine("O TRIM retira espaços antes e depois das expressões: ");
            WriteLine($"Expressão sem espaços: {empresa.Trim()}");
            
            WriteLine("Length devolve a quantidade de caracteres:");
            WriteLine($"Tamanho do texto: {empresa.Length}");
            
            WriteLine("ToUpper deixa tudo em maiúsculo: ");
            WriteLine($"Empresa com toUpper: {empresa.ToUpper()}");
            
            WriteLine("ToLower deixa tudo em minúsculo: ");
            WriteLine($"Empresa com ToLower {empresa.ToLower()}");
            */

           //string nomeUpper = "AIRTON SENNA";
           //string nomeLower = "airton senna";
           //Comparação 1:
           
          /* if (nomeUpper == nomeLower)
           {
               WriteLine("1 nomes iguais");
           }
           else
           {
               WriteLine("1 nomes diferentes");
           }
           
           //Comparação 2

           if (nomeUpper.ToLower() == nomeLower)
           {
                WriteLine("2 - nomes iguais");               
           }
           else
           {
               WriteLine("2- nomes diferentes");
           }
           
           
           //Comparação 3
           if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
           {
                WriteLine("3 - Nomes iguais");   
           }
           else
           {
               WriteLine("3 - Nomes diferentes");
           }
           string empresa = "Microsoft Corporation";
           
           WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
           WriteLine($"Texto esquerdo: {empresa.Remove(5)}");
           
           WriteLine("Captura apenas o primeiro nome das pessoas: ");
           string[] nomes = {"Fabricio dos Santos","José da Silva","Roberta Brasil"};

           foreach (var n in nomes)
           {
               WriteLine($"{n.Remove(n.IndexOf(" "))}");
               WriteLine(" ");
           }

           string novaEmpresa = empresa;
           WriteLine("Replace - Troca os parâmetros");
           WriteLine(empresa);
           WriteLine($"Nova empresa: {novaEmpresa.Replace("Microsoft", "Google")}");
           */
          
          //WriteLine("Split divide a cadeia.");
          string nivelLivro = "Este livro é o básico de C#";
          //string[] blocos = nivelLivro.Split(' ');
          //int cont = 1;

          //foreach (var exp in blocos)
          //{
          //    WriteLine($"Texto {cont++} : {exp}");
          //}
          //WriteLine($"Qtde de palavras: {blocos.Count()}");

          WriteLine($"O resultado da substring (5, 14) é: {nivelLivro.Substring(5, 14)}");
          
          WriteLine("Substring é usado para retirar partes de textos");
          string[] cesta = {"5 Laranjas", "8 Limões", "14 Peras", "18 Melancias"};
          int qtde = 0;
          foreach (var fruta in cesta)
          {
              WriteLine($"{fruta.Substring(fruta.IndexOf(" ") + 1)}");

              qtde += Convert.ToInt32(fruta.Substring(0, fruta.IndexOf(" ")));
              WriteLine($"Qtde total: {qtde:n0}");
          }
          
          
          


        }
    }
}

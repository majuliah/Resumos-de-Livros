using System;


namespace Exemplo1
{
    class Program2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    
    public class Gerente
    {
        //estrutura que representa uma classe em C#
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Cpf { get; set; }
        public void AprovarHorasDeFuncionarios(int cpf){
        //lógica para aprovar horas dos funcionários
        }
    }

    public class InstanciaObjeto
    {
        public static void Main4()
        {
            var objetoGerente = new Gerente();
            
        }
    }

    
}



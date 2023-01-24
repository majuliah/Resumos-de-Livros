using static System.Console;

namespace exemples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Personagem nathanDrake = new Personagem();
            
            
            //upcast
            Pessoa pessoa;
            pessoa = new Medico();
            pessoa = new Paciente();
            pessoa = new Funcionario();
            Funcionario funcionario = new Medico();
            WriteLine(pessoa);

            //downcast
            Funcionario funcionario1 = new Gerente();
            Gerente gerente1 = funcionario1 as Gerente;
            Funcionario funcionario2 = new Funcionario();
            Gerente gerente2 = funcionario as  Gerente;

            
        }
    }
}
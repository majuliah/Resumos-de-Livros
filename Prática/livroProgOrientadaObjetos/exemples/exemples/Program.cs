using static System.Console;

namespace exemples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Personagem nathanDrake = new Personagem();
            
            
            //up&down cast
            Pessoa pessoa;
            pessoa = new Medico();
            pessoa = new Paciente();
            pessoa = new Funcionario();
            Funcionario funcionario = new Medico();
            WriteLine(pessoa);

        }
    }
}
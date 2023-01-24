using Microsoft.VisualBasic;
namespace exemples
{
    abstract class Pessoa
    {
         string Nome;
         char Sexo;
    }
    public class Paciente : Pessoa
    {
        DateFormat dataInternacao;
    }
    public class Funcionario : Pessoa
    {
        DateFormat dataAdmissao;
        string matricula;
    }
    public class Medico : Funcionario
    {
        string CRM;

        void Operar()
        {
            
        }
    }
    
    public class Gerente : Funcionario
    {
        DateFormat CRM;
        private string nomedasala;

        void Gerir()
        {
            
        }
    }
}
namespace exemples
{
    public class Quadrilatero
    {
        //area retangulo
        double CalculaArea(double baseMaior, double baseMenor)
        {
            return baseMaior * baseMenor;
        }

        //area trapézio
        double CalculaArea(double baseMaior, double baseMenor, double altura)
        {
            return ((baseMaior * baseMenor) * altura) / 2.0;
        }

        //area quadrado
        double CalculaArea(double lado)
        {
            return lado * lado;
        }
        
    }
}
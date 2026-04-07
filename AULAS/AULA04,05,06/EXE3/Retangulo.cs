public class Retangulo : Forma
{
    public double Base;
    public double Altura;

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}
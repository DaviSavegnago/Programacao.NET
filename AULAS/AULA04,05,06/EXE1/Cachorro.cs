// Cachorro herda de Animal
public class Cachorro : Animal
{
    // Sobrescrevendo o método da classe pai
    public override void EmitirSom()
    {
        Console.WriteLine(Nome + "Au Au");
    }
}
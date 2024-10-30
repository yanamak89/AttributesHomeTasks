namespace ObsoleteAttributeExample;

public class ExampleClass
{
    // Метод з попередженням про застарілість
    [Obsolete("Цей метод застарілий, використовуйте NewMethod замість нього.")]
    public void OldMethod()
    {
        Console.WriteLine("Викликано OldMethod.");
    }


    public void NewMethod()
    {
        Console.WriteLine("Викликано NewMethod.");
    }
}
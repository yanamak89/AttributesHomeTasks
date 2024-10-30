using ObsoleteAttributeExample;

public class Program
{
    public static void Main(string[] args)
    {
        ExampleClass example = new ExampleClass();
        // Виклик застарілого методу, який викликає попередження
        #pragma warning disable CS0612
        example.OldMethod(); // Виклик застарілого методу, щоб побачити попередження або помилку
        #pragma warning restore CS0612
        
        example.NewMethod();
        
    }
}

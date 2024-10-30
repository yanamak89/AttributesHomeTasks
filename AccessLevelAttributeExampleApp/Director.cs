namespace AccessLevelAttributeExampleApp;

[AccessLevel(1)]
public class Director
{
    public string Name { get; }

    public Director(string name)
    {
        Name = name;
    }
}


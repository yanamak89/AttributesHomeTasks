namespace AccessLevelAttributeExampleApp;

[AccessLevel(2)]
public class Programmer
{
    public string Name { get; }

    public Programmer(string name)
    {
        Name = name;
    }
}
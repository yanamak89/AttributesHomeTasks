namespace AccessLevelAttributeExampleApp;

[AccessLevel(2)]
public class Manager
{
    public string Name { get; }

    public Manager(string name)
    {
        Name = name;
    }
}
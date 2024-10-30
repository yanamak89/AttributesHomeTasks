namespace AccessLevelAttributeExampleApp;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class AccessLevelAttribute : Attribute
{
    public int Level { get; }

    public AccessLevelAttribute(int level)
    {
        Level = level;
    }
}
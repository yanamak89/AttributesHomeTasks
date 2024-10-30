using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ObsoleteWithReflectorExample;

public class Reflector
{
    public static void DisplayTypeInfo(Type type, bool showMethods, 
        bool showProperties, bool showFields)
    {
        Console.WriteLine($"Інформація про тип: {type.FullName}");
        DisplayAttributes(type);

        if (showMethods)
        {
            Console.WriteLine("\nМетоди:");
            var methods = type.GetMethods(BindingFlags.Public |
                                          BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var method in methods)
            {
                Console.WriteLine($"-{method.Name}");
                DisplayAttributes(method);
            }
        }
        if (showProperties)
        {
            Console.WriteLine("\nВластивості:");
            var properties = type.GetProperties(BindingFlags.Public |
                                                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var property in properties)
            {
                Console.WriteLine($"-{property.Name}");
                DisplayAttributes(property);
            }
        }

        if (showFields)
        {
            Console.WriteLine($"\nПоля");
            var fields = type.GetFields(BindingFlags.Public |
                                        BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var field in fields)
            {
                Console.WriteLine($"-{field.Name}");
                DisplayAttributes(field);
            }
        }
    }

    private static void DisplayAttributes(MemberInfo member)
    {
        var attributes = member.GetCustomAttributes();
        if (attributes.Any())
        {
            Console.WriteLine($"\nАтрибути {member.Name}:");
            foreach (var attribute in attributes)
            {
                Console.WriteLine($"-{attribute.GetType().Name}");
            }
        }
        else
        {
            Console.WriteLine($"{member.Name} не має атрибутів.");
        }
    }
}
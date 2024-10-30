using System.ComponentModel.Design;

namespace AccessLevelAttributeExampleApp;

public class SecureSection
{
    private const int RequiredAccessLevel = 2;

    public static void TryAccess(object employee)
    {
        var type = employee.GetType();
        var accessLevelAttribute =
            (AccessLevelAttribute)Attribute.GetCustomAttribute(type, typeof(AccessLevelAttribute));

        if (accessLevelAttribute != null)
        {
            if (accessLevelAttribute.Level >= RequiredAccessLevel)
            {
                Console.WriteLine($"{type.Name} {((dynamic)employee).Name} має доступ до захищеної секціі.");
            }
            else
            {
                Console.WriteLine($"{type.Name} {((dynamic)employee).Name} не має достатнього рівня доступу до захищеної секції.");
            }
        }
        else
        {
            Console.WriteLine($"Рівень доступу для {type.Name} не визначено.");
        }
    }
}
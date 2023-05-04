using System.ComponentModel;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace restful_booker.Helpers.Enum_Extesions;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        var type = value.GetType();
        var name = Enum.GetName(type, value);
        var field = type.GetField(name);
        var attribute =
            Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as
                System.ComponentModel.DescriptionAttribute;
        return attribute != null ? attribute.Description : name;
    }

    public static T? GetEnumValueFromDescription<T>(string description) where T : Enum
    {
        foreach (var field in typeof(T).GetFields())
        {
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                if (attribute.Description == description)
                {
                    return (T) field.GetValue(null);
                }
            }
            else if (field.Name == description)
            {
                return (T)Enum.Parse(typeof(T), description);
            }
        }

        throw new ArgumentException($"Enum value with the description {description} was not found.");
    }
}



using System.ComponentModel;
using System.Reflection;

namespace EnumerationExtensions
{
    /// <summary>
    /// Extensions for enumerations for getting the value of an enumeration by its DescriptionAttribute.
    /// </summary>
    public static class EnumValueByDescription
    {
        /// <summary>
        /// Get an enumeration value based on its DescriptionAttribute
        /// </summary>
        /// <typeparam name="T">Type of the enumeration</typeparam>
        /// <param name="description">Value of the DescriptionAttribute of the searched enumeration value</param>
        /// <returns>Enumeration given by the value of its description attribute</returns>
        public static T GetValueByDescription<T>(string description) where T : Enum
        {
            foreach (FieldInfo field in typeof(T).GetFields())
            {
                DescriptionAttribute? customAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (((customAttribute == null && field.Name == description) ||
                     (customAttribute != null && customAttribute.Description == description)) && 
                    field.GetValue(null) is T returnType)
                {
                    return returnType;
                }
            }

            throw new ArgumentException("Couldn't find.", nameof(description));
        }
    }
}

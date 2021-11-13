using System;
using System.ComponentModel;
using System.Reflection;

namespace ViewModel
{
    /// <summary>
    /// Extensions for enumerations
    /// </summary>
    public static class EnumerationExtensions
    {
        /// <summary>
        /// Get enumeration value from its description
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>
        public static T GetValueFromDescription<T>(string description) where T : Enum
        {
            foreach (FieldInfo field in typeof(T).GetFields())
            {
                DescriptionAttribute customAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (customAttribute == null && field.Name == description)
                {
                    return (T)field.GetValue(null);
                }
                else if (customAttribute != null && customAttribute.Description == description)
                {
                    return (T)field.GetValue(null);
                }
            }

            throw new ArgumentException("Couldn't find.", nameof(description));
        }
    }
}

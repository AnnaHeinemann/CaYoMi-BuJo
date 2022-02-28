using System.ComponentModel;
using System.Reflection;

namespace EnumerationExtensions
{
    /// <summary>
    /// Extensions for enumerations for getting description (value of the DescriptionAttribute) or name of the value of an enumeration.
    /// </summary>
    public static class DescriptionOfEnumValue
    {
        /// <summary>
        /// Gets the value of the DescriptionAttributeof the enumeration value.
        /// </summary>
        /// <param name="value">Enumeration value to get the value of the DescriptionAttribute for.</param>
        /// <returns>Value of the DescriptionAttribute of the enumeration value or string.Empty if DescriptionAttribute couldn't be found</returns>
        public static string GetDescription(this Enum value) => value?.GetDescription() ?? string.Empty;

        /// <summary>
        /// Gets the name of the enumeration value.
        /// </summary>
        /// <param name="value">Enumeration value to get the name for.</param>
        /// <returns>Name of the enumeration value or string.Empty if no name is available</returns>
        public static string GetName(this Enum value) => value?.GetName() ?? string.Empty;

        /// <summary>
        /// Gets the value of the DescriptionAttributeof the enumeration value or its name.
        /// </summary>
        /// <param name="value">Enumeration value to get the value of the DescriptionAttribute or its name for.</param>
        /// <returns>Value of the DescriptionAttribute or name of the enumeration value or string.Empty if neither DescriptionAttribute or name are available</returns>
        public static string GetDescriptionOrName(this Enum value) => value?.getDescription() ?? value.getName() ?? string.Empty;

        private static string getDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes?.FirstOrDefault()?.Description;
        }

        private static string getName(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            return fieldInfo?.Name ?? string.Empty;
        }
    }
}

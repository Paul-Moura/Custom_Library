using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CustomControls
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            var attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0) return attributes[0].Description;

            return value.ToString();
        }

        public static string[] GetCategories(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            var categories = (CategoryAttribute[])fi.GetCustomAttributes(typeof(CategoryAttribute), false);

            return categories.Length > 0 ? categories.Select(x => x.Category).ToArray() : null;
        }

        public static string[] GetNames(this Enum value, string category)
        {
            Type t = value.GetType();
            return (from s in Enum.GetNames(t) let fi = t.GetField(s) where ((CategoryAttribute[])fi.GetCustomAttributes(typeof(CategoryAttribute), false)).Any(x => x.Category == category) select s).ToArray();
        }
    }
}

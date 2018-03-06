using System;
using System.Reflection;

namespace DotNetDebuggerDisplay
{
    public class DebuggerDisplayFrom<T>
    {
        private const string OUTPUT_PATTERN = "{{{0}:{1}}}";

        public static string PropertiesOf(T o)
        {
            var data = String.Empty;
            foreach (PropertyInfo propertyInfo in o.GetType().GetProperties())
            {
                foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
                {
                    var debuggerDisplayMemberAttribute = (DebuggerDisplayMemberAttribute)attribute;

                    if (debuggerDisplayMemberAttribute.DebuggerDisplay)
                        data += String.Format(OUTPUT_PATTERN, propertyInfo.ToString(), propertyInfo.GetValue(o, null));
                }
            }
            return data;
        }
    }

}
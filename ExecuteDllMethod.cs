using System;
using System.Reflection;

namespace Custom
{
    public static class DLL
    {
        public static void ExecuteDllMethod(string filePath, string className, string methodName)
        {
            Assembly assembly = Assembly.LoadFrom(filePath);
            Type type = assembly.GetType(className);
            MethodInfo method = type.GetMethod(methodName);
            method.Invoke(null, null);
        }
    }
}

namespace Template.Backend.Toolkit.Extensions;

using System;
using System.Collections.Generic;

/// <summary>
/// Расширения для Reflection, сканирование типов и сборок.
/// </summary>
public static class AssamblyExtension
{
    private static List<Type> GetAllBaseTypes(this Type type)
    {
        var baseTypes = new List<Type>();

        if (type.BaseType != null)
        {
            baseTypes.Add(type.BaseType);
            baseTypes.AddRange(type.BaseType.GetAllBaseTypes());
        }
        return baseTypes;
    }
}

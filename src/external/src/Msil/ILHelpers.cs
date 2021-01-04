// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Msil
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    public static class ILHelpers
    {
        public static string ToIL(this Type type) 
            => ToIL(type?.GetTypeInfo());

        public static string ToIL(this TypeInfo type)
        {
            if (type == null)
            {
                return "";
            }

            if (type.IsArray)
            {
                if (type.GetElementType().MakeArrayType().GetTypeInfo() == type)
                {
                    return ToIL(type.GetElementType()) + "[]";
                }
                else
                {
                    string bounds = string.Join(",", Enumerable.Repeat("...", type.GetArrayRank()));
                    return ToIL(type.GetElementType()) + "[" + bounds + "]";
                }
            }
            else if (type.IsGenericType && !type.IsGenericTypeDefinition && !type.IsGenericParameter /* TODO */)
            {
                string args = string.Join(",", type.GetGenericArguments().Select(ToIL));
                string def = ToIL(type.GetGenericTypeDefinition());
                return def + "<" + args + ">";
            }
            else if (type.IsByRef)
            {
                return ToIL(type.GetElementType()) + "&";
            }
            else if (type.IsPointer)
            {
                return ToIL(type.GetElementType()) + "*";
            }
            else
            {
                var res = default(string);
                if (!s_primitives.TryGetValue(type, out res))
                {
                    res = "[" + type.Assembly.GetName().Name + "]" + type.FullName;

                    if (type.IsValueType)
                    {
                        res = "valuetype " + res;
                    }
                    else
                    {
                        res = "class " + res;
                    }
                }

                return res;
            }
        }

        public static string ToIL(this MethodBase method)
        {
            if (method == null)
                return "";

            string res = "";

            if (!method.IsStatic)
                res = "instance ";

            var mtd = method as MethodInfo;
            Type ret = mtd?.ReturnType ?? typeof(void);

            res += ret.ToIL() + " ";
            res += method.DeclaringType.ToIL();
            res += "::";
            res += method.Name;

            if (method.IsGenericMethod)
            {
                res += "<" + string.Join(",", method.GetGenericArguments().Select(ToIL)) + ">";
            }

            res += "(" + string.Join(",", method.GetParameters().Select(p => ToIL(p.ParameterType))) + ")";

            return res;
        }

        public static string ToIL(this FieldInfo field)
            => field.DeclaringType.ToIL() + "::" + field.Name;

        static readonly Dictionary<TypeInfo, string> s_primitives = new Dictionary<Type,string>
        {
            { typeof(object), "object" },
            { typeof(void), "void" },
            { typeof(IntPtr), "native int" },
            { typeof(UIntPtr), "native uint" },
            { typeof(char), "char" },
            { typeof(string), "string" },
            { typeof(bool), "bool" },
            { typeof(float), "float32" },
            { typeof(double), "float64" },
            { typeof(sbyte), "int8" },
            { typeof(short), "int16" },
            { typeof(int), "int32" },
            { typeof(long), "int64" },
            { typeof(byte), "uint8" },
            { typeof(ushort), "uint16" },
            { typeof(uint), "uint32" },
            { typeof(ulong), "uint64" },
        }.ToDictionary(kv => kv.Key.GetTypeInfo(), kv => kv.Value);
    }
}
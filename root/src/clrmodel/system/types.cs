//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static ReflectionFlags;
    using static Root;

    partial class RootReflections
    {
        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this Type t) 
            where A : Attribute
                => t.GetCustomAttribute<A>();

        /// <summary>
        /// Retrieves the type's fields together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="src">The type to examine</param>
        public static IDictionary<FieldInfo, A> TaggedFieldIndex<A>(this Type src) 
            where A : Attribute
        {
            var selection = from f in src.DeclaredFields()
                            where f.Tagged<A>()
                            let a = f.GetCustomAttribute<A>()
                            select (f,a);
            return selection.ToDictionary();
        }

        /// <summary>
        /// Retrieves the attribution index for the identified methods declared by the type
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The member instance type</param>
        public static IReadOnlyDictionary<MethodInfo, A> TagedMethodIndex<A>(this Type t)
            where A : Attribute
                => (from p in t.DeclaredMethods()
                    where p.Tagged<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    ).ToDictionary();

        /// <summary>
        /// Retrieves the type's properties together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        public static IReadOnlyDictionary<PropertyInfo, A> TaggedPropertieIndex<A>(this Type t) 
            where A : Attribute
                => (from p in t.DeclaredProperties()
                    where p.Tagged<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    ).ToDictionary();


        /// <summary>
        /// Returns true if the source type is non-null and non-void; otherwise, returns false
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this Type src)
            => src != null && src != typeof(void);

        /// <summary>
        /// Returns all interfaces realized by the type, including those inherited from
        /// supertypes
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<Type> Interfaces(this Type src)
            => src.GetInterfaces() ?? new Type[]{};

        /// <summary>
        /// For a system-defined type, returns the C#-specific keyword for the type if it has one; 
        /// otherwise, returns an empty string
        /// </summary>
        /// <param name="src">The type to test</param>
        [MethodImpl(Inline)]
        public static string SystemKeyword(this Type src)
        {
            if(src.IsSByte())
                return "sbyte";
            else if(src.IsByte())
                return "byte";
            else if(src.IsUInt16())
                return "ushort";
            else if(src.IsInt16())
                return "short";
            else if(src.IsInt32())
                return "int";
            else if(src.IsUInt32())
                return "uint";
            else if(src.IsInt64())
                return "long";
            else if(src.IsUInt64())
                return "ulong";
            else if(src.IsSingle())
                return "float";
            else if(src.IsDouble())
                return "double";
            else if(src.IsDecimal())
                return "decimal";
            else if(src.IsBool())
                return "bool";
            else if(src.IsChar())
                return "char";
            else if(src.IsString())
                return "string";
            else if(src.IsVoid())
                return "void";
            else if(src.IsObject())
                return "object";
            else 
                return string.Empty;
        }

        /// <summary>
        /// For a numeric type, returns the C#-specific keyword for the type; 
        /// otherwise, returns an empty string
        /// </summary>
        /// <param name="src">The type to test</param>
        [MethodImpl(Inline)]
        public static string NumericKeyword(this Type src)
        {
            if(src.IsSByte())
                return "sbyte";
            else if(src.IsByte())
                return "byte";
            else if(src.IsUInt16())
                return "ushort";
            else if(src.IsInt16())
                return "short";
            else if(src.IsInt32())
                return "int";
            else if(src.IsUInt32())
                return "uint";
            else if(src.IsInt64())
                return "long";
            else if(src.IsUInt64())
                return "ulong";
            else if(src.IsSingle())
                return "float";
            else if(src.IsDouble())
                return "double";
            else 
                return string.Empty;
        }

        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="stype">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        public static Option<Type> CloseEnumerableType(this Type stype)
        {
            if (stype == typeof(string))
                return null;

            if (stype.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(stype.GetElementType());

            if (stype.IsGenericType)
            {
                foreach (var arg in stype.GetGenericArguments())
                {
                    var enumerable = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (enumerable.IsAssignableFrom(stype))
                        return enumerable;
                }
            }

            var interfaces = stype.Interfaces().ToList();
            if (interfaces.Count > 0)
            {
                foreach (var i in interfaces)
                {
                    var ienum = CloseEnumerableType(i);
                    if (ienum.Exists)
                        return ienum;
                }
            }

            if (stype.BaseType != null && stype.BaseType != typeof(object))
                return CloseEnumerableType(stype.BaseType);
            return null;
        }

    }
}
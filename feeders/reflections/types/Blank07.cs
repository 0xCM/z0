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
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflections
    {

        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="stype">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        public static Type CloseEnumerableType(this Type stype)
        {
            if (stype == typeof(string))
                return typeof(void);

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
                    if (ienum.IsSome())
                        return ienum;
                }
            }

            if (stype.BaseType != null && stype.BaseType != typeof(object))
                return CloseEnumerableType(stype.BaseType);
            
            return typeof(void);
        }

        /// <summary>
        /// If a value type and not an enum, returns the type; 
        /// If an enum returns the unerlying integral type; 
        /// If a nullable value typethat is not an enum, returns the underlying type; 
        /// if nullable enum, returns the non-nullable underlying integral type
        /// If a pointer returns the pointee type
        /// Otherwise, reurns the effective type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GetRootType(this Type t)
        {
            if (t.IsNullableType())
            {
                var _t = Nullable.GetUnderlyingType(t);
                return _t.IsEnum ? _t.GetEnumUnderlyingType() : _t;
            }
            else if(t.IsEnum)
                return t.GetEnumUnderlyingType();
            else if(t.IsPointer)
                return t.GetElementType() ?? typeof(void);
            else
                return t.EffectiveType();
        }
    }
}
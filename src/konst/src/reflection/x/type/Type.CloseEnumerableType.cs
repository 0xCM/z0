//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XReflex
    {
        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="seq">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        [Op]
        public static Option<Type> CloseEnumerableType(this Type seq)
        {
            if (seq == typeof(string))
                return null;

            if (seq.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(seq.GetElementType());

            if (seq.IsGenericType)
            {
                foreach (var arg in seq.GetGenericArguments())
                {
                    var enumerable = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (enumerable.IsAssignableFrom(seq))
                        return enumerable;
                }
            }

            var interfaces = seq.GetInterfaces();
            if (interfaces != null && interfaces.Length > 0)
            {
                foreach (var i in interfaces)
                {
                    var ienum = CloseEnumerableType(i);
                    if (ienum.Exists)
                        return ienum;
                }
            }

            if (seq.BaseType != null && seq.BaseType != typeof(object))
                return CloseEnumerableType(seq.BaseType);
            return null;
        }
    }
}
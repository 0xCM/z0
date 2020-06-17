//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Selects the properties from a property data array of a parametric type
        /// </summary>
        /// <param name="src">The source properties</param>
        public static ClrProperty<T>[] WithPropertyType<T>(this PropertyInfo[] src)
            => Clr.properties<T>(src.Where(p => p.PropertyType == typeof(T)));   

        /// <summary>
        /// Gets the property values
        /// </summary>
        /// <param name="src"></param>
        /// <param name="instance"></param>
        /// <typeparam name="T"></typeparam>
        public static T[] Values<T>(this ClrProperty<T>[] src, object instance = null)     
            => src.Select(p => p.Data.GetValue(instance)).Cast<T>();
    }
}
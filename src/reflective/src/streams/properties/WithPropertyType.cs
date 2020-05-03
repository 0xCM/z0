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
    
    partial class XTend
    {
        /// <summary>
        /// Selects the properties from a stream of a specified type
        /// </summary>
        /// <param name="src">The source stream</param>
        public static PropertyInfo[] WithPropertyType(this PropertyInfo[] src, Type t)
            => src.Where(p => p.PropertyType == t);

        /// <summary>
        /// Selects the properties from a property data array of a parametric type
        /// </summary>
        /// <param name="src">The source properties</param>
        public static PropertyData<T>[] WithPropertyType<T>(this PropertyInfo[] src)
            => Clr.data<T>(src.Where(p => p.PropertyType == typeof(T)));   

        /// <summary>
        /// Gets the property values
        /// </summary>
        /// <param name="src"></param>
        /// <param name="instance"></param>
        /// <typeparam name="T"></typeparam>
        public static T[] Values<T>(this PropertyData<T>[] src, object instance = null)     
            => src.Select(p => p.Data.GetValue(instance)).Cast<T>();
    }
}
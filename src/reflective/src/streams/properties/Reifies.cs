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
        /// Selects the properties from a stream that reify a specified interface type
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="tInterface">The inteface type</param>
        public static IEnumerable<PropertyInfo> Reifies(this PropertyInfo[] src, Type tInterface)
            => src.Where(p => p.PropertyType.Reifies(tInterface));

        /// <summary>
        /// Selects the properties from a stream that reify a parametrically-specified interface
        /// </summary>
        /// <param name="src">The source stream</param>        
        /// <typeparam name="T">The test type</typeparam>
        public static IEnumerable<PropertyData<T>> Reifies<T>(this PropertyInfo[] src)
            where T : class
                => Clr.data<T>(src.Where(p => p.PropertyType.Reifies(typeof(T))));
    }
}
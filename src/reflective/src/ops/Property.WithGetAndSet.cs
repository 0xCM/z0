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
    
    partial class XTend
    {
        /// <summary>
        /// Selects the properties with both get/set methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithGetAndSet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetGetMethod() != null && p.GetSetMethod() != null);
    }
}
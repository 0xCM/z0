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
        /// Selects the static properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Static(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.IsStatic());
    }
}
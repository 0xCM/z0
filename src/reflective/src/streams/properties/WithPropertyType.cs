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

    }
}
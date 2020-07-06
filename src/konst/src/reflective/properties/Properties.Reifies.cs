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
        public static PropertyInfo[] Reifies(this PropertyInfo[] src, Type tInterface)
            => src.Where(p => p.PropertyType.Reifies(tInterface));
    }
}
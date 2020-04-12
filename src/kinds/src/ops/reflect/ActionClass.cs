//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Actions(this IEnumerable<MethodInfo> src)
            => src.Where(ClassifiedOps.IsAction);
    }
}
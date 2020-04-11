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
    
    partial class Reflective
    {
        /// <summary>
        /// Selects the closed generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> ClosedGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsConstructedGenericMethod);
    }
}
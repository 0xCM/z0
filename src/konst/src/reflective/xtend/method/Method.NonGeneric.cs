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
        /// Selects the non-generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.ContainsGenericParameters && !t.IsConstructedGenericMethod);


        /// <summary>
        /// Selects the non-generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static MethodInfo[] NonGeneric(this MethodInfo[] src)
            => src.Where(t => !t.ContainsGenericParameters && !t.IsConstructedGenericMethod);

    }
}
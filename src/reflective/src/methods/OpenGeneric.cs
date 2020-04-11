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
        /// Selects the open generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.IsOpenGeneric());

        /// <summary>
        /// Selects the open generic methods from a stream with a specified argument count
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="args">The target argument count</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src, int args)
            => src.OpenGeneric().Where(m => m.GetGenericArguments().Length == args);
    }
}
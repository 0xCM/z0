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
        /// Queries the source for open generic methods
        /// </summary>
        /// <param name="src">The source methods</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.IsOpenGeneric());

        /// <summary>
        /// Queries the source for open generic methods
        /// </summary>
        /// <param name="src">The source methods</param>
        public static MethodInfo[] OpenGeneric(this MethodInfo[] src)
            => src.Where(m => m.IsOpenGeneric());

        /// <summary>
        /// Queries the source for open generic methods that have a specified argument count
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="args">The target argument count</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src, int args)
            => src.OpenGeneric().Where(m => m.GetGenericArguments().Length == args);

        /// <summary>
        /// Queries the source for open generic methods that have a specified argument count
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="args">The target argument count</param>
        public static MethodInfo[] OpenGeneric(this MethodInfo[] src, int args)
            => src.OpenGeneric().Where(m => m.GetGenericArguments().Length == args);
    }
}
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
        /// Selects functions from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> WithArity(this IEnumerable<MethodInfo> src, int arity)
            => src.Where(m => m.HasArityValue(arity));

        /// <summary>
        ///  Selects methods from a stream that have a specified parameter count
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        public static IEnumerable<MethodInfo> WithParameterCount(this IEnumerable<MethodInfo> src, int count)
            => from m in src
                where m.GetParameters().Length == count
                select m;

    }
}
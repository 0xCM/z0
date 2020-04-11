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
        ///  Selects methods from a stream that declare a parameter that has a specifid type
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        public static IEnumerable<MethodInfo> WithParameterType(this IEnumerable<MethodInfo> src, Type t)
            => src.Where(m => m.GetParameters().Any(p => p.ParameterType == t));

        /// <summary>
        ///  Selects methods from a stream that have specified parameter types
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        public static IEnumerable<MethodInfo> WithParameterTypes(this IEnumerable<MethodInfo> src, params Type[] types)
            => from m in src
                where m.ParameterTypes(true).Intersect(types).Count() == types.Length
                select m;
    }
}
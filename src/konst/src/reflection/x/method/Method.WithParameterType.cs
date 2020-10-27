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

    using static Konst;

    partial class XReflex
    {
        /// <summary>
        ///  Selects methods from a stream that declare a parameter that has a specified type
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        [Op]
        public static MethodInfo[] WithParameterType(this MethodInfo[] src, Type t)
            => src.Where(m => m.GetParameters().Any(p => p.ParameterType == t));

        /// <summary>
        ///  Selects methods from a stream that declare a parameter that has a specified type
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <typeparam name="T">The parameter type to match</param>
        [Op, Closures(Closure)]
        public static MethodInfo[] WithParameterType<T>(this MethodInfo[] src)
            => src.Where(m => m.GetParameters().Any(p => p.ParameterType == typeof(T)));

        /// <summary>
        ///  Selects methods from a stream that have specified parameter types
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        [Op]
        public static MethodInfo[] WithParameterTypes(this MethodInfo[] src, params Type[] types)
            => from m in src where m.ParameterTypes(true).Intersect(types).Count() == types.Length select m;

    }
}
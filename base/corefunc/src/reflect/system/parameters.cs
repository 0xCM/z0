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
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    partial class Reflections
    {        
        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ParameterTypes(this MethodInfo m, bool effective)
            => effective ? m.ParameterTypes().Select(t => t.EffectiveType()) : m.ParameterTypes();
 
        /// <summary>
        /// Selects the method parameters that satisfy a predicate
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="predicate">The predicate to match</param>
        public static IEnumerable<ParameterInfo> Parameters(this MethodInfo src, Func<ParameterInfo,bool> predicate)
            => src.GetParameters().Where(predicate);

        /// <summary>
        /// Selects the methods from a stream where at least one parameter satisfies a specified predicate
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="predicate">The predicate to match</param>
        public static IEnumerable<MethodInfo> WithParameter(this IEnumerable<MethodInfo> src, Func<ParameterInfo,bool> predicate)
            => from m in src
                where m.Parameters(predicate).Count() != 0
                select m;

    }
}
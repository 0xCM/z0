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
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether a parameter has a parametrically-identified attribute
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <typeparam name="A">The attribute type to check</typeparam>
        public static bool Tagged<A>(this ParameterInfo p)
            where A : Attribute
                => System.Attribute.IsDefined(p, typeof(A));

        public static bool IsParametric(this ParameterInfo src)
            => src.ParameterType.IsGenericParameter 
            || src.ParameterType.IsGenericMethodParameter 
            || src.ParameterType.IsGenericTypeParameter;

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
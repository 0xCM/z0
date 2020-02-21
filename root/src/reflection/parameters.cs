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

    using static Root;
    using static ReflectionFlags;
    
    partial class RootReflections
    {
        public static bool IsParametric(this ParameterInfo src)
            => src.ParameterType.IsGenericParameter 
            || src.ParameterType.IsGenericMethodParameter 
            || src.ParameterType.IsGenericTypeParameter;

        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsImmediate(this ParameterInfo param)
            => param.Attributed<ImmAttribute>();

        /// <summary>
        /// Determines the variance of a parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static ParamVariance Variance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamVariance.In  : src.IsOut 
            ? Z0.ParamVariance.Out : src.ParameterType.IsByRef 
            ? Z0.ParamVariance.Ref : Z0.ParamVariance.None;

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

        /// <summary>
        /// Determines whether a parameter has a parametrically-identified attribute
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <typeparam name="A">The attribute type to check</typeparam>
        public static bool Attributed<A>(this ParameterInfo p)
            where A : Attribute
                => System.Attribute.IsDefined(p, typeof(A));

    }
}
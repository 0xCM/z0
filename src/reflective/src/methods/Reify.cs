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
        /// Reifies a method if it is open generic; otherwise, returns the original method
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="args">The types over which to close the method</param>
        public static MethodInfo Reify(this MethodInfo m, params Type[] args)
        {
            if(m.IsGenericMethodDefinition)
                return m.MakeGenericMethod(args);            
            else if(m.IsConstructedGenericMethod)
                return m;
            else if(m.IsGenericMethod)
                return m.GetGenericMethodDefinition().MakeGenericMethod(args);
            else
                return m;
        }

        /// <summary>
        /// Reifies generic source methods with supplied type arguments
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static IEnumerable<MethodInfo> Reify(this IEnumerable<MethodInfo> src, params Type[] args)
            => src.Select(m => m.Reify(args));

        /// <summary>
        /// Reifies a 1-parameter generic method with a parametric type argument
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static MethodInfo Reify<T>(this MethodInfo src)
            => src.Reify(typeof(T));

        /// <summary>
        /// Reifies a 2-parameter generic method with a parametric type argument
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The type arguments</param>
        public static MethodInfo Reify<T1,T2>(this MethodInfo src)
            => src.Reify(typeof(T1), typeof(T2));
    }
}
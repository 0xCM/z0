//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
        
    public static class OpIndexX
    {
        public static OpIndex<M> ToOpIndex<M>(this IEnumerable<M> src)
            where M : struct, IApiMember
                => OpIndex.From(src.Select(h => (h.Id, h)));

        public static OpIndex<M> ToOpIndex<M>(this ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => OpIndex.From(src.ArrayMap(h => (h.Id, h)));

        public static OpIndex<M> ToOpIndex<M>(this Span<M> src)
            where M : struct, IApiMember            
               => src.ReadOnly().ToOpIndex();

        /// <summary>
        /// Determines whether a method is a numeric operator with a specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumericOperator(this MethodInfo m, int? arity = null)
            => m.IsOperator()  && m.IsNumeric() && (arity != null ? m.ArityValue() == arity : true);        

        /// <summary>
        /// Queries the stream for methods that are recognized as numeric operators
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> NumericOperators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsNumericOperator());

        /// <summary>
        /// Selects numeric operators with a specifed arity from the source stream
        /// </summary>
        /// <param name="src">The methods to filter</param>
        public static IEnumerable<MethodInfo> NumericOperators(this IEnumerable<MethodInfo> src, int arity)
            => src.Where(x => x.IsNumericOperator(arity));
    }        
}
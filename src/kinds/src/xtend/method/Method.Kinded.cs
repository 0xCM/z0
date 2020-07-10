//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Determines whether the method has a kind identifier
        /// </summary>
        /// <param name="m">The source method</param>
        public static bool IsKinded(this MethodInfo m)
            => m.KindId() != 0;

        /// <summary>
        /// Determines whether a method defines an operator with identified kind
        /// </summary>
        /// <param name="m">The source method</param>
        public static bool IsKindedOperator(this MethodInfo m)
            => m.IsKinded() && m.IsOperator();

        /// <summary>
        /// Queries the stream for methods that have a nonemtpy kind assignment
        /// </summary>
        /// <param name="src">The souce methods</param>
        public static IEnumerable<MethodInfo> Kinded(this IEnumerable<MethodInfo> src)
            => src.Where(IsKinded);

        /// <summary>
        /// Queries the stream for mathods that are of a specified kind
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<MethodInfo> Kinded(IEnumerable<MethodInfo> src, OpKindId kind)
            => from m in src where m.KindId() == kind select m;

        /// <summary>
        /// Queries the stream for methods that have a nonemtpy kind assignment
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<MethodInfo> KindedOperators(this IEnumerable<MethodInfo> src)
            => src.Where(IsKindedOperator);
    }
}
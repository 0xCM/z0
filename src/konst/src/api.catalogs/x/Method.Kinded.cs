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

    partial class XKinds
    {
        /// <summary>
        /// Determines whether the method has a kind identifier
        /// </summary>
        /// <param name="m">The source method</param>
        [Op]
        public static bool IsKinded(this MethodInfo m)
            => m.KindId() != 0;

        /// <summary>
        /// Determines whether a method defines an operator with identified kind
        /// </summary>
        /// <param name="m">The source method</param>
        [Op]
        public static bool IsKindedOperator(this MethodInfo m)
            => m.IsKinded() && m.IsOperator();

        /// <summary>
        /// Queries the stream for methods that have a nonempty kind assignment
        /// </summary>
        /// <param name="src">The source methods</param>
        [Op]
        public static MethodInfo[] Kinded(this MethodInfo[] src)
            => src.Where(IsKinded);

        /// <summary>
        /// Queries the stream for mathods that are of a specified kind
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="kind">The kind to match</param>
        [Op]
        public static MethodInfo[] Kinded(MethodInfo[] src, ApiClass kind)
            => from m in src where m.KindId() == kind select m;

        /// <summary>
        /// Queries the stream for methods that have a nonempty kind assignment
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        [Op]
        public static IEnumerable<MethodInfo> KindedOperators(this IEnumerable<MethodInfo> src)
            => src.Where(IsKindedOperator);
    }
}
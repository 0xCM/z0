//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    partial class XKinds
    {
        /// <summary>
        /// Returns true if a method is open generic with parametric arity 2 and is attributed
        /// with both natural an numeric closures
        /// </summary>
        /// <param name="m">The method to test</param>
        [Op]
        public static bool IsNaturalNumeric(this MethodInfo m)
            => m.IsOpenGeneric(2) &&  m.Tagged<OpAttribute>() && m.Tagged<NumericClosuresAttribute>() && m.Tagged<NaturalsAttribute>();

        /// <summary>
        /// Selects the natural numeric methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static IEnumerable<MethodInfo> NaturalNumeric(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.IsNaturalNumeric());
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    using static Root;

    using NK = NumericKind;
    using NI = NumericIndicator;

    partial class RootNumericOps
    {
       [MethodImpl(Inline)]
        public static string Format(this NK k)
            => $"{k.Width()}{k.Indicator().Format()}";

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NK k)
            => k != 0;

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static ISet<NK> DistinctKinds(this NK k)  
            => NumericIdentity.kindset(k);    
    }
}
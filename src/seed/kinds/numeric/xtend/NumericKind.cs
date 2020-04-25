//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class XTend
    {
        /// <summary>
        /// Determines the numeric kind of a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static NumericKind NumericKind(this Type src)
            => NumericKinds.kind(src);

        /// <summary>
        /// Determines the numeric kind of a type-code identified type
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this TypeCode tc)
            => NumericKinds.kind(tc);            
    }
}
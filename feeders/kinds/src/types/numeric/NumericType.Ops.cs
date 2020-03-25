//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Kinds;

    public static class NumericTypeOps
    {
        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this TypeCode tc)
            => NumericTypes.kind(tc);

        /// <summary>
        /// Returns true if the source type represents a primal numeric type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static bool IsNumeric(this Type src)
            => NumericTypes.test(src);

        [MethodImpl(Inline)]
        public static NumericKind ToNumericKind(this FixedWidth width, NumericIndicator indicator) 
            => NumericTypes.kind(width,indicator);
    }
}
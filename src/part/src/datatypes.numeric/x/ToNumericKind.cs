//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XNumeric
    {
        /// <summary>
        /// Determines the system type represented by a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static Type ToSystemType(this NumericKind src)
            => Numeric.type(src);

        [MethodImpl(Inline), Op]
        public static NumericKind ToNumericKind(this NumericWidth width, NumericIndicator indicator)
            => Numeric.kind(width, indicator);

        /// <summary>
        /// Determines the numeric kind of a type-code identified type
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline), Op]
        public static NumericKind ToNumericKind(this TypeCode tc)
            => Numeric.kind(tc);
    }
}
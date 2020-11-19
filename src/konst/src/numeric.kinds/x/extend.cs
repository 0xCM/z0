//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericKinds;

    partial class XNumericKinds
    {
        /// <summary>
        /// Determines whether a numeric kind designates a floating-point type
        /// </summary>
        /// <param name="T">The type to test</param>
        [MethodImpl(Inline)]
        public static bool IsFloat(this NumericKind src)
            => floating(src);

        /// <summary>
        /// Determines whether a numeric kind is nonempty
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericKind k)
            => k != 0;

        /// <summary>
        /// Determines whether a numeric kind designates an unsigned integral type
        /// </summary>
        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NumericKind src)
            => unsigned(src);

        /// <summary>
        /// Determines the type identifer of a numeric kind
        /// </summary>
        /// <param name="kind">The source kind</param>
        [MethodImpl(Inline)]
        public static NumericApiKind NumericId(this NumericKind kind)
        {
            var noClass = ((uint)kind << 3) >> 3;
            var noWidth = (noClass >> 16) << 16;
            var key = (NumericApiKind)noWidth;
            return key;
        }
    }
}
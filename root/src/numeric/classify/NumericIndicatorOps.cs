//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using NI = NumericIndicator;

    partial class RootNumericOps
    {
        /// <summary>
        /// Determines whether the kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NI src)
            => src != 0;

        /// <summary>
        /// Determines whether the kind is zero-valued
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNone(this NI src)
            => src == 0;

        [MethodImpl(Inline)]
        public static bool IsValid(this NI src)
            => Enum.IsDefined(typeof(NI), src);

        [MethodImpl(Inline)]
        public static bool IsSigned(this NI src)
            => src == NI.Signed;

        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NI src)
            => src == NI.Unsigned;

        [MethodImpl(Inline)]
        public static bool IsFloat(this NI src)
            => src == NI.Float;

        /// <summary>
        /// Converts the source indicator to a character representation
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static char ToChar(this NI src)
            => src.IsSome() ? (char)src : 'e';

        /// <summary>
        /// Produces a canonical text representation of the
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static string Format(this NI src)
            => src.ToChar().ToString();         
    }
}

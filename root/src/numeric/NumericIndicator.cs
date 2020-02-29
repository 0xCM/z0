//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class NumericIndicatorOps
    {
        /// <summary>
        /// Determines whether the kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericIndicator src)
            => src != 0;

        /// <summary>
        /// Determines whether the kind is zero-valued
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNone(this NumericIndicator src)
            => src == 0;

        [MethodImpl(Inline)]
        public static bool IsValid(this NumericIndicator src)
            => Enum.IsDefined(typeof(NumericIndicator), src);

        [MethodImpl(Inline)]
        public static bool IsSigned(this NumericIndicator src)
            => src == NumericIndicator.Signed;

        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NumericIndicator src)
            => src == NumericIndicator.Unsigned;

        [MethodImpl(Inline)]
        public static bool IsFloat(this NumericIndicator src)
            => src == NumericIndicator.Float;

        /// <summary>
        /// Converts the source indicator to a character representation
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static char ToChar(this NumericIndicator src)
            => src.IsSome() ? (char)src : 'e';

        /// <summary>
        /// Produces a canonical text representation of the
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static string Format(this NumericIndicator src)
            => src.ToChar().ToString(); 
    }
}
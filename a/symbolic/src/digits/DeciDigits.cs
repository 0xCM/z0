//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static DeciDigit;

    public static class DeciDigits
    {
        /// <summary>
        /// Parses the decimal digit if possible; oterwise, raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        public static DeciDigit digit(char c)
            => (DeciDigit)((uint)c - (uint)'0');

        /// <summary>
        /// Parses valid decimail digits from the source string
        /// </summary>
        /// <param name="src">The source string</param>
        public static Span<DeciDigit> digits(string src)
        {
            var len = src.Length;
            Span<DeciDigit> dst = new DeciDigit[len];
            for(var i = 0; i< len; i++)
                dst[i] = digit(src[i]);            
            return dst;            
        }

        /// <summary>
        /// Gets the sequence of decimal digits defined by a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static DeciDigit[] Get(byte src)
            => src.ToString().Select(DeciDigits.digit).ToArray();

        /// <summary>
        /// Gets the sequence of decimal digits defined by a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static DeciDigit[] Get(ushort src)
            => src.ToString().Select(DeciDigits.digit).ToArray();

        /// <summary>
        /// Gets the sequence of decimal digits defined by a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static DeciDigit[] Get(uint src)
            => src.ToString().Select(DeciDigits.digit).ToArray();
    }
}
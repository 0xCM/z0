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

    public class DecimalDigits
    {
        /// <summary>
        /// Parses the decimal digit if possible; oterwise, raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static DecimalDigit digit(char c)
            => (DecimalDigit)((uint)c - (uint)'0');

        /// <summary>
        /// Parses valid decimail digits from the source string
        /// </summary>
        /// <param name="src">The source string</param>
        public static Span<DecimalDigit> digits(string src)
        {
            var len = src.Length;
            Span<DecimalDigit> dst = new DecimalDigit[len];
            for(var i = 0; i< len; i++)
                dst[i] = digit(src[i]);            
            return dst;            
        }


    }
}
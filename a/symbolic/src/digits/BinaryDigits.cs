//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static BinaryDigit;
    using static Seed;
    
    public static class BinaryDigits
    {
        /// <summary>
        /// Parses a binary digit if possible; otheriwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static BinaryDigit parse(char c)
            => c == '1' ? D1 : D0;

        /// <summary>
        /// Transforms a charcter span into a span of binary digits
        /// </summary>
        /// <param name="src">The source string</param>
        public static Span<BinaryDigit> parse(ReadOnlySpan<char> src)
        {
            var offset = src.StartsWith("0b") ? 2 : 0;
            var len = src.Length - offset;
            Span<BinaryDigit> dst = new BinaryDigit[len];
            for(var i = offset; i< len; i++)
                dst[i] = parse(src[i]);            
            return dst;
        }
    }
}
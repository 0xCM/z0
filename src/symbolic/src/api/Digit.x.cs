//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;

    partial class XTend
    {
        public static Span<DecimalDigit> ToDeciDigits(this ulong src)
            => Symbolic.digits(base10, src);

        /// <summary>
        /// Formats a span of decimal digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string Format(this ReadOnlySpan<DecimalDigit> src)
        {
            Span<char> dst = new char[src.Length]; 
            for(var i = 0; i< src.Length; i++)
                seek(dst,i) = (char) Symbolic.symbol(skip(src,i));
            
            return new string(dst);
        }
    }
}
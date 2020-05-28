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
        [MethodImpl(Inline)]   
        public static char ToChar(this BinaryDigit src)
            => (char)Symbolic.symbol(src);

        [MethodImpl(Inline)]   
        public static char ToChar(this DecimalDigit src)
            => (char)Symbolic.symbol(src);

        [MethodImpl(Inline)]   
        public static char ToChar(this HexDigit src)
            => (char)Symbolic.symbol(UpperCased.Case, src);

        public static Span<DecimalDigit> ToDeciDigits(this long src)
            => DecimalDigits.digits(src.ToString());

        /// <summary>
        /// Formats a span of binary digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string Format(this ReadOnlySpan<BinaryDigit> src, bool reorient = true)
        {
            if(reorient)
                src = src.Reverse();
            var dst = new char[src.Length + 2];             
            dst[0] = '0';
            dst[1] = 'b';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].ToChar();
            return new string(dst);
        }

        /// <summary>
        /// Formats a span of binary digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<BinaryDigit> src)
            => src.ReadOnly().Format(true);

        /// <summary>
        /// Formats a span of decimal digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string Format(this ReadOnlySpan<DecimalDigit> src)
        {
            var dst = new char[src.Length]; 
            for(var i = 0; i< src.Length; i++)
                dst[i] = (char) src[i].ToChar();
            return new string(dst);
        }

        /// <summary>
        /// Formats a span of decimal digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<DecimalDigit> src)
            => src.ReadOnly().Format();

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string Format(this ReadOnlySpan<HexDigit> src, bool specifier = true)
        {
            var dst = new char[src.Length + 2]; 
            var dstStart = specifier ? 2 : 0;
            dst[0] = '0';
            dst[1] = 'x';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].ToChar();
            return new string(dst);
        }

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<HexDigit> src, bool specifier = true)
            => src.ReadOnly().Format(specifier);
    }
}
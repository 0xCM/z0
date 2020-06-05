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

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static string format(in AsciCode2 src)
            => AC2.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode4 src)
            => AC4.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode5 src)
            => AC5.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode8 src)
            => AC8.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode16 src)
            => AC16.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode32 src)
            => AC32.format(src);        

        /// <summary>
        /// Formats a span of decimal digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string format(ReadOnlySpan<DecimalDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length]; 
            for(var i = 0; i< src.Length; i++)
                seek(dst,i) = (char) Symbolic.symbol(skip(src,i));            
            return new string(dst);
        }
    }
}
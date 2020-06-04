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
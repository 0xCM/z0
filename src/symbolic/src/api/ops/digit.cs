//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        /// <summary>
        /// Returns the digit corresponding to a specified binary symbol
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline)]
        public static BinaryDigit digit(BinaryDigitSymbol c)
            => c == BinaryDigitSymbol.b1 ? BinaryDigit.b1 : BinaryDigit.b0;


        [MethodImpl(Inline), Op]   
        public static DecimalDigit digit(DecimalDigitSymbol c)
            => (DecimalDigit)((uint)c - (uint)DecimalDigitSymbol.d0);

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<BinaryDigitSymbol> src, Span<BinaryDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                Control.seek(dst,i) = Symbolic.digit(Control.skip(src,i));            
        }
    }
}
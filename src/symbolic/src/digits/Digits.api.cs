//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    [ApiHost]
    public class Digits : IApiHost<Digits>
    {
        /// <summary>
        /// Returns the symbol corresponding to a specified binary digit
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline), Op]   
        public static BinarySymbol symbol(BinaryDigit src)
            => (BinarySymbol)((uint)src + (uint)BinarySymbol.b0);

        /// <summary>
        /// Returns the digit corresponding to a specified binary symbol
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline)]
        public static BinaryDigit digit(BinarySymbol c)
            => c == BinarySymbol.b1 ? BinaryDigit.b1 : BinaryDigit.b0;

        [MethodImpl(Inline), Op]   
        public static DecimalSymbol symbol(DecimalDigit src)
            => (DecimalSymbol)((uint)src + (uint)DecimalSymbol.d0);

        [MethodImpl(Inline), Op]   
        public static HexSymbol symbol(HexDigit src)
            => (uint)src <= (uint)HexDigit.x9 
                ? (HexSymbol)((uint)src + (uint)HexDigit.x0) 
                : (HexSymbol)((uint)src + (uint)HexDigit.A);

        [MethodImpl(Inline), Op]   
        public static DecimalDigit digit(DecimalSymbol c)
            => (DecimalDigit)((uint)c - (uint)DecimalSymbol.d0);

        public static Span<BinaryDigit> digits(ReadOnlySpan<BinarySymbol> src)
        {
            var len = src.Length;
            Span<BinaryDigit> dst = new BinaryDigit[len];
            for(var i = 0; i< len; i++)
                dst[i] = digit(src[i]);            
            return dst;
        }
    }
}
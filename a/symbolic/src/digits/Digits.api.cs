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
    public static class Digits
    {
        [MethodImpl(Inline), Op]   
        public static BinaryDigitSymbol symbol(BinaryDigit src)
            => (BinaryDigitSymbol)((uint)src + (uint)BinaryDigitSymbol.Zed);

        /// <summary>
        /// Parses a binary digit if possible; otheriwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static BinaryDigit digit(BinaryDigitSymbol c)
            => c == BinaryDigitSymbol.One ? BinaryDigit.D1 : BinaryDigit.D0;

        [MethodImpl(Inline), Op]   
        public static DeciDigitSymbol symbol(DeciDigit src)
            => (DeciDigitSymbol)((uint)src + (uint)DeciDigitSymbol.D0);

        [MethodImpl(Inline), Op]   
        public static HexDigitSymbol symbol(HexDigit src)
            => (uint)src <= (uint)HexDigit.D9 
                ? (HexDigitSymbol)((uint)src + (uint)HexDigit.D0) 
                : (HexDigitSymbol)((uint)src + (uint)HexDigit.A);

        [MethodImpl(Inline), Op]   
        public static DeciDigit digit(DeciDigitSymbol c)
            => (DeciDigit)((uint)c - (uint)DeciDigitSymbol.D0);

        public static Span<BinaryDigit> digits(ReadOnlySpan<BinaryDigitSymbol> src)
        {
            var len = src.Length;
            Span<BinaryDigit> dst = new BinaryDigit[len];
            for(var i = 0; i< len; i++)
                dst[i] = digit(src[i]);            
            return dst;
        }
    }
}
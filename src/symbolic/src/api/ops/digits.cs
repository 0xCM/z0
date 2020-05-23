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

    using HSL = HexDigitSymbolLo;
    using HSU = HexDigitSymbolUp;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSL> src, Span<HexDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSU> src, Span<HexDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<BinaryDigitSymbol> src, Span<BinaryDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }
    }
}
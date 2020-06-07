//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;
    using static Typed;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciChar> symbols(ASCI asci)
            => cast<char,AsciChar>(AsciStrings.Text(n0));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciChar> symbols(ASCI asci, int i0, int i1)
            => cast<char,AsciChar>(Symbolic.segment(AsciStrings.Text(n0),i0,i1));

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<BinaryDigit> src, Span<BinarySymbol> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<DecimalDigit> src, Span<DecimalSymbol> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void symbols(UpperCased @case, ReadOnlySpan<HexDigit> src, Span<HexSymbol> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = symbol(@case, skip(src,i));            
        }
    }
}
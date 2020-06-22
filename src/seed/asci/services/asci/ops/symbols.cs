//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;
    using static Typed;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciChar> symbols()
            => cast<char,AsciChar>(AsciStrings.Text(n0));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciChar> symbols(int i0, int i1)
            => cast<char,AsciChar>(As.segment(AsciStrings.Text(n0),i0,i1));

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<BinaryDigit> src, Span<BinarySym> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<DeciDigit> src, Span<DeciSym> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void symbols(UpperCased @case, ReadOnlySpan<HexDigit> src, Span<HexSym> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = symbol(@case, skip(src,i));            
        }
    }
}
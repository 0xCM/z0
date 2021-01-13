//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct SymbolStore
    {
        [MethodImpl(Inline), Op]
        public static void convert(ReadOnlySpan<BinaryDigit> src, Span<BinarySym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = Symbolic.symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void convert(ReadOnlySpan<DecimalDigit> src, Span<DecimalSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = Symbolic.symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void convert(UpperCased @case, ReadOnlySpan<HexDigit> src, Span<HexSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = Symbolic.symbol(@case, skip(src,i));
        }
    }
}
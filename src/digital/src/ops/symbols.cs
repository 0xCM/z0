//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<BinaryDigit> src, Span<BinarySym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<OctalDigit> src, Span<OctalSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<DecimalDigit> src, Span<DecimalSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }
    }
}
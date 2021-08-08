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

    partial struct SymbolicRender
    {
        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<AsciCode> src, ref uint i, Span<char> dst)
        {
            var count = (uint)src.Length;
            for(var j=0; j<count; j++)
                seek(dst,i++) = (char)skip(src,j);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<AsciSymbol> src, ref uint i, Span<char> dst)
        {
            var count = (uint)src.Length;
            for(var j=0; j<count; j++)
                seek(dst,i++) = (char)skip(src,j);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<char> src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            var count = (uint)src.Length;
            for(var j=0; j<count; j++)
                seek(dst,i++) = skip(src,j);
            return i-i0;
        }
    }
}
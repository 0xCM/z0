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

    readonly partial struct SymbolicCalcs
    {
        [MethodImpl(Inline), Op]
        public static uint convert(ReadOnlySpan<AsciCode> src, Span<char> dst)
        {
            var count = (uint)min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = (char)skip(src,i);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static uint convert(ReadOnlySpan<char> src, Span<AsciCode> dst)
        {
            var count = (uint)min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = (AsciCode)skip(src,i);
            return count;
        }
    }
}
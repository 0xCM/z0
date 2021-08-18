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

    partial struct BitRender
    {
        [MethodImpl(Inline), Op]
        public static uint renderNx8x4(ReadOnlySpan<byte> src, ref uint i, Span<char> dst)
        {
            var i0=i;
            var size = (int)src.Length;
            var length = min(size, dst.Length);
            for(var j=0; j<length; j++)
                render8x4(skip(src, j), ref i, dst);
            return i-i0;
        }
    }
}
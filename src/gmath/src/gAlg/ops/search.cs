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
    using static gmath;

    partial struct gAlg
    {
        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static bit search<T>(N4 n, in T src, T match, uint offset)
            where T : unmanaged
                => eq(match, memory.add(src, offset + 0)) ||
                   eq(match, memory.add(src, offset + 1)) ||
                   eq(match, memory.add(src, offset + 2)) ||
                   eq(match, memory.add(src, offset + 3));


        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static bit search<T>(N8 n, in T src, T match, uint offset)
            where T : unmanaged
                => eq(match, memory.add(src, offset + 0)) ||
                   eq(match, memory.add(src, offset + 1)) ||
                   eq(match, memory.add(src, offset + 2)) ||
                   eq(match, memory.add(src, offset + 3)) ||
                   eq(match, memory.add(src, offset + 4)) ||
                   eq(match, memory.add(src, offset + 5)) ||
                   eq(match, memory.add(src, offset + 6)) ||
                   eq(match, memory.add(src, offset + 7)
                    );
    }
}
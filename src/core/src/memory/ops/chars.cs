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

    unsafe partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> chars(in MemoryStrings src)
            => cover(src.CharBase.Pointer<char>(), src.CharCount);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> chars(MemoryAddress @base, int i0, int i1)
            => cover(@base.Pointer<char>() + i0, (i1 - i0));

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> chars(in MemoryStrings src, int index)
            => slice(chars(src), offset(src,index), length(src,index));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in MemoryStrings src, uint index)
            => chars(src,(int)index);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Addressable
    {
       [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static unsafe Span<T> edit<T>(MemoryAddress src, uint count)
            => As.cover(src.Ref<T>(), count);

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static unsafe Span<byte> edit(MemoryAddress src, ByteSize size)
            => As.cover(src.Ref<byte>(), size);
    }
}
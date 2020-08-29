//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Address
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> edit2<T>(MemoryAddress src, uint count)
            => z.cover(src.Ref<T>(), count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<byte> edit2(MemoryAddress src, ByteSize size)
            => z.cover(src.Ref<byte>(), size);
    }
}
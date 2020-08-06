//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class memory
    {

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, int count)
            where T : unmanaged
                => z.cover<T>(src.Ref<T>(), (uint)count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, uint count)
            where T : unmanaged
                => z.cover<T>(src.Ref<T>(), count);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> view(MemoryAddress src, ByteSize size)
            => z.cover<byte>(src.Ref<byte>(), size);

    }

    partial struct Addressable
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, int count)
            where T : unmanaged
                => z.cover<T>(src.Ref<T>(), (uint)count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, uint count)
            where T : unmanaged
                => z.cover<T>(src.Ref<T>(), count);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> view(MemoryAddress src, ByteSize size)
            => z.cover<byte>(src.Ref<byte>(), size);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op]
        public static Ref segment(MemoryAddress address, ByteSize size)
            => new Ref(address, size);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Ref<T> segment<T>(T* pSrc, ByteSize size)
            where T : unmanaged
                => new Ref<T>(pSrc, size);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<T> segment<T>(MemoryAddress address, Count count)
            where T : unmanaged
                => new Ref<T>(address, size<T>()*count);
    }
}
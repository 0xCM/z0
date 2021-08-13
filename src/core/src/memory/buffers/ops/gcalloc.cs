//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    unsafe partial struct Buffers
    {
        [Op]
        public static ManagedBuffer gcalloc(ByteSize size)
            => new ManagedBuffer(GCHandle.Alloc(new byte[size], GCHandleType.Pinned), size);

        [Op, Closures(Closure)]
        public static ManagedBuffer<T> gcalloc<T>(ulong count)
            where T : unmanaged
                => new ManagedBuffer<T>(GCHandle.Alloc(new T[count], GCHandleType.Pinned), (uint)count*size<T>());

        [Op, Closures(Closure)]
        public static ManagedBuffer<T> gcalloc<T>(long count)
            where T : unmanaged
                => gcalloc<T>((ulong)count);
    }
}
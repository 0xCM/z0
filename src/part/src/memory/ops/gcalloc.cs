//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    partial struct memory
    {
        [Op]
        public static Allocation gcalloc(ByteSize size)
            => new Allocation(GCHandle.Alloc(new byte[size], GCHandleType.Pinned), size);

        [Op, Closures(Closure)]
        public static Allocation<T> gcalloc<T>(ulong count)
            where T : unmanaged
                => new Allocation<T>(GCHandle.Alloc(new T[count], GCHandleType.Pinned), (uint)count*size<T>());

        [Op, Closures(Closure)]
        public static Allocation<T> gcalloc<T>(long count)
            where T : unmanaged
                => gcalloc<T>((ulong)count);
    }
}
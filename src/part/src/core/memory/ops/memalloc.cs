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

    partial struct memory
    {
        [Op]
        public static Allocation memalloc(ByteSize size)
            => new Allocation(GCHandle.Alloc(new byte[size]), size);

        [Op, Closures(Closure)]
        public static Allocation<T> memalloc<T>(ulong count)
            where T : unmanaged
                => new Allocation<T>(GCHandle.Alloc(new T[count], GCHandleType.Pinned), (uint)count*size<T>());

        [Op, Closures(Closure)]
        public static Allocation<T> memalloc<T>(long count)
            where T : unmanaged
                => memalloc<T>((ulong)count);
    }
}
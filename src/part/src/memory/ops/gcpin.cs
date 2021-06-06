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
        public static Allocation gcpin(byte[] buffer)
            => new Allocation(GCHandle.Alloc(buffer, GCHandleType.Pinned), (uint)buffer.Length);

        [Op, Closures(Closure)]
        public static Allocation<T> gcpin<T>(T[] buffer)
            where T : unmanaged
                => new Allocation<T>(GCHandle.Alloc(buffer, GCHandleType.Pinned), (uint)buffer.Length*size<T>());
    }
}
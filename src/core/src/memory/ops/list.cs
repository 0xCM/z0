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
        public static MemoryList<T> list<T>(uint count)
            where T : unmanaged
                => new MemoryList<T>(Buffers.native(count*size<T>()));
    }
}
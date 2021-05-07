//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Resources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static StringRes<E> define<E>(E id, MemoryAddress address, ByteSize size)
            where E : unmanaged
                => new StringRes<E>(id, address, size);
    }
}
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

    partial struct Resources
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static StringResource<E> define<E>(E id, MemoryAddress location, uint length)
            where E : unmanaged
                => new StringResource<E>(id, location, length);
    }
}
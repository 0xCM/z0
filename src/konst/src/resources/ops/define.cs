//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static StringRes<E> define<E>(E id, MemoryAddress location, uint length)
            where E : unmanaged
                => new StringRes<E>(id, location, length);
    }
}
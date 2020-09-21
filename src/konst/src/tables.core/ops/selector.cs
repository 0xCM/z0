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

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableSelector<D,S> selector<D,S>(D id, S s = default)
            where D : unmanaged, Enum
            where S : unmanaged
                => new TableSelector<D,S>(id);

        [MethodImpl(Inline)]
        public static TableSectors<D,S> selectors<D,S>(TableSelector<D,S>[] src, S min, S max)
            where D : unmanaged, Enum
            where S : unmanaged
                => new TableSectors<D,S>(src,min,max);
    }
}
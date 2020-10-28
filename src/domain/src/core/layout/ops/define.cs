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

    partial struct DataLayouts
    {
        [MethodImpl(Inline), Op]
        public static DataLayout define(LayoutIdentity id, LayoutPartition[] segments)
            => new DataLayout(id, segments);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataLayout<T> define<T>(LayoutIdentity<T> id, LayoutPartition<T>[] segments)
            where T : unmanaged
                => new DataLayout<T>(id, segments);
    }
}
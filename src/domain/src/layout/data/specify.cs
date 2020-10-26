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
        public static DataLayout specify(uint index, ulong kind, params LayoutPartition[] parts)
            => new DataLayout(identify(index, kind), parts);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataLayout<T> specify<T>(uint index, T kind, params LayoutPartition<T>[] parts)
            where T : unmanaged
                => new DataLayout<T>(identify(index, kind), parts);

        [Op, Closures(Closure)]
        public static DataLayout<T> specify<T>(uint index, T kind, uint count)
            where T : unmanaged
                => new DataLayout<T>(identify(index, kind), alloc<LayoutPartition<T>>(count));
    }
}
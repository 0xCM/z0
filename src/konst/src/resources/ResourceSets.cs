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

    [ApiHost]
    public readonly struct ResourceSets
    {
        [MethodImpl(Inline)]
        public static ByteSize size<A>()
            where A : unmanaged
                => (ByteSize)size<A>();

        [MethodImpl(Inline)]
        public static int offset<A>(int index)
            where A : unmanaged
                => index*size<A>();

        [MethodImpl(Inline)]
        public static int count<A>(int datasize)
            where A : unmanaged
                => datasize/size<A>();
    }
}
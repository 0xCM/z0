//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Resources
    {
        [MethodImpl(Inline)]
        public static ByteSize size<A>()
            where A : unmanaged, IBytes
                => (ByteSize)size<A>();

        [MethodImpl(Inline)]
        public static int offset<A>(int index)
            where A : unmanaged, IBytes
                => index*size<A>();

        [MethodImpl(Inline)]
        public static int count<A>(int datasize)
            where A : unmanaged, IBytes
                => datasize/size<A>();
    }
}
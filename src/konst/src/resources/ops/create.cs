//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    partial struct Resources
    {
        [MethodImpl(Inline)]
        public static ByteSize size<A>()
            where A : unmanaged, IByteSeq
                => (ByteSize)size<A>();

        [MethodImpl(Inline)]
        public static ulong offset<A>(int index)
            where A : unmanaged, IByteSeq
                => index*size<A>();

        [MethodImpl(Inline)]
        public static ulong count<A>(int datasize)
            where A : unmanaged, IByteSeq
                => datasize/size<A>();
    }
}
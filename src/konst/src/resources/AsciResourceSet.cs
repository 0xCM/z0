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
    public readonly struct AsciResourceSet
    {        
        [MethodImpl(Inline)]
        public static ByteSize size<A>()
            where A : unmanaged, IAsciSequence
                => (ByteSize)size<A>();

        [MethodImpl(Inline)]
        public static int offset<A>(int index)
            where A : unmanaged, IAsciSequence
                => index*size<A>();

        [MethodImpl(Inline)]
        public static int count<A>(int datasize)
            where A : unmanaged, IAsciSequence
                => datasize/size<A>();

    }
}
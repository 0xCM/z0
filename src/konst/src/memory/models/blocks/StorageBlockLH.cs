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

    public struct StorageBlock<L,H>
        where L : unmanaged
        where H : unmanaged
    {
        public static ByteSize Size => size<L>() + size<H>();

        public L Lo;

        public H Hi;

        [MethodImpl(Inline)]
        public static implicit operator StorageBlock<L,H>((L lo, H hi) src)
            => new StorageBlock<L,H>(src.lo, src.hi);

        [MethodImpl(Inline)]
        public StorageBlock(L lo, H hi)
        {
            Lo = lo;
            Hi = hi;
        }
    }
}
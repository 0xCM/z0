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

    public struct DataBlock<L,H>
        where L : unmanaged
        where H : unmanaged
    {
        public static ByteSize Size => size<L>() + size<H>();

        public L Lo;

        public H Hi;

        [MethodImpl(Inline)]
        public static implicit operator DataBlock<L,H>((L lo, H hi) src)
            => new DataBlock<L,H>(src.lo, src.hi);

        [MethodImpl(Inline)]
        public DataBlock(L lo, H hi)
        {
            Lo = lo;
            Hi = hi;
        }
    }
}
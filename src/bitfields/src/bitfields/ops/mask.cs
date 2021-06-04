//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Typed;
    using static core;

    partial struct CpuBits
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(in Bitfield256<T> src, byte index)
            where T : unmanaged
                => BitMasks.lo<T>(src.SegWidth(index));

        [MethodImpl(Inline)]
        public static T mask<E,T>(in Bitfield256<E,T> src, E index)
            where E : unmanaged
            where T : unmanaged
                => BitMasks.lo<T>(src.SegWidth(index));
    }
}

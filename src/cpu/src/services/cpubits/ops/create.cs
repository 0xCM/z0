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

    partial struct CpuBits
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bitfield256<T> create<T>(Vector256<byte> widths, Vector256<T> state)
            where T : unmanaged
                => new Bitfield256<T>(widths, state);

        [MethodImpl(Inline)]
        public static Bitfield256<E,T> create<E,T>(Vector256<byte> widths, Vector256<T> state)
            where E : unmanaged
            where T : unmanaged
                => new Bitfield256<E,T>(widths, state);

        [MethodImpl(Inline)]
        public static Bitfield256<E,T> create<E,T>(Vector256<T> state)
            where E : unmanaged, Enum
            where T : unmanaged
                => new Bitfield256<E,T>(widths<E>(w256), state);
    }
}

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
    using static math;

    partial struct Bitfields
    {
        [MethodImpl(Inline), Op]
        public static Bitfield32 lo(Bitfield64 src)
            => create(((uint)src.State));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield8<T> lo<T>(Bitfield16<T> src)
            where T : unmanaged
                => create(w8, to<T>((byte)src.State));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield16<T> lo<T>(Bitfield32<T> src)
            where T : unmanaged
                => create(w16, to<T>((ushort)src.State));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield32<T> lo<T>(Bitfield64<T> src)
            where T : unmanaged
                => create(w32, to<T>((uint)src.State));
    }
}
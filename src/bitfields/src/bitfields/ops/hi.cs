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

    partial struct BitFields
    {
        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield8<T> hi<T>(Bitfield16<T> src)
            where T : unmanaged
                => create(w8, to<T>((byte)(math.srl(src.State,8))));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield16<T> hi<T>(Bitfield32<T> src)
            where T : unmanaged
                => create(w16, to<T>((ushort)(math.srl(src.State,16))));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield32<T> hi<T>(Bitfield64<T> src)
            where T : unmanaged
                => create(w32, to<T>((uint)(math.srl(src.State, Bitfield32.Width))));

        [MethodImpl(Inline), Op]
        public static Bitfield32 hi(Bitfield64 src)
            => create((uint)(math.srl(src.State, Bitfield32.Width)));
    }
}
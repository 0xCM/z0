//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CellDelegates;

    partial struct CellOps
    {
        [MethodImpl(Inline), Op]
        public static Emitter1 cellop1(Emitter<bit> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 cellop8(Emitter<sbyte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 cellop8(Emitter<byte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 cellop16(Emitter<short> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 cellop16(Emitter<ushort> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 cellop32(Emitter<int> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 cellop32(Emitter<uint> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 cellop64(Emitter<long> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 cellop64(Emitter<ulong> f)
            => () => f();
    }
}
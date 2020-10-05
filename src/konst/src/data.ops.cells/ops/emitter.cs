//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class CellOps
    {
        [MethodImpl(Inline), Op]
        public static Emitter1 emitter(Emitter<Bit32> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 emitter(Emitter<sbyte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 emitter(Emitter<byte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 emitter(Emitter<short> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 emitter(Emitter<ushort> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 emitter(Emitter<int> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 emitter(Emitter<uint> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 emitter(Emitter<long> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 emitter(Emitter<ulong> f)
            => () => f();
    }
}
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
        public static Emitter1 cellular(Emitter<bit> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 cellular(Emitter<sbyte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 cellular(Emitter<byte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 cellular(Emitter<short> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 cellular(Emitter<ushort> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 cellular(Emitter<int> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 cellular(Emitter<uint> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 cellular(Emitter<long> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 cellular(Emitter<ulong> f)
            => () => f();
    }
}
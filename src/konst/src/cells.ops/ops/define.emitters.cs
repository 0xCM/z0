//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct CellOps
    {
        // [MethodImpl(Inline), Op]
        // public static Emitter1 define(Emitter<Bit32> f)
        //     => () => f();

        // [MethodImpl(Inline), Op]
        // public static Emitter8 define(Emitter<sbyte> f)
        //     => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 define(Emitter<byte> f)
            => () => f();

        // [MethodImpl(Inline), Op]
        // public static Emitter16 define(Emitter<short> f)
        //     => () => f();

        // [MethodImpl(Inline), Op]
        // public static Emitter16 define(Emitter<ushort> f)
        //     => () => f();

        // [MethodImpl(Inline), Op]
        // public static Emitter32 define(Emitter<int> f)
        //     => () => f();

        // [MethodImpl(Inline), Op]
        // public static Emitter32 define(Emitter<uint> f)
        //     => () => f();

        // [MethodImpl(Inline), Op]
        // public static Emitter64 define(Emitter<long> f)
        //     => () => f();

        // [MethodImpl(Inline), Op]
        // public static Emitter64 define(Emitter<ulong> f)
        //     => () => f();
    }
}
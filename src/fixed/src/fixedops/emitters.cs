//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class FixedOps
    {
        [MethodImpl(Inline), Op]
        public static Emitter1 fix(Emitter<bit> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 fix(Emitter<sbyte> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter8 fix(Emitter<byte> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 fix(Emitter<short> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter16 fix(Emitter<ushort> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 fix(Emitter<int> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter32 fix(Emitter<uint> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 fix(Emitter<long> f) => () => f();

        [MethodImpl(Inline), Op]
        public static Emitter64 fix(Emitter<ulong> f) => () => f();
    }
}
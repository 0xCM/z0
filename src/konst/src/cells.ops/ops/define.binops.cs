//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct CellOps
    {
        [MethodImpl(Inline), Op]
        public static BinaryOp1 define(MethodInfo f, BinaryOpClass<Bit32> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(MethodInfo f, BinaryOpClass<sbyte> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(MethodInfo f, BinaryOpClass<byte> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(MethodInfo f, BinaryOpClass<short> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(MethodInfo f, BinaryOpClass<ushort> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(MethodInfo f, BinaryOpClass<uint> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(MethodInfo f, BinaryOpClass<int> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(MethodInfo f, BinaryOpClass<ulong> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(MethodInfo f, BinaryOpClass<long> k)
            => define(bFx(f,k));
    }
}
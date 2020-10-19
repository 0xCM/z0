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
    using static Kinds;

    partial class CellOps
    {

        [MethodImpl(Inline), Op]
        public static BinaryOp1 cellular(MethodInfo f, BinaryOpClass<Bit32> k)
            => cellular(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 binary(MethodInfo f, BinaryOpClass<sbyte> k)
            => cellular(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 cellular(MethodInfo f, BinaryOpClass<byte> k)
            => cellular(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 cellular(MethodInfo f, BinaryOpClass<short> k)
            => cellular(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 cellular(MethodInfo f, BinaryOpClass<ushort> k)
            => binary(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 cellular(MethodInfo f, BinaryOpClass<uint> k)
            => binary(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 cellular(MethodInfo f, BinaryOpClass<int> k)
            => binary(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 cellular(MethodInfo f, BinaryOpClass<ulong> k)
            => binary(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 cellular(MethodInfo f, BinaryOpClass<long> k )
            => binary(bFx(f,k));
    }
}
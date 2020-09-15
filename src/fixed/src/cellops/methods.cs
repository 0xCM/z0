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
        public static UnaryOp1 cellular(MethodInfo f, UnaryOpClass<bit> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 cellular(MethodInfo f, UnaryOpClass<sbyte> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 cellular(MethodInfo f, UnaryOpClass<byte> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp16 cellular(MethodInfo f, UnaryOpClass<short> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp16 cellular(MethodInfo f, UnaryOpClass<ushort> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 cellular(MethodInfo f, UnaryOpClass<uint> k)
            => cellular(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 cellular(MethodInfo f, UnaryOpClass<int> k)
            => cellular(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 cellular(MethodInfo f, UnaryOpClass<ulong> k)
            => cellular(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 cellular(MethodInfo f, UnaryOpClass<long> k )
            => cellular(unary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp1 cellular(MethodInfo f, BinaryOpClass<bit> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 cellular(MethodInfo f, BinaryOpClass<sbyte> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 cellular(MethodInfo f, BinaryOpClass<byte> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 cellular(MethodInfo f, BinaryOpClass<short> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 cellular(MethodInfo f, BinaryOpClass<ushort> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 cellular(MethodInfo f, BinaryOpClass<uint> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 cellular(MethodInfo f, BinaryOpClass<int> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 cellular(MethodInfo f, BinaryOpClass<ulong> k)
            => cellular(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 cellular(MethodInfo f, BinaryOpClass<long> k )
            => cellular(binary(f,k));
    }
}
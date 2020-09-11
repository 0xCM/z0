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
        public static UnaryOp1 fix(MethodInfo f, UnaryOpClass<bit> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 fix(MethodInfo f, UnaryOpClass<sbyte> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 fix(MethodInfo f, UnaryOpClass<byte> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp16 fix(MethodInfo f, UnaryOpClass<short> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp16 fix(MethodInfo f, UnaryOpClass<ushort> k)
            => create(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 fix(MethodInfo f, UnaryOpClass<uint> k)
            => fix(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 fix(MethodInfo f, UnaryOpClass<int> k)
            => fix(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(MethodInfo f, UnaryOpClass<ulong> k)
            => fix(unary(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(MethodInfo f, UnaryOpClass<long> k )
            => fix(unary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp1 fix(MethodInfo f, BinaryOpClass<bit> k) => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(MethodInfo f, BinaryOpClass<sbyte> k) => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(MethodInfo f, BinaryOpClass<byte> k) => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(MethodInfo f, BinaryOpClass<short> k) => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(MethodInfo f, BinaryOpClass<ushort> k)
            => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(MethodInfo f, BinaryOpClass<uint> k)
            => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(MethodInfo f, BinaryOpClass<int> k)
            => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(MethodInfo f, BinaryOpClass<ulong> k)
            => fix(binary(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(MethodInfo f, BinaryOpClass<long> k ) => fix(binary(f,k));
    }
}
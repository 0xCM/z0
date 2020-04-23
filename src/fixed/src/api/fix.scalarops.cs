//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class Fixed
    {
        [MethodImpl(Inline), Op]
        public static UnaryOp1 fix(UnaryOp<bit> f) => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 fix(UnaryOp<sbyte> f) => a => f((sbyte)a.Data);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 fix(UnaryOp<byte> f) => a => f((byte)a.Data);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 fix(UnaryOp<short> f) => a => f((short)a.Data);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 fix(UnaryOp<ushort> f) => a => f((ushort)a.Data);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 fix(UnaryOp<int> f) => a => f((int)a.Data);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 fix(UnaryOp<uint> f) => a => f((uint)a.Data);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(UnaryOp<long> f) => a => f((long)a.Data);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(UnaryOp<ulong> f) => a => f(a.Data);        
        [MethodImpl(Inline), Op]
        public static BinaryOp1 fix(BinaryOp<bit> f) => (a,b) => f(a,b);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(BinaryOp<sbyte> f) => (a, b) => f((sbyte)a.Data, (sbyte)b.Data);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(BinaryOp<byte> f) => (a, b) => f(a.Data, b.Data);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(BinaryOp<short> f) => (a, b) => f((short)a.Data, (short)b.Data);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(BinaryOp<ushort> f) => (a, b) => f(a.Data, b.Data);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(BinaryOp<int> f) => (a, b) => f((int)a.Data, (int)a.Data);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(BinaryOp<uint> f) => (a, b)  => f(a.Data, b.Data);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(BinaryOp<long> f) => (a, b)  => f((long)a.Data, (long)b.Data);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(BinaryOp<ulong> f) => (a, b)  => f(a.Data, b.Data);
    }
}
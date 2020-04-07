//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Fixed
    {
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
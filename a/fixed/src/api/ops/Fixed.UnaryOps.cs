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

    }
}
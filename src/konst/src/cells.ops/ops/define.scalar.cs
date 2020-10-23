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
        public static BinaryOp1 define(BinaryOp<Bit32> f)
            => (a,b) => f(a,b);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(BinaryOp<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(BinaryOp<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(BinaryOp<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(BinaryOp<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(BinaryOp<int> f)
            => (a, b) => f((int)a.Content, (int)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(BinaryOp<uint> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(BinaryOp<long> f)
            => (a, b)  => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(BinaryOp<ulong> f)
            => (a, b)  => f(a.Content, b.Content);
    }
}
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
        public static BinaryOp1 cellular(BinaryOp<Bit32> f)
            => (a,b) => f(a,b);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 cellular(BinaryOp<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 cellular(BinaryOp<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 cellular(BinaryOp<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 binary(BinaryOp<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 binary(BinaryOp<int> f)
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 binary(BinaryOp<uint> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 binary(BinaryOp<long> f)
            => (a, b)  => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 binary(BinaryOp<ulong> f)
            => (a, b)  => f(a.Content, b.Content);
    }
}
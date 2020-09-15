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

    using K = Kinds;

    partial class CellOps
    {
        [MethodImpl(Inline), Op]
        public static UnaryOp1 create(UnaryOp<bit> f)
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 create(UnaryOp<sbyte> f)
            => a => f((sbyte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 create(UnaryOp<byte> f)
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 create(UnaryOp<short> f)
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 create(UnaryOp<ushort> f)
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 cellular(UnaryOp<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 cellular(UnaryOp<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 cellular(UnaryOp<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 cellular(UnaryOp<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp1 cellular(BinaryOp<bit> f)
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
        public static BinaryOp16 cellular(BinaryOp<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 cellular(BinaryOp<int> f)
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 cellular(BinaryOp<uint> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 cellular(BinaryOp<long> f)
            => (a, b)  => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 cellular(BinaryOp<ulong> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline)]
        internal static UnaryOp<T> unary<T>(MethodInfo src, UnaryOpClass<T> k)
            where T : unmanaged
                => Delegates.unary<T>(src);

        [MethodImpl(Inline)]
        internal static BinaryOp<T> binary<T>(MethodInfo src, BinaryOpClass<T> K)
            where T : unmanaged
                => Delegates.binary<T>(src);
    }
}
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
        public static UnaryOp32 fix(UnaryOp<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 fix(UnaryOp<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(UnaryOp<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(UnaryOp<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp1 fix(BinaryOp<bit> f)
            => (a,b) => f(a,b);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(BinaryOp<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(BinaryOp<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(BinaryOp<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(BinaryOp<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(BinaryOp<int> f)
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(BinaryOp<uint> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(BinaryOp<long> f)
            => (a, b)  => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(BinaryOp<ulong> f)
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
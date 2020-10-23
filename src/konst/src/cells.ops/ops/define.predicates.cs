//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct CellOps
    {
        [MethodImpl(Inline), Op]
        public static UnaryPredicate1 define(UnaryPredicate<Bit32> f)
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 define(UnaryPredicate<sbyte> f)
            => a => f((sbyte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 define(UnaryPredicate<byte> f)
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 define(UnaryPredicate<short> f)
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 define(UnaryPredicate<ushort> f)
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 define(UnaryPredicate<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 define(UnaryPredicate<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 define(UnaryPredicate<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 define(UnaryPredicate<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate1 define(BinaryPredicate<Bit32> f)
            => (a, b) => f(a, b);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 define(BinaryPredicate<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 define(BinaryPredicate<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 define(BinaryPredicate<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 define(BinaryPredicate<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 define(BinaryPredicate<int> f)
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 define(BinaryPredicate<uint> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 define(BinaryPredicate<long> f)
            => (a, b) => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 define(BinaryPredicate<ulong> f)
            => (a, b) => f(a.Content, b.Content);
    }
}
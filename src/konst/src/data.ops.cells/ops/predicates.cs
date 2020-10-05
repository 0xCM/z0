//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class CellOps
    {
        [MethodImpl(Inline), Op]
        public static UnaryPredicate1 cellular(UnaryPredicate<Bit32> f)
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 cellular(UnaryPredicate<sbyte> f)
            => a => f((sbyte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 cellular(UnaryPredicate<byte> f)
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 cellular(UnaryPredicate<short> f)
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 cellular(UnaryPredicate<ushort> f)
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 cellular(UnaryPredicate<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 cellular(UnaryPredicate<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 cellular(UnaryPredicate<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 cellular(UnaryPredicate<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate1 cellular(BinaryPredicate<Bit32> f)
            => (a, b) => f(a, b);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 cellular(BinaryPredicate<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 cellular(BinaryPredicate<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 cellular(BinaryPredicate<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 cellular(BinaryPredicate<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 cellular(BinaryPredicate<int> f)
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 cellular(BinaryPredicate<uint> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 cellular(BinaryPredicate<long> f)
            => (a, b) => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 cellular(BinaryPredicate<ulong> f)
            => (a, b) => f(a.Content, b.Content);
    }
}
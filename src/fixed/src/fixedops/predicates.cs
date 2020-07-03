//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class FixedOps
    {
        [MethodImpl(Inline), Op]
        public static UnaryPredicate1 fix(UnaryPredicate<bit> f) 
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 fix(UnaryPredicate<sbyte> f) 
            => a => f((sbyte)a.Content);


        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 fix(UnaryPredicate<byte> f) 
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 fix(UnaryPredicate<short> f) 
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 fix(UnaryPredicate<ushort> f) 
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 fix(UnaryPredicate<int> f) 
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 fix(UnaryPredicate<uint> f) 
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 fix(UnaryPredicate<long> f) 
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 fix(UnaryPredicate<ulong> f) 
            => a => f(a.Content);
 
        [MethodImpl(Inline), Op]
        public static BinaryPredicate1 fix(BinaryPredicate<bit> f) 
            => (a, b) => f(a, b);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 fix(BinaryPredicate<sbyte> f) 
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 fix(BinaryPredicate<byte> f) 
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 fix(BinaryPredicate<short> f) 
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 fix(BinaryPredicate<ushort> f) 
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 fix(BinaryPredicate<int> f) 
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 fix(BinaryPredicate<uint> f) 
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 fix(BinaryPredicate<long> f) 
            => (a, b) => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 fix(BinaryPredicate<ulong> f) 
            => (a, b) => f(a.Content, b.Content);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct BitLogic
    {
        [MethodImpl(Inline), Select]
        public static sbyte select(sbyte a, sbyte b, sbyte c)
            => (sbyte)select((int)a, (int)b, (int)c);

        [MethodImpl(Inline), Select]
        public static byte select(byte a, byte b, byte c)
            => (byte)select((uint)a, (uint)b, (uint)c);

        [MethodImpl(Inline), Select]
        public static short select(short a, short b, short c)
            => (short)select((int)a, (int)b, (int)c);

        [MethodImpl(Inline), Select]
        public static ushort select(ushort a, ushort b, ushort c)
            => (ushort)select((uint)a, (uint)b, (uint)c);

        [MethodImpl(Inline), Select]
        public static int select(int a, int b, int c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline), Select]
        public static uint select(uint a, uint b, uint c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline), Select]
        public static long select(long a, long b, long c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline), Select]
        public static ulong select(ulong a, ulong b, ulong c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline), Op]
        public static sbyte blend(sbyte a, sbyte b, sbyte mask)
            => xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline), Op]
        public static byte blend(byte a, byte b, byte mask)
            => xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline), Op]
        public static short blend(short a, short b, short mask)
            => xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline), Op]
        public static ushort blend(ushort a, ushort b, ushort mask)
            => xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline), Op]
        public static int blend(int a, int b, int mask)
            => xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline), Op]
        public static uint blend(uint a, uint b, uint mask)
            => xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline), Op]
        public static long blend(long a, long b, long mask)
            => xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline), Op]
        public static ulong blend(ulong a, ulong b,ulong mask)
            => xor(a, and(xor(a,b), mask));
    }
}
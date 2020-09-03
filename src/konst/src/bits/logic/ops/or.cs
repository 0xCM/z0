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
        /// <summary>
        /// Computes x := (a << asl) | (b << bsl)
        /// </summary>
        /// <param name="a">The first shift target</param>
        /// <param name="asl">The amount by which the first target is shifted</param>
        /// <param name="b">The second shift target</param>
        /// <param name="bsl">The amount by which the second target is shifted</param>
        [MethodImpl(Inline), Or]
        public static byte slor(byte a, byte asl, byte b, byte bsl)
            => or(sll(a,asl), sll(b, bsl));

        [MethodImpl(Inline), Or]
        public static sbyte or(sbyte a, sbyte b)
            => (sbyte)(a | b);

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b)
            => (byte)(a | b);

        [MethodImpl(Inline), Or]
        public static short or(short a, short b)
            => (short)(a | b);

        [MethodImpl(Inline), Or]
        public static ushort or(ushort a, ushort b)
            => (ushort)(a | b);

        [MethodImpl(Inline), Or]
        public static int or(int a, int b)
            => a | b;

        [MethodImpl(Inline), Or]
        public static uint or(uint a, uint b)
            => a | b;

        [MethodImpl(Inline), Or]
        public static long or(long a, long b)
            => a | b;

        [MethodImpl(Inline), Or]
        public static ulong or(ulong a, ulong b)
            => a | b;

        [MethodImpl(Inline), Or]
        public static sbyte or(sbyte a, sbyte b, sbyte c)
            => (sbyte)((int)a | (int)b | (int)c);

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c)
            => (byte)((uint)a | (uint)b | (uint)c);

        [MethodImpl(Inline), Or]
        public static short or(short a, short b, short c)
            => (short)((int)a | (int)b | (int)c);

        [MethodImpl(Inline), Or]
        public static ushort or(ushort a, ushort b, ushort c)
            => (ushort)((uint)a | (uint)b | (uint)c);

        [MethodImpl(Inline), Or]
        public static int or(int a, int b, int c)
            => a | b | c;

        [MethodImpl(Inline), Or]
        public static uint or(uint a, uint b, uint c)
            => a | b | c;

        [MethodImpl(Inline), Or]
        public static long or(long a, long b, long c)
            => a | b | c;

        [MethodImpl(Inline), Or]
        public static ulong or(ulong a, ulong b, ulong c)
            => a | b | c;

        [MethodImpl(Inline), Or]
        public static sbyte or(sbyte a, sbyte b, sbyte c, sbyte d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c, byte d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Or]
        public static short or(short a, short b, short c, short d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Or]
        public static ushort or(ushort a, ushort b, ushort c, ushort d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Or]
        public static int or(int a, int b, int c, int d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Or]
        public static uint or(uint a, uint b, uint c, uint d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Or]
        public static long or(long a, long b, long c, long d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Or]
        public static ulong or(ulong a, ulong b, ulong c, ulong d)
            => or(or(a,b), or(c,d));

        /// <summary>
        /// Computes the bitwise OR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> or(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => ConstPair.define(x.Left | y.Left, x.Right | y.Right);
    }
}
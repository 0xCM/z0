//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static sbyte or(sbyte a, sbyte b)
            => (sbyte)(a | b);

        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b)
            => (byte)(a | b);

        [MethodImpl(Inline), Or]
        public static byte or(ref byte a, byte b)
            => a = or(a,b);

        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static short or(short a, short b)
            => (short)(a | b);

        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static ushort or(ushort a, ushort b)
            => (ushort)(a | b);

        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static int or(int a, int b)
            => a | b;

        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static uint or(uint a, uint b)
            => a | b;

        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static long or(long a, long b)
            => a | b;

        /// <summary>
        /// Computes the bitwise or c := a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Or]
        public static ulong or(ulong a, ulong b)
            => a | b;

        [MethodImpl(Inline), Op]
        public static sbyte or(sbyte a, sbyte b, sbyte c)
            => (sbyte)((int)a | (int)b | (int)c);

        [MethodImpl(Inline), Op]
        public static byte or(byte a, byte b, byte c)
            => (byte)((uint)a | (uint)b | (uint)c);

        [MethodImpl(Inline), Op]
        public static short or(short a, short b, short c)
            => (short)((int)a | (int)b | (int)c);

        [MethodImpl(Inline), Op]
        public static ushort or(ushort a, ushort b, ushort c)
            => (ushort)((uint)a | (uint)b | (uint)c);

        [MethodImpl(Inline), Op]
        public static int or(int a, int b, int c)
            => a | b | c;

        [MethodImpl(Inline), Op]
        public static uint or(uint a, uint b, uint c)
            => a | b | c;

        [MethodImpl(Inline), Op]
        public static long or(long a, long b, long c)
            => a | b | c;

        [MethodImpl(Inline), Op]
        public static ulong or(ulong a, ulong b, ulong c)
            => a | b | c;

        [MethodImpl(Inline), Op]
        public static sbyte or(sbyte a, sbyte b, sbyte c, sbyte d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Op]
        public static byte or(byte a, byte b, byte c, byte d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Op]
        public static short or(short a, short b, short c, short d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Op]
        public static ushort or(ushort a, ushort b, ushort c, ushort d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Op]
        public static int or(int a, int b, int c, int d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Op]
        public static uint or(uint a, uint b, uint c, uint d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Op]
        public static long or(long a, long b, long c, long d)
            => or(or(a,b), or(c,d));

        [MethodImpl(Inline), Op]
        public static ulong or(ulong a, ulong b, ulong c, ulong d)
            => or(or(a,b), or(c,d));
    }
}
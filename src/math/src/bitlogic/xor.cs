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
        [MethodImpl(Inline), Xor]
        public static sbyte xor(sbyte a, sbyte b)
            => (sbyte)(a ^ b);

        [MethodImpl(Inline), Xor]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);

        [MethodImpl(Inline), Xor]
        public static short xor(short a, short b)
            => (short)(a ^ b);

        [MethodImpl(Inline), Xor]
        public static ushort xor(ushort a, ushort b)
            => (ushort)(a ^ b);

        [MethodImpl(Inline), Xor]
        public static int xor(int a, int b)
            => a ^ b;

        [MethodImpl(Inline), Xor]
        public static uint xor(uint a, uint b)
            => a ^ b;

        [MethodImpl(Inline), Xor]
        public static long xor(long a, long b)
            => a ^ b;

        [MethodImpl(Inline), Xor]
        public static ulong xor(ulong a, ulong b)
            => a ^ b;

        /// <summary>
        /// Computes the bitwise XOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> xor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => ConstPair.define(x.Left ^ y.Left, x.Right ^ y.Right);
    }
}
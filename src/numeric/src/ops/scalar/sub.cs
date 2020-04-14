//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Scalar
    {
        [MethodImpl(Inline)]
        public static sbyte sub(sbyte a, sbyte b)
            => (sbyte)(a - b);

        [MethodImpl(Inline)]
        public static byte sub(byte a, byte b)
            => (byte)(a - b);

        [MethodImpl(Inline)]
        public static short sub(short a, short b)
            => (short)(a - b);

        [MethodImpl(Inline)]
        public static ushort sub(ushort a, ushort b)
            => (ushort)(a - b);

        [MethodImpl(Inline)]
        public static int sub(int a, int b)
            => a - b;

        [MethodImpl(Inline)]
        public static uint sub(uint a, uint b)
            => a - b;

        [MethodImpl(Inline)]
        public static long sub(long a, long b)
            => a - b;

        [MethodImpl(Inline)]
        public static ulong sub(ulong a, ulong b)
            => a - b;          

        [MethodImpl(Inline)]
        public static float sub(float a, float b)
            => a - b;

        [MethodImpl(Inline)]
        public static double sub(double a, double b)
            => a - b;
    }
}
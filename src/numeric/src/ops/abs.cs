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
        public static sbyte abs(sbyte a)
            => (sbyte)(a + (a >> 7)^(a >> 7));         

        [MethodImpl(Inline)]
        public static short abs(short a)
            => (short)(a + (a >> 15)^(a >> 15));         

        [MethodImpl(Inline)]
        public static int abs(int a)
            => (a + (a >> 31)^(a >> 31));         

        [MethodImpl(Inline)]
        public static long abs(long a)
            => (a + (a >> 63)^(a >> 63));         

        [MethodImpl(Inline)]
        public static float abs(float a)
            => MathF.Abs(a);

        [MethodImpl(Inline)]
        public static double abs(double a)
            => Math.Abs(a);
    }
}
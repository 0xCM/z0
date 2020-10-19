//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static sbyte extract(sbyte src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static byte extract(byte src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static short extract(short src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static ushort extract(ushort src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static uint extract(uint src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static int extract(int src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static ulong extract(ulong src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static long extract(long src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static float extract(float src, byte k0, byte k1)
            => BitMasks.extract(src, k0, k1);

        [MethodImpl(Inline)]
        public static double extract(double src, byte k0, byte k1)
             => BitMasks.extract(src, k0, k1);
   }
}
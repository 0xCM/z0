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
        [MethodImpl(Inline), Op]
        public static sbyte negate(sbyte src)
            => (sbyte)(- src);

        [MethodImpl(Inline), Op]
        public static byte negate(byte src)
            => (byte)(~src + 1);

        [MethodImpl(Inline), Op]
        public static short negate(short src)
            => (short)(- src);

        [MethodImpl(Inline), Op]
        public static ushort negate(ushort src)
            => (ushort)(~src + 1);

        [MethodImpl(Inline), Op]
        public static int negate(int src)
            => -src;

        [MethodImpl(Inline), Op]
        public static uint negate(uint src)
            => ~src + 1;

        [MethodImpl(Inline), Op]
        public static long negate(long src)
            => -src;

        [MethodImpl(Inline), Op]
        public static ulong negate(ulong src)
            => ~src + 1;

        [MethodImpl(Inline), Op]
        public static float negate(float src)
            => -src;

        [MethodImpl(Inline), Op]
        public static double negate(double src)
            => -src;        
    }
}
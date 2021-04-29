//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public static partial class XCalc
    {
        [MethodImpl(Inline), Op]
        public static byte Sum(this ReadOnlySpan<byte> src)
            => Calcs.sum(src);

        [MethodImpl(Inline), Op]
        public static ushort Sum(this ReadOnlySpan<ushort> src)
            => Calcs.sum(src);

        [MethodImpl(Inline), Op]
        public static uint Sum(this ReadOnlySpan<uint> src)
            => Calcs.sum(src);

        [MethodImpl(Inline), Op]
        public static ulong Sum(this ReadOnlySpan<ulong> src)
            => Calcs.sum(src);

        [MethodImpl(Inline), Op]
        public static sbyte Sum(this ReadOnlySpan<sbyte> src)
            => Calcs.sum(src);

        [MethodImpl(Inline), Op]
        public static short Sum(this ReadOnlySpan<short> src)
            => Calcs.sum(src);

        [MethodImpl(Inline), Op]
        public static int Sum(this ReadOnlySpan<int> src)
            => Calcs.sum(src);

        [MethodImpl(Inline), Op]
        public static long Sum(this ReadOnlySpan<long> src)
            => Calcs.sum(src);

        [MethodImpl(Inline)]
        public static double Sum(this ReadOnlySpan<double> src)
            => Calcs.sum(src);

        [MethodImpl(Inline)]
        public static double Sum(this Span<double> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static float Avg(this Span<float> src)
            => Calcs.favg<float>(src);

        [MethodImpl(Inline)]
        public static double Avg(this Span<double> src)
            => Calcs.favg<double>(src);

        [MethodImpl(Inline)]
        public static float Avg(this ReadOnlySpan<float> src)
            => Calcs.favg(src);

        [MethodImpl(Inline)]
        public static double Avg(this ReadOnlySpan<double> src)
            => Calcs.favg(src);
    }
}
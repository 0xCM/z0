//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost("math.spans.extensions")]
    public static partial class MSpanX
    {
        [MethodImpl(Inline), Op]
        public static byte Sum(this ReadOnlySpan<byte> src)
            => gspan.sum(src);

        [MethodImpl(Inline), Op]
        public static ushort Sum(this ReadOnlySpan<ushort> src)
            => gspan.sum(src);

        [MethodImpl(Inline), Op]
        public static uint Sum(this ReadOnlySpan<uint> src)
            => gspan.sum(src);

        [MethodImpl(Inline), Op]
        public static ulong Sum(this ReadOnlySpan<ulong> src)
            => gspan.sum(src);

        [MethodImpl(Inline), Op]
        public static sbyte Sum(this ReadOnlySpan<sbyte> src)
            => gspan.sum(src);

        [MethodImpl(Inline), Op]
        public static short Sum(this ReadOnlySpan<short> src)
            => gspan.sum(src);

        [MethodImpl(Inline), Op]
        public static int Sum(this ReadOnlySpan<int> src)
            => gspan.sum(src);

        [MethodImpl(Inline), Op]
        public static long Sum(this ReadOnlySpan<long> src)
            => gspan.sum(src);

        [MethodImpl(Inline)]
        public static double Sum(this ReadOnlySpan<double> src)
            => gspan.sum(src);

        [MethodImpl(Inline)]
        public static double Sum(this Span<double> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static float Avg(this Span<float> src)
            => fspan.avg<float>(src);

        [MethodImpl(Inline)]
        public static double Avg(this Span<double> src)
            => fspan.avg<double>(src);

        [MethodImpl(Inline)]
        public static float Avg(this ReadOnlySpan<float> src)
            => fspan.avg(src);

        [MethodImpl(Inline)]
        public static double Avg(this ReadOnlySpan<double> src)
            => fspan.avg(src);
    }
}
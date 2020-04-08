//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;

    public static class XFSpan
    {
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
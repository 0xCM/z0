//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    
    partial class fpx
    {

        [MethodImpl(Inline)]
        public static float Round(this float src, int scale)
            => fmath.round(src, scale);

        [MethodImpl(Inline)]
        public static double Round(this double src, int scale)
            => fmath.round(src, scale);

        [MethodImpl(Inline)]
        public static float Truncate(this float src)
            => (int)src;

        [MethodImpl(Inline)]
        public static double Truncate(this double src)
            => (long)src;

        [MethodImpl(Inline)]
        public static int ToBits(this float src)
            => BitConvert.ToInt32(src);

        [MethodImpl(Inline)]
        public static long ToBits(this double src)
            => BitConvert.ToInt64(src);

        [MethodImpl(Inline)]
        public static double Sum(this ReadOnlySpan<double> src)
            => mathspan.sum(src);

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

        [MethodImpl(Inline)]
        public static float Avg(this Block256<float> src)
            => fspan.avg<float>(src);

        [MethodImpl(Inline)]
        public static double Avg(this Block256<double> src)
            => fspan.avg<double>(src);
            
    }
}
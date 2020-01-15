//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static As;
    using static zfunc;

    partial class MathX
    {
        [MethodImpl(Inline)]
        public static int ToBits(this float src)
            => BitConvert.ToInt32(src);

        [MethodImpl(Inline)]
        public static long ToBits(this double src)
            => BitConvert.ToInt64(src);

        [MethodImpl(Inline)]
        public static T Quotient<T>(this Ratio<T> r)        
            where T : unmanaged       
                => gmath.div(r.A, r.B);

        public static byte Sum(this ReadOnlySpan<byte> src)
            => mathspan.sum(src);

        public static sbyte Sum(this ReadOnlySpan<sbyte> src)
            => mathspan.sum(src);

        public static short Sum(this ReadOnlySpan<short> src)
            => mathspan.sum(src);

        public static ushort Sum(this ReadOnlySpan<ushort> src)
            => mathspan.sum(src);

        public static int Sum(this ReadOnlySpan<int> src)
            => mathspan.sum(src);

        public static uint Sum(this ReadOnlySpan<uint> src)
            => mathspan.sum(src);

        public static long Sum(this ReadOnlySpan<long> src)
            => mathspan.sum(src);

        public static ulong Sum(this ReadOnlySpan<ulong> src)
            => mathspan.sum(src);

        public static float Sum(this ReadOnlySpan<float> src)
            => mathspan.sum(src);

        public static double Sum(this ReadOnlySpan<double> src)
            => mathspan.sum(src);

        [MethodImpl(Inline)]
        public static byte Sum(this Span<byte> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static sbyte Sum(this Span<sbyte> src)
            => src.ReadOnly().Sum();
    
        [MethodImpl(Inline)]
        public static short Sum(this Span<short> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static ushort Sum(this Span<ushort> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static int Sum(this Span<int> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static uint Sum(this Span<uint> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static long Sum(this Span<long> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static ulong Sum(this Span<ulong> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static float Sum(this Span<float> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static double Sum(this Span<double> src)
            => src.ReadOnly().Sum();

 
        [MethodImpl(Inline)]
        public static sbyte Avg(this Span<sbyte> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static byte Avg(this Span<byte> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static short Avg(this Span<short> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static ushort Avg(this Span<ushort> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static int Avg(this Span<int> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static uint Avg(this Span<uint> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static long Avg(this Span<long> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static ulong Avg(this Span<ulong> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static float Avg(this Span<float> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static double Avg(this Span<double> src)
            => mathspan.avg(src);


        [MethodImpl(Inline)]
        public static sbyte Avg(this ReadOnlySpan<sbyte> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static byte Avg(this ReadOnlySpan<byte> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static short Avg(this ReadOnlySpan<short> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static ushort Avg(this ReadOnlySpan<ushort> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static int Avg(this ReadOnlySpan<int> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static uint Avg(this ReadOnlySpan<uint> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static long Avg(this ReadOnlySpan<long> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static ulong Avg(this ReadOnlySpan<ulong> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static float Avg(this ReadOnlySpan<float> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static double Avg(this ReadOnlySpan<double> src)
            => mathspan.avg(src);

        [MethodImpl(Inline)]
        public static float Avg(this Block256<float> src)
            => mathspan.avg<float>(src);

        [MethodImpl(Inline)]
        public static double Avg(this Block256<double> src)
            => mathspan.avg<double>(src);
 
         [MethodImpl(Inline)]
        public static sbyte Min(this ReadOnlySpan<sbyte> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static byte Min(this ReadOnlySpan<byte> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static short Min(this ReadOnlySpan<short> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static ushort Min(this ReadOnlySpan<ushort> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static int Min(this ReadOnlySpan<int> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static uint Min(this ReadOnlySpan<uint> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static long Min(this ReadOnlySpan<long> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static ulong Min(this ReadOnlySpan<ulong> src)
            => mathspan.min(src);

        [MethodImpl(Inline)]
        public static sbyte Min(this Span<sbyte> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static byte Min(this Span<byte> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static short Min(this Span<short> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static ushort Min(this Span<ushort> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static int Min(this Span<int> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static uint Min(this Span<uint> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static long Min(this Span<long> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static ulong Min(this Span<ulong> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static float Min(this Span<float> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static double Min(this Span<double> src)
            => mathspan.min(src.ReadOnly());

        [MethodImpl(Inline)]
        public static sbyte Max(this Span<sbyte> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static byte Max(this Span<byte> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static short Max(this Span<short> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ushort Max(this Span<ushort> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static int Max(this Span<int> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static uint Max(this Span<uint> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static long Max(this Span<long> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ulong Max(this Span<ulong> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static float Max(this Span<float> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static double Max(this Span<double> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static sbyte Max(this ReadOnlySpan<sbyte> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static byte Max(this ReadOnlySpan<byte> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static short Max(this ReadOnlySpan<short> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ushort Max(this ReadOnlySpan<ushort> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static int Max(this ReadOnlySpan<int> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static uint Max(this ReadOnlySpan<uint> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static long Max(this ReadOnlySpan<long> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ulong Max(this ReadOnlySpan<ulong> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static float Max(this ReadOnlySpan<float> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static double Max(this ReadOnlySpan<double> src)
            => mathspan.max(src);            
    }
}
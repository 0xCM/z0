//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    using static VslSSTaskParameter;
    using static VslSSComputeRoutine;
    using static VslSSComputeMethod;

    using Calcs = VslSSComputeRoutine;

    partial class VssOps
    {
        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<float> Mean(this Observations<float> src)        
            => src.CalcMean(Observations.Alloc<float>(src.Dim,1));

        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<double> Mean(this Observations<double> src)        
            => src.CalcMean(Observations.Alloc<double>(src.Dim,1));

        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<double> Variance(this Observations<double> src)        
            => src.CalcVariance(Observations.Alloc<double>(src.Dim,1));

        /// <summary>
        /// Calculates the mean
        /// </summary>
        [MethodImpl(Inline)]
        public static ref double Mean(this Observations<double> src, ref double dst)        
            => ref src.CalcMean(ref dst);

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<float> Sum(this Observations<float> src)        
            => src.CalcSum(Observations.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<double> Sum(this Observations<double> src)        
            => src.CalcSum(Observations.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<float> Min(this Observations<float> src)        
            => src.CalcMin(Observations.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<double> Min(this Observations<double> src)        
            => src.CalcMin(Observations.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<float> Max(this Observations<float> src)        
            => src.CalcMax(Observations.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<double> Max(this Observations<double> src)        
            => src.CalcMax(Observations.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<float> Extrema(this Observations<float> src)        
            => src.CalcExtrema(Observations.Alloc<float>(src.Dim,2));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Observations<double> Extrema(this Observations<double> src)        
            => src.CalcExtrema(Observations.Alloc<double>(src.Dim,2));

        static unsafe Observations<T> CalcMin<T>(this Observations<T> samples, Observations<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Observations<T> CalcMax<T>(this Observations<T> samples, Observations<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MAX, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_MAX, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Observations<T> CalcSum<T>(this Observations<T> samples, Observations<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_SUM, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_SUM, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Observations<T> CalcExtrema<T>(this Observations<T> samples, Observations<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Set(VSL_SS_ED_MAX, ref dst[1]);
            h2.Compute(Calcs.VSL_SS_MAX | Calcs.VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }


        static unsafe ref T CalcMean<T>(this Observations<T> samples, ref T dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MEAN, ref dst);
            h2.Compute(Calcs.VSL_SS_MEAN, VSL_SS_METHOD_FAST);
            return ref dst;
        }

        static unsafe Observations<T> CalcMean<T>(this Observations<T> samples, Observations<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MEAN, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_MEAN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Observations<T> CalcVariance<T>(this Observations<T> samples, Observations<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_2R_MOM, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_2R_MOM, VSL_SS_METHOD_FAST);
            return dst;
        }
    }
}
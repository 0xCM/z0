//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// A basic statistical accumulator that accrues information over an arbitrary number of input sequences
    /// </summary>
    [ApiType]
    public class Collector
    {
        int count;

        double min;

        double max;

        double m0;

        double m1;

        double s0;

        double s1;

        /// <summary>
        /// Creates a collector seeded with the first value
        /// </summary>
        [MethodImpl(Inline)]
        public static Collector Create<T>(T seed = default)
            where T : unmanaged
                => new Collector(Numeric.force<T,double>(seed));

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, byte value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<byte> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, byte[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<byte> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, short value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<short> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, short[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<short> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<short> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ushort value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<ushort> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ushort[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<ushort> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<ushort> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, int value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<int> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, int[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<int> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<int> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, uint value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<uint> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, uint[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<uint> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<uint> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, long value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<long> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, long[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<long> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<long> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ulong value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<ulong> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ulong[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<ulong> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<ulong> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, float value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<float> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, float[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<float> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<float> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, double value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<double> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, double[] value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<double> value)
        {
            a.Collect(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<double> value)
        {
            a.Collect(value);
            return a;
        }

        /// <summary>
        /// The number of accumulated observations
        /// </summary>
        public int Count
        {
            [MethodImpl(Inline)]
            get => count;
        }

        /// <summary>
        /// The accumulated mean
        /// </summary>
        public double Mean
        {
            [MethodImpl(Inline)]
            get => m1;
        }

        /// <summary>
        /// The accumulated variance
        /// </summary>
        public double Variance
        {
            [MethodImpl(Inline)]
            get => count > 1 ? s0/(count - 1) : 0;
        }

        /// <summary>
        /// The accumulated standard deviation
        /// </summary>
        public double Stdev
        {
            [MethodImpl(Inline)]
            get => fmath.sqrt(Variance);
        }

        /// <summary>
        /// The accumulated minimum
        /// </summary>
        public double Min
            => min;

        /// <summary>
        /// The accumulated maximum
        /// </summary>
        public double Max
            => max;

        /// <summary>
        /// Accumulates a single value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Closures(AllNumeric)]
        public void Collect<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                Collect_u(src);
            else if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                Collect_i(src);
            else
                Collect_f(src);
        }

        /// <summary>
        /// Accumulates a stream of values
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public void Collect<T>(IEnumerable<T> src)
            where T : unmanaged
        {
            //Collect(src.ToSpan());
            foreach(var cell in src)
                Collect(cell);
        }

        /// <summary>
        /// Accumulates a span of values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public void CollectItems<T>(params T[] src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return;

            ref readonly var data = ref memory.first(src);
            for(var i=0u; i<count; i++)
                Collect(skip(in data, i));
        }

        /// <summary>
        /// Accumulates a span of values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public void Collect<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            ref readonly var cells = ref first(src);
            for(var i=0u; i<count; i++)
                Collect(skip(cells, i));
        }

        /// <summary>
        /// Accumulates a span of values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public void Collect<T>(Span<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            ref readonly var cells = ref first(src);
            for(var i=0u; i<count; i++)
                Collect(skip(cells, i));
        }

        [MethodImpl(Inline)]
        Collector(double seed)
        {
            s1 = 0;
            s0 = 0;
            m1 = seed;
            m0 = seed;
            count = 0;
            min = double.MaxValue;
            max = double.MinValue;
        }


        [MethodImpl(Inline)]
        void Merge(double value)
        {
            ++count;

            var delta = value - m0;
            m1 = m0 + delta/count;
            s1 = s0 + delta*(value - m1);
            m0 = m1;
            s0 = s1;

            if(value > max)
                max = value;

            if(value < min)
                min = value;
        }

        public string Format(int? scale = null)
            => $"observations = {count} | min = {min} | max = {max} | mean={Mean.Round(scale ?? 4)} | stdev={Stdev.Round(scale ?? 4)}";

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        void Collect_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Merge(int8(src));
            else if(typeof(T) == typeof(short))
                Merge(int16(src));
            else if(typeof(T) == typeof(int))
                Merge(int32(src));
            else
                Merge(int64(src));
        }

        [MethodImpl(Inline)]
        void Collect_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Merge(uint8(src));
            else if(typeof(T) == typeof(ushort))
                Merge(uint16(src));
            else if(typeof(T) == typeof(uint))
                Merge(uint32(src));
            else
                Merge(uint64(src));
        }

        [MethodImpl(Inline)]
        void Collect_f<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Merge(float32(src));
            else if(typeof(T) == typeof(double))
                Merge(float64(src));
            else
                throw no<T>();
        }
    }
}
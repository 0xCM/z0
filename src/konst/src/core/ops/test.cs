//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct z
    {
        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(sbyte src, byte pos)
            => (Bit)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(byte src, byte pos)
            => (Bit)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(short src, byte pos)
            => (Bit)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(ushort src, byte pos)
            => (Bit)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(int src, byte pos)
            => (Bit)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(uint src, byte pos)
            => (Bit)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(long src, byte pos)
            => (Bit)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static Bit test(ulong src, byte pos)
            => (Bit)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static unsafe Bit test(float src, byte pos)
            => test(As<float,uint>(ref AsRef<float>(&src)),pos);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static unsafe Bit test(double src, byte pos)
            => test(As<double,ulong>(ref AsRef<double>(&src)),pos);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static unsafe Bit test(decimal src, byte pos)
        {
            ref var lo = ref As<decimal,ulong>(ref Unsafe.AsRef<decimal>(&src));
            ref var hi = ref Add(ref lo, 1);
            return pos < 64 ? test(lo,pos) : test(hi,pos);
        }
    }
}
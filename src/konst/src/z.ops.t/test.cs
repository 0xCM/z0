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
        public static BitState test(sbyte src, byte pos)
            => (BitState)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static BitState test(byte src, byte pos)
            => (BitState)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static BitState test(short src, byte pos)
            => (BitState)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static BitState test(ushort src, byte pos)
            => (BitState)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static BitState test(int src, byte pos)
            => (BitState)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static BitState test(uint src, byte pos)
            => (BitState)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static BitState test(long src, byte pos)
            => (BitState)((unsign(src) >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static BitState test(ulong src, byte pos)
            => (BitState)((src >> pos) & 1);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static unsafe BitState test(float src, byte pos)
            => test(As<float,uint>(ref AsRef<float>(&src)),pos);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static unsafe BitState test(double src, byte pos)
            => test(As<double,ulong>(ref AsRef<double>(&src)),pos);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static unsafe BitState test(decimal src, byte pos)
        {
            ref var lo = ref As<decimal,ulong>(ref Unsafe.AsRef<decimal>(&src));
            ref var hi = ref Add(ref lo, 1);
            return pos < 64 ? test(lo,pos) : test(hi,pos);
        }
    }
}
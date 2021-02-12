//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Part;

    partial struct bit
    {
        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(sbyte src, byte pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(byte src, byte pos)
            => new bit(((uint)src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(short src, byte pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(ushort src, byte pos)
            => new bit(((uint)src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(int src, byte pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(long src, byte pos)
            => new bit((src & (1L << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(uint src, byte pos)
            => new bit((src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static bit test(ulong src, byte pos)
            => new bit((uint)((src >> pos) & 1));

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static unsafe bit test(float src, byte pos)
            => test(As<float,uint>(ref AsRef<float>(&src)),pos);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static unsafe bit test(double src, byte pos)
            => test(As<double,ulong>(ref AsRef<double>(&src)),pos);

        /// <summary>
        /// Determines the state of an index-identified bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), TestBit]
        public static unsafe bit test(decimal src, byte pos)
        {
            ref var lo = ref As<decimal,ulong>(ref Unsafe.AsRef<decimal>(&src));
            ref var hi = ref Add(ref lo, 1);
            return pos < 64 ? test(lo,pos) : test(hi,pos);
        }
    }
}
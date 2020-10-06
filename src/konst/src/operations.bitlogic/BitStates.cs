//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public partial struct BitStates
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
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static sbyte set(sbyte src, byte pos, bit state)
        {
            var c = ~(sbyte)state + 1;
            src ^= (sbyte)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static byte set(byte src, byte pos, bit state)
        {
            var c = ~(byte)state + 1;
            src ^= (byte)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static short set(short src, byte pos, bit state)
        {
            var c = ~(short)state + 1;
            src ^= (short)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static ushort set(ushort src, byte pos, bit state)
        {
            var c = ~(ushort)state + 1;
            src ^= (ushort)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static int set(int src, byte pos, bit state)
        {
            var c = ~(int)state + 1;
            src ^= (c ^ src) & (1 << pos);
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static uint set(uint src, byte pos, bit state)
        {
            var c = ~(uint)state + 1u;
            src ^= (c ^ src) & (1u << pos);
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static long set(long src, byte pos, bit state)
        {
            var c = ~(long)state + 1L;
            src ^= (c ^ src) & (1L << pos);
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline), SetBit]
        public static ulong set(ulong src, byte pos, bit state)
        {
            var c = ~(ulong)state + 1ul;
            src ^= (c ^ src) & (1ul << pos);
            return src;
        }
    }
}
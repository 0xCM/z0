//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    [ApiHost]
    public struct BitStates
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Converts a <see cref='bool' /> to a <see cref='BitState' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe BitState bitstate(bool src)
            => (BitState)@byte(src);

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

        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<BitState> dst)
            => unpack(src, ref first(dst));

        [MethodImpl(Inline), Op]
        public static ulong unpack(byte src)
        {
            var storage = 0ul;
            ref var dst = ref @as<ulong,BitState>(storage);
            seek(dst, 0) = test(skip(src, 0), 0);
            seek(dst, 1) = test(skip(src, 1), 1);
            seek(dst, 2) = test(skip(src, 2), 2);
            seek(dst, 3) = test(skip(src, 3), 3);
            seek(dst, 4) = test(skip(src, 4), 4);
            seek(dst, 5) = test(skip(src, 5), 5);
            seek(dst, 6) = test(skip(src, 6), 6);
            seek(dst, 7) = test(skip(src, 7), 7);
            return storage;
        }

        /// <summary>
        /// Populates a caller-supplied target with unpacked source bits
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The data source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void unpack<T>(T src, Span<BitState> dst)
            where T : struct
        {
            var count = size<T>();
            var data = bytes(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var u8 = ref skip(data,i);
                for(byte j=0; j<8; j++)
                    seek(dst, i+j) = test(u8,j);
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BitState unpack<T>(in T src, ref BitState dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var input = ref @as<T,byte>(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var u8 = ref skip(input,i);
                for(byte j=0; j<8; j++)
                    seek(dst, i+j) = test(u8,j);
            }
            return ref dst;
        }

        public static IEnumerable<BitState> enumerate<T>(T src)
            where T : struct
        {
            var size = size<T>();
            var buffer = sys.alloc<BitState>(size*8);
            fill(src, buffer);
            foreach(var bit in buffer)
                yield return bit;
        }

        [Op, Closures(Closure)]
        public static void fill<T>(in T src, Span<BitState> dst)
            where T : struct
        {
            var size = size<T>();
            var count = corefunc.min(size, dst.Length);
            if(count == 0)
                return;

            ref var input = ref @as<T,byte>(src);
            ref var output = ref @as<BitState,ulong>(first(dst));
            for(var i=0u; i<size; i++)
                seek(output, i) = unpack(skip(input,i));
        }
    }
}
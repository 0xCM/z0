//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static core;

    partial struct gpack
    {
        [Unpack, Closures(Closure)]
        public static Span<bit> unpack<T>(T src)
            where T : unmanaged
        {
            var count = width<T>(w8);
            var dst = span<bit>(count);
            for(byte i=0; i<count; i++)
                seek(dst,i) = BitMasks.testbit(src,i);
            return dst;
        }

        [Unpack, Closures(Closure)]
        public static void unpack<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
        {
            var kCell = src.Length;
            var wCell = width<T>(w8);
            var bitcount = width<T>()*kCell;
            ref var target = ref first(dst);
            var k = 0;
            for(var i=0; i<kCell; i++)
            for(byte j=0; j<wCell; j++, k++)
                seek(target, k) = BitMasks.testbit(skip(src,i), j);
        }

        /// <summary>
        /// Projects each source bit from each source element into an element of the target span at the corresponding index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> unpack<S,T>(ReadOnlySpan<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(bit))
            {
                var target = recover<T,bit>(dst);
                unpack(src, target);
                return recover<bit,T>(target);
            }
            else
            {
                var wCell = width<S>(w32);
                var cells = (uint)src.Length;
                var wSource = wCell*(uint)cells;
                var k = 0u;
                for(var i=0; i<cells; i++)
                for(byte j=0; j<wCell; j++)
                    seek(dst, k++) = BitMasks.testbit(skip(src,i), j) == bit.On ? NumericLiterals.one<T>() : NumericLiterals.zero<T>();
                return dst;
            }
        }

        /// <summary>
        /// Extracts each bit from each source element into caller-supplied target at the corresponding index
        /// </summary>
        /// <param name="src">The source values to be unpacked</param>
        /// <param name="dst">The target array of length at least bitsize[T]*length(Span[T])</param>
        /// <typeparam name="T">The source value type</typeparam>
        [Unpack, Closures(Closure)]
        public static void unpack<T>(Span<T> src, bit[] dst)
            where T : unmanaged
        {
            unpack(src.ReadOnly(), dst);
        }

        [Unpack, Closures(Closure)]
        public static Span<bit> unpack<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var dst = alloc<bit>(width<T>()*src.Length);
            unpack(src, dst);
            return dst;
        }

        /// <summary>
        /// Projects each bit from a source value into target span element at the corresponding index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> unpack<S,T>(S src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            var count = root.min(width<S>(), dst.Length);
            for(var i=0u; i<count; i++)
                seek(dst, i) = BitMasks.testbit(src, (byte)i) == bit.On ? NumericLiterals.one<T>() : NumericLiterals.zero<T>();
            return dst;
        }

        public static Span<T> unpack<S,T>(Span<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
                => unpack(src.ReadOnly(), dst);
    }
}
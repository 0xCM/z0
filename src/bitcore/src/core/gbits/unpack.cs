//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class gbits
    {
        public static Span<bit> unpack<T>(T src)
            where T : unmanaged
        {
            var count = bitwidth<T>();
            var dst = span<bit>(count);
            for(byte i=0; i<count; i++)
                seek(dst,i) = testbit(src,i);
            return dst;
        }

        [MethodImpl(Inline), Unpack, Closures(Closure)]
        public static Span<bit> unpack<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
        {
            var wCell = bitsize<T>();
            var bitcount = bitsize<T>()*src.Length;
            ref var target = ref first(dst);
            var k = 0;
            for(var i=0; i <src.Length; i++)
            for(byte j=0; j<wCell; j++, k++)
                seek(target, k) = testbit(skip(src,i), j);
            return dst;
        }

        /// <summary>
        /// Projects each source bit from each source element into an element of the target span at the corresponding index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> unpack<S,T>(ReadOnlySpan<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(bit))
                return memory.recover<bit,T>(unpack(src, memory.recover<T,bit>(dst)));
            else
            {
                var wCell = bitwidth<S>();
                var cells = (uint)src.Length;
                var wSource = wCell*(uint)cells;
                var k = 0u;
                for(var i=0; i<cells; i++)
                for(byte j=0; j<wCell; j++)
                    seek(dst, k++)  = testbit(skip(src,i), j) == bit.On ? one<T>() : zero<T>();
                return dst;
            }
        }

        /// <summary>
        /// Extracts each bit from each source element into caller-supplied target at the corresponding index
        /// </summary>
        /// <param name="src">The source values to be unpacked</param>
        /// <param name="dst">The target array of length at least bitsize[T]*length(Span[T])</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Unpack, Closures(Closure)]
        public static Span<bit> unpack<T>(Span<T> src, bit[] dst)
            where T : unmanaged
                => unpack(src.ReadOnly(), dst.AsSpan());

        /// <summary>
        /// Projects each bit from a source value into target span element at the corresponding index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> unpack<S,T>(S src, Span<T> dst, uint offset = 0)
            where S : unmanaged
            where T : unmanaged
        {
            var len = bitsize<S>();
            for(var i=0u; i<len; i++)
                seek(dst,offset + i)  = testbit(src, (byte)i) == bit.On ? one<T>() : zero<T>();
            return dst;
        }

        public static Span<bit> unpack<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => unpack(src, alloc<bit>(bitsize<T>()*src.Length));

        public static Span<T> unpack<S,T>(Span<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
                => unpack(src.ReadOnly(), dst);
    }
}
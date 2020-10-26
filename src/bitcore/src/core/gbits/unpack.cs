//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    partial class gbits
    {
        [MethodImpl(Inline), Unpack, Closures(UnsignedInts)]
        public static Span<Bit32> unpack<T>(ReadOnlySpan<T> src, Span<Bit32> dst)
            where T : unmanaged
        {
            var srcsize = bitsize<T>();
            var bitcount = bitsize<T>()*src.Length;
            ref var target = ref first(dst);
            var k = 0;
            for(var i=0; i < src.Length; i++)
            for(byte j=0; j < srcsize; j++, k++)
                seek(target, k) = testbit32(skip(src,i), j);
            return dst;
        }

        /// <summary>
        /// Extracts each bit from each source element into caller-supplied target at the corresponding index
        /// </summary>
        /// <param name="src">The source values to be unpacked</param>
        /// <param name="dst">The target span of length at least bitsize[T]*length(Span[T])</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Unpack, Closures(UnsignedInts)]
        public static Span<Bit32> unpack<T>(Span<T> src, Span<Bit32> dst)
            where T : unmanaged
                => unpack(src.ReadOnly(),dst);

        /// <summary>
        /// Extracts each bit from each source element into caller-supplied target at the corresponding index
        /// </summary>
        /// <param name="src">The source values to be unpacked</param>
        /// <param name="dst">The target array of length at least bitsize[T]*length(Span[T])</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Unpack, Closures(UnsignedInts)]
        public static Span<Bit32> unpack<T>(Span<T> src, Bit32[] dst)
            where T : unmanaged
                => unpack(src, dst.AsSpan());

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
            for(var i=0u; i< len; i++)
                seek(dst,offset + i)  = testbit32(src, (byte)i) == Bit32.On ? one<T>() : zero<T>();
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
            if(typeof(T) == typeof(Bit32))
                return MemoryMarshal.Cast<Bit32,T>(unpack(src, MemoryMarshal.Cast<T,Bit32>(dst)));
            else
            {
                var srcsize = bitsize<S>();
                var bitcount = bitsize<S>()*src.Length;
                var k = 0u;
                for(var i=0; i < src.Length; i++)
                for(byte j=0; j < srcsize; j++)
                    seek(dst,k++)  = testbit32(skip(src,i), j) == Bit32.On ? one<T>() : zero<T>();
                return dst;
            }
        }

        [MethodImpl(Inline)]
        public static Span<T> unpack<S,T>(Span<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
                => unpack(src.ReadOnly(), dst);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;
    using static Memories;

    partial class gbits
    {
        [MethodImpl(Inline), Unpack, Closures(UnsignedInts)]
        public static Span<bit> unpack<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
        {
            var srcsize = bitsize<T>();
            var bitcount = bitsize<T>()*src.Length;
            insist(dst.Length >= bitcount);            
            
            ref var target = ref head(dst);
            var k = 0;
            for(var i=0; i < src.Length; i++)
            for(byte j=0; j < srcsize; j++, k++)
                seek(ref target, k) = testbit(skip(src,i), j);
            return dst;
        }

        /// <summary>
        /// Extracts each bit from each source element into caller-supplied target at the corresponding index
        /// </summary>
        /// <param name="src">The source values to be unpacked</param>
        /// <param name="dst">The target span of length at least bitsize[T]*length(Span[T])</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Unpack, Closures(UnsignedInts)]
        public static Span<bit> unpack<T>(Span<T> src, Span<bit> dst)
            where T : unmanaged
                => unpack(src.ReadOnly(),dst);


        /// <summary>
        /// Extracts each bit from each source element into caller-supplied target at the corresponding index
        /// </summary>
        /// <param name="src">The source values to be unpacked</param>
        /// <param name="dst">The target array of length at least bitsize[T]*length(Span[T])</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Unpack, Closures(UnsignedInts)]
        public static Span<bit> unpack<T>(Span<T> src, bit[] dst)
            where T : unmanaged
                => unpack(src, dst.AsSpan());
        // {
        //     var srcsize = bitsize<T>();
        //     var bitcount = bitsize<T>()*src.Length;
        //     require(dst.Length >= bitcount);

        //     ref var target = ref refs.head(dst);
        //     var k = 0;
        //     for(var i=0; i < src.Length; i++)
        //     for(byte j=0; j< srcsize; j++, k++)
        //         seek(ref target, k) = testbit(src[i], j);
        //     return dst;
        // }

        /// <summary>
        /// Projects each bit from a source value into target span element at the corresponding index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> unpack<S,T>(S src, Span<T> dst, int offset = 0)
            where S : unmanaged
            where T : unmanaged
        {
            var len = bitsize<S>();
            insist(dst.Length - offset >= len);
            for(var i=0; i< len; i++)
                seek(dst,offset + i)  = testbit(src, (byte)i) == bit.On ? one<T>() : zero<T>();            
            return dst;
        }

        /// <summary>
        /// Projects each source bit from each source element into an element of the target span at the corresponding index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> unpack<S,T>(ReadOnlySpan<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(bit))
                return MemoryMarshal.Cast<bit,T>(unpack(src, MemoryMarshal.Cast<T,bit>(dst)));
            else
            {
                var srcsize = bitsize<S>();
                var bitcount = bitsize<S>()*src.Length;
                insist(dst.Length >= bitcount);

                var k = 0;
                for(var i=0; i < src.Length; i++)
                for(byte j=0; j < srcsize; j++)
                    seek(dst,k++)  = testbit(skip(src,i), j) == bit.On ? one<T>() : zero<T>();            
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
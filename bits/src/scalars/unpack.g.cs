//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Projects each source bit into an element of the target span at the corresponding position
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> unpack<S,T>(S src, Span<T> dst, int offset = 0)
            where S : unmanaged
            where T : unmanaged
        {
            var len = bitsize<S>();
            require(dst.Length - offset >= len);
            for(var i=0; i< len; i++)
                dst[offset + i]  = test(src, i) == Bit.On ? one<T>() : zero<T>();            
            return dst;
        }

        /// <summary>
        /// Projects each source bit from each source element into an element of the target span 
        /// at the corresponding position
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> unpack<S,T>(Span<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(bit))
                return MemoryMarshal.Cast<bit,T>(unpack(src, MemoryMarshal.Cast<T,bit>(dst)));
            else
            {
                var srcsize = bitsize<S>();
                var bitcount = bitsize<S>()*src.Length;
                require(dst.Length >= bitcount);

                var k = 0;
                for(var i=0; i< src.Length; i++)
                for(var j=0; j< srcsize; j++)
                    dst[k++]  = test(src[i], j) == Bit.On ? one<T>() : zero<T>();            
                return dst;
            }
        }

        public static Span<bit> unpack<T>(Span<T> src, Span<bit> dst)
            where T : unmanaged
        {
            var srcsize = bitsize<T>();
            var bitcount = bitsize<T>()*src.Length;
            require(dst.Length >= bitcount);

            var k = 0;
            for(var i=0; i< src.Length; i++)
            for(var j=0; j< srcsize; j++)
                dst[k++]  = test(src[i], j);
            return dst;
        }
    }

}
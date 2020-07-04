//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    partial struct xHex
    {
        /// <summary>
        /// Creates an index that correlates 8-bit unsigned integers [0..255] with aribitrary parametric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static HexLookup<K,T> lookup<K,T>(params HexLookupEntry<K,T>[] src)
            where T : struct
            where K : unmanaged, Enum
        {
            var buffer = sys.alloc<T>(255);
            var input = @readonly(src);
            var len = min(buffer.Length, src.Length);
            var dst = span(buffer);
            for(var i=0; i<len; i++)
            {
                ref readonly var item = ref skip(input,i);
                seek(dst, EnumValue.e8u(item.Key)) = item.Value;
            }
            return new HexLookup<K,T>(buffer);
        }

        [MethodImpl(Inline)]
        public static HexLookup<K,T> lookup<K,T>(Func<T,K> f, T[] src, T[] dst)
            where T : struct
            where K : unmanaged, Enum
        {
            Span<T> index = dst;
            ReadOnlySpan<T> view = src;
            var count = min(src.Length, dst.Length);

            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(view,i);
                seek(index, EnumValue.e8u(f(x))) = x;
            }
            
            return new HexLookup<K,T>(dst);
        }                

        /// <summary>
        /// Creates an index that correlates up to 255 unsigned 8-bit integers with aribitrary structural T-parameteric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static HexLookup<K,T> lookup<K,T>(HexLookupEntry<K,T>[] src, T[] dst)
            where T : struct
            where K : unmanaged, Enum
        {
            Span<T> index = dst;
            ReadOnlySpan<HexLookupEntry<K,T>> view = src;
            var count = min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(index, EnumValue.e8u(skip(view,i).Key)) = skip(view,i).Value;
            return new HexLookup<K,T>(dst);
        }
    }
}
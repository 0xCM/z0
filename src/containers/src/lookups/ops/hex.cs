//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Lookups
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HexLookup<Hex5Seq,T> hex<T>(N5 n, HexLookupEntry<Hex5Seq,T>[] src)
            where T : struct
                => hex<Hex5Seq,T>(src, alloc<T>(32));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HexLookup<Hex8Seq,T> hex<T>(N8 n, HexLookupEntry<Hex8Seq,T>[] src)
            where T : struct
                => hex<Hex8Seq,T>(src, alloc<T>(256));

        [MethodImpl(Inline)]
        public static HexLookup<K,T> hex<K,T>(Func<T,K> f, T[] src, T[] dst)
            where T : struct
            where K : unmanaged
        {
            Span<T> index = dst;
            ReadOnlySpan<T> view = src;
            var count = min(src.Length, dst.Length);

            for(var i=0u; i<count; i++)
            {
                ref readonly var x = ref skip(view,i);
                seek(index, uint8(f(x))) = x;
            }

            return new HexLookup<K,T>(dst);
        }

        /// <summary>
        /// Creates an index that correlates 8-bit unsigned integers [0..255] with arbitrary parametric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static HexLookup<K,T> hex<K,T>(HexLookupEntry<K,T>[] src)
            where T : struct
            where K : unmanaged
        {
            var input = @readonly(src);
            var buffer = alloc<T>(src.Length);
            var dst = span(buffer);
            var count = buffer.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var item = ref skip(input,i);
                seek(dst, uint8(item.Key)) = item.Value;
            }
            return new HexLookup<K,T>(buffer);
        }

        /// <summary>
        /// Creates an index that correlates up to 255 unsigned 8-bit integers with arbitrary structural T-parameteric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        static HexLookup<K,T> hex<K,T>(HexLookupEntry<K,T>[] src, T[] dst)
            where T : struct
            where K : unmanaged, Enum
        {
            Span<T> index = dst;
            var input = @readonly(src);
            var count = min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(index, uint8(skip(input,i).Key)) = skip(input,i).Value;
            return new HexLookup<K,T>(dst);
        }
    }
}
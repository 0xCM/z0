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

    public readonly struct HexLookup
    {
        /// <summary>
        /// Partitions a bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        public static HexIndex<Hex1>[] partition(HexIndex<Hex1> data, int width)
        {
            var minCount = Math.DivRem(data.Length, width, out int remainder);
            var count = remainder != 0 ? minCount + 1 : minCount;
            var src = data.Span;
            var dst = sys.alloc<HexIndex<Hex1>>(count);
            Span<HexIndex<Hex1>> target = dst;
            var last = dst.Length - 1;
            for(uint i=0, offset = 0; i< dst.Length; i++, offset += (uint)width)
            {
                if(i == last && remainder != 0)
                {
                    var fullBlockBuffer = sys.alloc<Hex1>(width);
                    Span<Hex1> fullBlock = fullBlockBuffer;
                    var seg = z.slice(src, (int)offset, remainder);
                    seg.CopyTo(fullBlock);
                    seek(target, i) = new HexIndex<Hex1>(fullBlockBuffer);
                }
                else
                {
                    var seg = slice(src, offset, (uint)width);
                    seek(target, i) = new HexIndex<Hex1>(seg.ToArray());
                }
            }
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexLookup<Hex5Kind,T> define<T>(N5 n, HexLookupEntry<Hex5Kind,T>[] src)
            where T : struct
                => define<Hex5Kind,T>(src, sys.alloc<T>(32));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexLookup<Hex8Kind,T> define<T>(N8 n, HexLookupEntry<Hex8Kind,T>[] src)
            where T : struct
                => define<Hex8Kind,T>(src, sys.alloc<T>(256));

        /// <summary>
        /// Creates an index that correlates up to 255 unsigned 8-bit integers with arbitrary structural T-parameteric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        static HexLookup<K,T> define<K,T>(HexLookupEntry<K,T>[] src, T[] dst)
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

        /// <summary>
        /// Creates an index that correlates 8-bit unsigned integers [0..255] with arbitrary parametric values
        /// </summary>
        /// <param name="src">The values to correlate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static HexLookup<K,T> define<K,T>(HexLookupEntry<K,T>[] src)
            where T : struct
            where K : unmanaged, Enum
        {
            var input = @readonly(src);
            var buffer = sys.alloc<T>(src.Length);
            var dst = span(buffer);
            var count = buffer.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var item = ref skip(input,i);
                seek(dst, uint8(item.Key)) = item.Value;
            }
            return new HexLookup<K,T>(buffer);
        }

        [MethodImpl(Inline)]
        public static HexLookup<K,T> define<K,T>(Func<T,K> f, T[] src, T[] dst)
            where T : struct
            where K : unmanaged, Enum
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
    }
}
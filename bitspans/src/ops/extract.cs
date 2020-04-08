//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
 
    partial struct BitSpan
    {
        /// <summary>
        /// Extracts a scalar value from a bitspan
        /// </summary>
        /// <param name="src">The bitspan source</param>
        /// <param name="offset">The source index to begin extraction</param>
        /// <param name="count">The number of source bits that contribute to the extract</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T extract<T>(in BitSpan src, int offset = 0)
            where T : unmanaged
                => extract_u<T>(src,offset);

        [MethodImpl(Inline)]
        static T extract_u<T>(in BitSpan src, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(extract(src, n8, offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(extract(src, n16, offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(extract(src, n32, offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(extract(src, n64, offset));
            else
                return extract_i<T>(src,offset);
        }

        [MethodImpl(Inline)]
        static T extract_i<T>(in BitSpan src, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(extract(src, n8, offset));
            else if(typeof(T) == typeof(short))
                return convert<T>(extract(src, n16, offset));
            else if(typeof(T) == typeof(int))
                return convert<T>(extract(src, n32, offset));
            else if(typeof(T) == typeof(long))
                return convert<T>(extract(src, n64, offset));
            else
                throw Unsupported.define<T>();            
        }

        [MethodImpl(Inline)]
        static byte extract(in BitSpan src, N8 n, int offset)
        {
            var v0 = Vectors.vload(n256, head(extract(src, offset, bitsize<byte>())));
            return (byte)BitPack.packlsb8(dvec.vcompact(v0,n128,z8));
        }

        [MethodImpl(Inline)]
        static ushort extract(in BitSpan src, N16 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ushort>())); 
            return BitPack.pack32(unpacked, n);
        }

        [MethodImpl(Inline)]
        static uint extract(in BitSpan src, N32 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<uint>()));            
            return BitPack.pack32(unpacked,n);            
        }

        [MethodImpl(Inline)]
        static ulong extract(in BitSpan src, N64 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ulong>()));
            return BitPack.pack32(unpacked,n);
        }

        [MethodImpl(Inline)]
        static Span<uint> extract(in BitSpan src, int offset, int count)
           => src.Bits.Slice(offset, count).As<bit,uint>();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
 
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
        public static T scalar<T>(in BitSpan src, int offset = 0)
            where T : unmanaged
                => scalar_u<T>(src,offset);

        [MethodImpl(Inline)]
        static T scalar_u<T>(in BitSpan src, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(scalar(src, n8, offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(scalar(src, n16, offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(scalar(src, n32, offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(scalar(src, n64, offset));
            else
                return scalar_i<T>(src,offset);
        }

        [MethodImpl(Inline)]
        static T scalar_i<T>(in BitSpan src, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(scalar(src, n8, offset));
            else if(typeof(T) == typeof(short))
                return convert<T>(scalar(src, n16, offset));
            else if(typeof(T) == typeof(int))
                return convert<T>(scalar(src, n32, offset));
            else if(typeof(T) == typeof(long))
                return convert<T>(scalar(src, n64, offset));
            else
                throw unsupported<T>();            
        }

        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static byte scalar(in BitSpan src, N8 n, int offset)
        {
            var v0 = CpuVector.vload(n256, head(extract(src, offset, bitsize<byte>())));
            return (byte)BitPack.lsbpack(dinx.vcompact(v0,n128,z8));
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static ushort scalar(in BitSpan src, N16 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ushort>())); 
            return BitPack.pack(unpacked, n);
        }

        /// <summary>
        /// Packs the 32 source bits that follow a specified offset
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static uint scalar(in BitSpan src, N32 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<uint>()));            
            return BitPack.pack(unpacked,n,offset);            
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static ulong scalar(in BitSpan src, N64 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ulong>()));
            return BitPack.pack(unpacked,n,offset);
        }

        [MethodImpl(Inline)]
        static Span<uint> extract(in BitSpan src, int offset, int count)
           => src.Bits.Slice(offset, count).As<bit,uint>();
    }
}
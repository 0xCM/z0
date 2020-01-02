//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    
    using static AsIn;

    partial class BitPack
    {
        [MethodImpl(Inline)]
        public static T pack<T>(Span<bit> src, T t = default)
            where T : unmanaged
                => pack_u<T>(src);

        [MethodImpl(Inline)]
        static T pack_u<T>(Span<bit> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(pack(src, n8));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack(src, n16));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack(src, n32));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack(src, n64));
            else
                return pack_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T pack_i<T>(Span<bit> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(pack(src, n8));
            else if(typeof(T) == typeof(short))
                return convert<T>(pack(src, n16));
            else if(typeof(T) == typeof(int))
                return convert<T>(pack(src, n32));
            else if(typeof(T) == typeof(long))
                return convert<T>(pack(src, n64));
            else
                throw unsupported<T>();            
        }

        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static byte pack(Span<bit> src, N8 n)
        {
            var v0 = CpuVector.vload(n256, head(convert(src, 0, bitsize<byte>())));
            return (byte)packlsb8(dinx.vcompact(v0,n128,z8));
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static ushort pack(Span<bit> src, N16 n)
        {
            ref readonly var unpacked = ref head(convert(src, 0, bitsize<ushort>())); 
            return pack32(unpacked, n);
        }

        /// <summary>
        /// Packs the 32 source bits that follow a specified offset
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static uint pack(Span<bit> src, N32 n)
        {
            ref readonly var unpacked = ref head(convert(src, 0, bitsize<uint>()));
            return pack32(unpacked,n);            
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        static ulong pack(Span<bit> src, N64 n)
        {
            ref readonly var unpacked = ref head(convert(src, 0, bitsize<ulong>()));
            return pack32(unpacked,n);
        }
    }
}
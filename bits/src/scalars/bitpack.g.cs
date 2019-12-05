//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    
    using static As;
    using static AsIn;

    partial class gbits
    {    
        [MethodImpl(Inline)]
        public static BitVector<T> bitpack<T>(Span<bit> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)pack(n8,src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)pack(n16,src));
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)pack(n32,src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>((ulong)pack(n64,src));
            else
                throw unsupported<T>();
        }

        public static ref T pack<T>(ReadOnlySpan<byte> src, ref T dst)         
            where T : unmanaged
        {
            var maxbytes = Unsafe.SizeOf<T>();
            var maxbits = maxbytes * 8;
            var slicelen = math.min(src.Length, maxbits);

            Span<byte> bs = stackalloc byte[maxbytes];
            dst = MemoryMarshal.Cast<byte,T>(pack(src.Slice(0, slicelen), bs)).First();
            return ref dst;
        }
        
        public static void pack<S,T>(ReadOnlySpan<S> src, Span<T> dst)            
            where S : unmanaged
            where T : unmanaged
        {
            var srcIx = 0;
            var dstOffset = 0;
            var dstIx = 0;
            var srcSize = bitsize<S>();
            var dstSize = bitsize<T>();
            var dstLen = dst.Length;
            var srcLen = src.Length;
            
            while(srcIx < srcLen && dstIx < dstLen)
            {
                for(byte i = 0; i< srcSize; i++)
                    if(test(src[srcIx], i))
                       enable(ref dst[dstIx], dstOffset + i);

                srcIx++;
                if((dstOffset + srcSize) >= dstSize)
                {
                    dstOffset = 0;
                    dstIx++;
                }
                else
                    dstOffset += srcSize;
            }
        }

        static Span<byte> pack(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            int srcLen = src.Length;
            for (int i = 0; i < srcLen; i++)
                if (src[i] == 1)
                    dst[i >> 3] |= (byte)((byte)1 << (i & 0x07));
            return dst;
        }
        
        /// <summary>
        /// Packs 8 source bits into the least 8 bits of a 32-bit integer
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The target integer</param>
        [MethodImpl(Inline)]
        static ulong pack(N8 n, Span<bit> src)
        {
            var dst = (uint)head(src);
            dst |= ((uint)src[1] << 1);
            dst |= ((uint)src[2] << 2);
            dst |= ((uint)src[3] << 3);
            dst |= ((uint)src[4] << 4);
            dst |= ((uint)src[5] << 5);
            dst |= ((uint)src[6] << 6);
            dst |= ((uint)src[7] << 7);
            return dst;
        }

        /// <summary>
        /// Packs 16 source bits into the lo part of a 32-bit integer
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        static ulong pack(N16 n, Span<bit> src)
        {
           var dst = pack(n8, src);
           dst |= (pack(n8, src.Slice(8)) << 8);
           return dst;          
        }

        /// <summary>
        /// Packs 32 source bits into a 32-bit integer
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        static ulong pack(N32 n, Span<bit> src)
        {
           var dst = pack(n16, src);
           dst |= (pack(n16, src.Slice(16)) << 16);
           return dst;          
        }

        /// <summary>
        /// Packs 64 source bits into a 64-bit integer
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        static ulong pack(N64 n, Span<bit> src)
        {
           var dst = pack(n32, src);
           dst |= (pack(n32, src.Slice(32)) << 32);
           return dst;          
        }
    }   
}
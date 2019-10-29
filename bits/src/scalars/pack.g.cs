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
        public static BitVector<T> pack<T>(Span<bit> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)Bits.pack(n8,src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)Bits.pack(n16,src));
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)Bits.pack(n32,src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>((ulong)Bits.pack(n64,src));
            else
                throw unsupported<T>();
        }

        public static ref T pack<T>(ReadOnlySpan<bit> src, ref T dst)         
            where T : unmanaged
        {
            var maxbytes = Unsafe.SizeOf<T>();
            var maxbits = maxbytes * 8;
            var slicelen = math.min(src.Length, maxbits);

            Span<byte> bs = stackalloc byte[maxbytes];
            dst = MemoryMarshal.Cast<byte,T>(Bits.pack(src.Slice(0, slicelen), bs)).First();
            return ref dst;
        }

        public static ref T pack<T>(ReadOnlySpan<byte> src, ref T dst)         
            where T : unmanaged
        {
            var maxbytes = Unsafe.SizeOf<T>();
            var maxbits = maxbytes * 8;
            var slicelen = math.min(src.Length, maxbits);

            Span<byte> bs = stackalloc byte[maxbytes];
            dst = MemoryMarshal.Cast<byte,T>(Bits.pack(src.Slice(0, slicelen), bs)).First();
            return ref dst;
        }

        public static Span<T> pack<T>(ReadOnlySpan<bit> src, Span<T> dst)         
            where T : unmanaged
        {
            Bits.pack(src, dst.AsBytes());
            return dst;
        }
        
        public static Span<T> pack<S,T>(ReadOnlySpan<S> src, Span<T> dst)            
            where S : unmanaged
            where T : unmanaged
        {
            var srcIx = 0;
            var dstOffset = 0;
            var dstIx = 0;
            var srcSize = Unsafe.SizeOf<S>()*8;
            var dstSize = Unsafe.SizeOf<T>()*8;
            
            while(srcIx < src.Length && dstIx < dst.Length)
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
            return dst;
        }
    }
}
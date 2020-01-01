//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;

    partial class BitPack
    {
       /// <summary>
       /// Unpacks each primal source bit to a 32-bit target
       /// </summary>
       /// <param name="src">The bit source</param>
       /// <param name="dst">The bit target</param>
       /// <typeparam name="T">The source type</typeparam>
       [MethodImpl(Inline)]
        public static void unpack32<T>(T src, Span<uint> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                unpack8x32(uint8(src), dst);
            else if(typeof(T) == typeof(ushort))
                unpack16x32(uint16(src), dst);
            else if(typeof(T) == typeof(uint))
                unpack32x32(uint32(src), dst);
            else if(typeof(T) == typeof(ulong))
                unpack64x32(uint64(src), dst);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Unpacks each primal source bit in each source value to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline)]
        public static void unpack32<T>(ReadOnlySpan<T> src, in Block256<uint> dst)
            where T : unmanaged
        {            
            var blockcount = dst.BlockCount;
            var bytes = src.AsBytes();
            ref readonly var bitsrc = ref head(bytes);

            for(var block=0; block < blockcount; block++)
                unpack8x32(skip(bitsrc, block), dst.Block(block));             
        }

        /// <summary>
        /// Unpacks each primal source bit in each source value to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline)]
        public static void unpack32<T>(Span<T> src, in Block256<uint> dst)
            where T : unmanaged
                => unpack32(src.ReadOnly(),dst);
                    
        /// <summary>
        /// Unpacks an arbitrary number of source bytes over 32-bit segments
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline)]
        static void unpack32(ReadOnlySpan<byte> src, in Block256<uint> dst)
        {            
            var blockcount = dst.BlockCount;
            for(var block=0; block < blockcount; block++)
                unpack8x32(skip(src, block), dst.Block(block));             
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<uint> unpack32<T>(ReadOnlySpan<T> packed, in Block256<uint> unpacked, int block)
            where T : unmanaged
        {
            const int blocklen = 8;
            const int blockcount = 1;
            
            ref readonly var src = ref skip(packed, block);
            unpack32(src, unpacked.Block(block));
            return ref unpacked;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<uint> unpack32<T>(Span<T> packed, in Block256<uint> unpacked, int block)
            where T : unmanaged
                => ref unpack32(packed.ReadOnly(),unpacked,block);
        
        [MethodImpl(Inline)]
        static ref readonly Block256<uint> unpack32(ReadOnlySpan<byte> packed, in Block256<uint> unpacked, int block)
        {
            const int blocklen = 8;
            const int blockcount = 1;
            
            ref readonly var src = ref skip(packed, block);
            unpack8x32(src, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        static void unpack8x32(byte src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);

            unpack8x8(src, ref tmp);             
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
        }

        /// <summary>
        /// Unpacks 8 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        static void unpack16x32(ushort src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);

            unpack8x8((byte)src, ref tmp);             
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
            unpack8x8((byte)(src >> 8), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 8);     
        }

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        static void unpack32x32(uint src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);

            unpack8x8((byte)src, ref tmp);             
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
            unpack8x8((byte)(src >> 8), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 8);     
            unpack8x8((byte)(src >> 16), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 16);     
            unpack8x8((byte)(src >> 24), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 24);     
        }

        [MethodImpl(Inline)]
        static void unpack64x32(ulong src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);
            
            unpack8x8((byte)src, ref tmp);             
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
            unpack8x8((byte)(src >> 8), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 8);     
            unpack8x8((byte)(src >> 16), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 16);     
            unpack8x8((byte)(src >> 24), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 24);     
            unpack8x8((byte)(src >> 32), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 32);     
            unpack8x8((byte)(src >> 40), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 40);     
            unpack8x8((byte)(src >> 48), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 48);                 
            unpack8x8((byte)(src >> 56), ref tmp);        
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 56);     
        } 
    }
}
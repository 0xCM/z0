//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Core;

    partial class BitPack
    {
        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static void unpack32<T>(T src, Span<uint> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                unpack32(uint8(src), dst);
            else if(typeof(T) == typeof(ushort))
                unpack32(uint16(src), dst);
            else if(typeof(T) == typeof(uint))
                unpack32(uint32(src), dst);
            else if(typeof(T) == typeof(ulong))
                unpack32(uint64(src), dst);
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static void unpack32<T>(ReadOnlySpan<T> src, in Block256<uint> dst)
            where T : unmanaged
        {            
            var blockcount = dst.BlockCount;
            var bytes = src.AsBytes();
            ref readonly var bitsrc = ref head(bytes);

            for(var block=0; block < blockcount; block++)
                unpack32(skip(bitsrc, block), dst.Block(block));             
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline)]
        public static void unpack32<T>(Span<T> src, in Block256<uint> dst)
            where T : unmanaged
                => unpack32(src.ReadOnly(),dst);
                    
        /// <summary>
        /// Unpacks each primal source bit to a 32-bit blocked target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static ref readonly Block256<uint> unpack32<T>(ReadOnlySpan<T> src, in Block256<uint> dst, int block)
            where T : unmanaged
        {
            const int blocklen = 8;
            const int blockcount = 1;
            
            unpack32(skip(src, block), dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit blocked target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<uint> unpack32<T>(Span<T> src, in Block256<uint> dst, int block)
            where T : unmanaged
                => ref unpack32(src.ReadOnly(),dst,block);

        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bytes to pack</param>
        /// <param name="target">The target reference, of size at least 256*count bits</param>
        [MethodImpl(Inline), Op]
        public static void unpack32(in byte src, int count, ref uint target)        
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);

            for(var i = 0; i < count; i++)
            {
                unpack8(skip(in src, i), ref tmp); 
                dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref seek(ref target, i*8));
            }
        }

        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 256-bit blocks comprising 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="blocks">The number of bytes to pack</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack32(in byte src, int blocks, in Block256<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            
            for(var block=0; block < blocks; block++)
            {
                unpack8(skip(in src, block), ref tmp); 
                dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref target.BlockRef(block));
            }
        }

        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        static void unpack32(byte src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);

            unpack8(src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
        }

        /// <summary>
        /// Unpacks 8 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        static void unpack32(ushort src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);

            unpack8((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
            unpack8((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 8);     
        }

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        static void unpack32(uint src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);

            unpack8((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
            unpack8((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 8);     
            unpack8((byte)(src >> 16), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 16);     
            unpack8((byte)(src >> 24), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 24);     
        }

        [MethodImpl(Inline)]
        static void unpack32(ulong src, Span<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var dst = ref head(target);
            
            unpack8((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst);
            unpack8((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 8);     
            unpack8((byte)(src >> 16), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 16);     
            unpack8((byte)(src >> 24), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 24);     
            unpack8((byte)(src >> 32), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 32);     
            unpack8((byte)(src >> 40), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 40);     
            unpack8((byte)(src >> 48), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 48);                 
            unpack8((byte)(src >> 56), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst, 56);     
        } 
    }
}
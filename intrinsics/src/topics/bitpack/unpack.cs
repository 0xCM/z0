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
    using static dinx;

    partial class BitPack
    {
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8x8(byte packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block64<byte> unpack8x8(byte packed, in Block64<byte> unpacked, int block = 0)
        {
            unpack8x8(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">A reference to the target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8x8(byte packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack16x8(ushort packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
            seek64(ref dst, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block128<byte> unpack16x8(ushort packed, in Block128<byte> unpacked, int block = 0)
        {
            unpack16x8(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack16x8(ushort packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
            seek64(ref unpacked, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack32x8(uint packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
            seek64(ref unpacked, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
            seek64(ref unpacked, 2) = Bits.scatter((ulong)((byte)(packed >> 16)), m);
            seek64(ref unpacked, 3) = Bits.scatter((ulong)((byte)(packed >> 24)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack32x8(uint packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
            seek64(ref dst, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
            seek64(ref dst, 2) = Bits.scatter((ulong)((byte)(packed >> 16)), m);
            seek64(ref dst, 3) = Bits.scatter((ulong)((byte)(packed >> 24)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<byte> unpack32x8(uint packed, in Block256<byte> unpacked, int block = 0)
        {                
            unpack32x8(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack64x8(ulong packed, ref byte unpacked)        
        {
            unpack32x8((uint)packed, ref unpacked);
            unpack32x8((uint)(packed >> 32), ref seek(ref unpacked, 32));
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack64x8(ulong packed, Span<byte> unpacked)        
        {
            unpack32x8((uint)packed, unpacked.Slice(0,32));
            unpack32x8((uint)(packed >> 32), unpacked.Slice(32,32));
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block512<byte> unpack64x8(ulong packed, in Block512<byte> unpacked, int block = 0)        
        {
            unpack64x8(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Unpacks a specified number source bytes over a corresponding count of 256-bit blocks of 32-bit target segments
        /// </summary>
        /// <param name="count">The number of bytes to pack</param>
        /// <param name="src">The source reference</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8x32(int count, in byte src, in Block64<byte> buffer, in Block256<uint> target)
        {
            for(var block=0; block < count; block++)
            {
                unpack8x8(skip(in src, block), buffer); 
                dinx.vconvert(buffer,n256).StoreTo(ref target.BlockRef(block));
            }
        }

        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8x32(byte src, in Block64<byte> buffer, Span<uint> target)
        {
            ref var dst = ref head(target);
            ref var tmp = ref buffer.Head;

            unpack8x8(src, ref tmp);             
            dinx.vconvert(buffer,n256).StoreTo(ref dst);
        }

        /// <summary>
        /// Unpacks 8 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack16x32(ushort src, in Block64<byte> buffer, Span<uint> target)
        {
            ref var dst = ref head(target);
            ref var tmp = ref buffer.Head;

            unpack8x8((byte)src, ref tmp);             
            dinx.vconvert(buffer,n256).StoreTo(ref dst);
            unpack8x8((byte)(src >> 8), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 8);     

        }

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack32x32(uint src, in Block64<byte> buffer, Span<uint> target)
        {
            ref var dst = ref head(target);
            ref var tmp = ref buffer.Head;

            unpack8x8((byte)src, ref tmp);             
            dinx.vconvert(buffer,n256).StoreTo(ref dst);
            unpack8x8((byte)(src >> 8), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 8);     
            unpack8x8((byte)(src >> 16), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 16);     
            unpack8x8((byte)(src >> 24), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 24);     
        }

        /// <summary>
        /// Unpacks 64 source bits over 64 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack64x32(ulong src, in Block64<byte> buffer, Span<uint> target)
        {
            ref var dst = ref head(target);
            ref var tmp = ref buffer.Head;
            
            unpack8x8((byte)src, ref tmp);             
            dinx.vconvert(buffer,n256).StoreTo(ref dst);
            unpack8x8((byte)(src >> 8), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 8);     
            unpack8x8((byte)(src >> 16), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 16);     
            unpack8x8((byte)(src >> 24), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 24);     
            unpack8x8((byte)(src >> 32), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 32);     
            unpack8x8((byte)(src >> 40), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 40);     
            unpack8x8((byte)(src >> 48), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 48);                 
            unpack8x8((byte)(src >> 56), ref tmp);        
            dinx.vconvert(buffer,n256).StoreTo(ref dst, 56);     
        }

        [MethodImpl(Inline)]
        public static void unpack64x32(ulong src, Span<uint> target)
            => unpack64x32(src,DataBlocks.single(n64,z8),target);

        [MethodImpl(Inline)]
        public static ref readonly Block256<uint> unpack8x32(ReadOnlySpan<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked, int block)
        {
            const int blocklen = 8;
            const int blockcount = 1;

            ref readonly var src = ref skip(packed, block);
            
            unpack8x32(src, buffer, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Unpacks an arbitrary number of source bytes over 32-bit segments
        /// </summary>
        /// <param name="packed">The packed data source</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan receiver which must have a block length equal or greater than the number of packed source bytes</param>
        [MethodImpl(Inline)]
        public static void unpack8x32(ReadOnlySpan<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {            
            var blockcount = unpacked.BlockCount;
            for(var block=0; block < blockcount; block++)
                unpack8x32(skip(packed, block), buffer, unpacked.Block(block));             
        }
    }
}
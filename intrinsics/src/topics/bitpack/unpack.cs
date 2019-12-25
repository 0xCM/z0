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
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block64<byte> unpack(byte packed, in Block64<byte> unpacked, int block = 0)
        {
            unpack(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block128<byte> unpack(ushort packed, in Block128<byte> unpacked, int block = 0)
        {
            unpack(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<byte> unpack(uint packed, in Block256<byte> unpacked, int block = 0)
        {                
            unpack(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block512<byte> unpack(ulong packed, in Block512<byte> unpacked, int block = 0)        
        {
            unpack(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">A reference to the target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack(byte packed, ref byte unpacked)
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
        public static void unpack(ushort packed, ref byte unpacked)
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
        public static void unpack(uint packed, ref byte unpacked)
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
        public static void unpack(ulong packed, ref byte unpacked)        
        {
            unpack((uint)packed, ref unpacked);
            unpack((uint)(packed >> 32), ref seek(ref unpacked, 32));
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack(byte packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack(ushort packed, Span<byte> unpacked)
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
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack(uint packed, Span<byte> unpacked)
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
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack(ulong packed, Span<byte> unpacked)        
        {
            unpack((uint)packed, unpacked.Slice(0,32));
            unpack((uint)(packed >> 32), unpacked.Slice(32,32));
        }


        /// <summary>
        /// Unpacks an arbitrary number of source bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan receiver which must have a block length equal or greater than the number of packed source bytes</param>
        [MethodImpl(Inline)]
        public static void unpack(ReadOnlySpan<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {            
            var blockcount = unpacked.BlockCount;
            for(var block=0; block < blockcount; block++)
                unpack(skip(packed, block), buffer, unpacked.Block(block));             
        }

        [MethodImpl(Inline)]
        static void unpack(byte src, in Block64<byte> buffer, Span<uint> target)
        {
            unpack(src, buffer);             
            dinx.vconvert(buffer,n256).StoreTo(ref head(target));
        }

        [MethodImpl(Inline)]
        static ref readonly Block256<uint> unpacksingle(ReadOnlySpan<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked, int block)
        {
            const int blocklen = 8;
            const int blockcount = 1;
            ref readonly var src = ref skip(packed, block);
            unpack(src, buffer, unpacked.Block(block));
            return ref unpacked;
        }

        [MethodImpl(Inline)]
        static void unpackblock(int block, in byte src, in Block64<byte> buffer, in Block256<uint> target)
        {
            unpack(skip(in src, block), buffer); 
            dinx.vconvert(buffer,n256).StoreTo(ref target.BlockRef(block));
        }

        [MethodImpl(Inline)]
        static void unpackblocks(int count, in byte src, in Block64<byte> buffer, in Block256<uint> target)
        {
            for(var block=0; block < count; block++)
            {
                unpack(skip(in src, block), buffer); 
                dinx.vconvert(buffer,n256).StoreTo(ref target.BlockRef(block));
            }
        }
    }
}
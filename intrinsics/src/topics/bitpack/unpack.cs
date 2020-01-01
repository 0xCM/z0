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
        /// Distributes each packed source bit to the least significant bit of 8 corresponding target bytes
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
        /// Distributes each packed source bit to the least significant bit of 16 corresponding target bytes
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
        /// Distributes each packed source bit to the least significant bit of 32 corresponding target bytes
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
        /// Distributes each packed source bit to the least significant bit of 64 corresponding target bytes
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
        /// <param name="target">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8x32(int count, in byte src, in Block256<uint> target)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            
            for(var block=0; block < count; block++)
            {
                unpack8x8(skip(in src, block), ref tmp); 
                dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref target.BlockRef(block));
            }
        }

        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 32-bit target values
        /// </summary>
        /// <param name="count">The number of bytes to pack</param>
        /// <param name="src">The source reference</param>
        /// <param name="target">The target reference, of size at least 256*count bits</param>
        [MethodImpl(Inline)]
        public static void unpack8x32(int count, in byte src, ref uint target)        
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);

            for(var i = 0; i < count; i++)
            {
                unpack8x8(skip(in src, i), ref tmp); 
                dinx.vconvert(n64, in tmp, n256, n32).StoreTo(ref seek(ref target, i*8));
            }
        }
    }
}
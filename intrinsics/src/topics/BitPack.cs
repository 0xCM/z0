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

    public static class BitPack
    {
        public static Span<T> pack<S,T>(ReadOnlySpan<S> src, T t = default)
            where S : unmanaged
            where T : unmanaged
        {            
            var inbits = src.Length * bitsize<S>();
            var outcells = inbits / bitsize<S>() + (inbits % bitsize<S>() == 0 ? 0 : 1);
            Span<T> dstcells = new T[outcells];            
            return default;            
        }

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]
        public static byte pack<T>(in ConstBlock64<T> src, int block = 0)
            where T : unmanaged
                => pack8(in src.BlockRef(block));

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static byte pack<T>(in Block64<T> src, int block = 0)
            where T : unmanaged
                => pack8(in src.BlockRef(block));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort pack<T>(in Block128<T> src, int block = 0)
            where T : unmanaged
                => pack16(in src.BlockRef(block));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort pack<T>(in ConstBlock128<T> src, int block = 0)
            where T : unmanaged
                => pack16(in src.BlockRef(block));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack<T>(in Block256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte from both hi and lo sources
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack<T>(in Block512<T> src, int block = 0)
            where T : unmanaged
                => pack64(in src.BlockRef(block));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack<T>(in ConstBlock256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte from both hi and lo sources
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack<T>(in ConstBlock512<T> src, int block = 0)
            where T : unmanaged
                => pack64(in src.BlockRef(block));

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8<T>(in T src)
            where T : unmanaged
                => (byte)ginx.vtakemask(ginx.vsll(ginx.vscalar(n128, const64(src)),7));

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static ushort pack16<T>(in T src)
            where T : unmanaged
            => ginx.vtakemask(ginx.vsll(ginx.vload(n128, const64(src)),7));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static uint pack32<T>(in T src)
            where T : unmanaged
                => ginx.vtakemask(ginx.vsll(ginx.vload(n256, const64(src)),7));

        [MethodImpl(Inline)]
        static ulong pack64<T>(in T src, int block = 0)
            where T : unmanaged
        {
            var dst = 0ul;
            dst = (ulong)pack32(in src);
            dst |=(ulong)pack32(in skip(in src, 32)) << 32;
            return dst;
        }
         
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block64<byte> unpackbits(byte packed, in Block64<byte> unpacked, int block = 0)
        {
            unpackbits(packed, unpacked.Block(block));
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
        public static ref readonly Block128<byte> unpackbits(ushort packed, in Block128<byte> unpacked, int block = 0)
        {
            unpackbits(packed, unpacked.Block(block));
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
        public static ref readonly Block256<byte> unpackbits(uint packed, in Block256<byte> unpacked, int block = 0)
        {                
            unpackbits(packed, unpacked.Block(block));
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
        public static ref readonly Block512<byte> unpackbits(ulong packed, in Block512<byte> unpacked, int block = 0)        
        {
            unpackbits(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpackbits(byte packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = dinx.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpackbits(ushort packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = dinx.scatter((ulong)(byte)packed, m);
            seek64(ref dst, 1) = dinx.scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpackbits(uint packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = dinx.scatter((ulong)(byte)packed, m);
            seek64(ref dst, 1) = dinx.scatter((ulong)((byte)(packed >> 8)), m);
            seek64(ref dst, 2) = dinx.scatter((ulong)((byte)(packed >> 16)), m);
            seek64(ref dst, 3) = dinx.scatter((ulong)((byte)(packed >> 24)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpackbits(ulong packed, Span<byte> unpacked)        
        {
            unpackbits((uint)packed, unpacked.Slice(0,32));
            unpackbits((uint)(packed >> 32), unpacked.Slice(32,32));
        }

        [MethodImpl(Inline)]
        public static BitSpan bitspan(byte packed, Block64<byte> buffer,  Block256<uint> unpacked)
        {
            unpackbits(packed,buffer); 
            dinx.vloadblock(buffer,n256).StoreTo(unpacked);
            return BitSpan.load(unpacked.As<bit>());
        }

        /// <summary>
        /// Creates a bitspan from 64 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The target buffer which must cover at least 8 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in Block64<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpack(8, in packed.Head, buffer, unpacked);                        
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 32 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The target buffer which must cover at least 4 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in Block32<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpack(4, in packed.Head, buffer, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 16 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The target buffer which must cover at least 2 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in Block16<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpack(2, in packed.Head, buffer, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 16 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The target buffer which must cover at least 2 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in Block16<byte> packed, in Block64<byte> buffer, in Block256<bit> unpacked)
        {
            unpack(2, in packed.Head, buffer, unpacked);            
            return BitSpan.load(unpacked);            
        }

        /// <summary>
        /// Creates a bitspan from 8 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        public static BitSpan bitspan(byte packed)
        {
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.single(n256,z32);
            return bitspan(packed, buffer,target);
        }

        /// <summary>
        /// Creates a bitspan from 16 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        public static BitSpan bitspan(ushort packed)
        {
            const int blocks = 2;
            var bytes = BitConvert.GetBytes(packed, DataBlocks.single(n16,z8));
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.alloc(n256,blocks,z32);
            return bitspan(bytes, buffer, target);
        }

        /// <summary>
        /// Creates a bitspan from 32 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        public static BitSpan bitspan(uint packed)
        {
            const int blocks = 4;
            var bytes = BitConvert.GetBytes(packed, DataBlocks.single(n32,z8));
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.alloc(n256,blocks,z32);
            return bitspan(bytes, buffer, target);
        }

        /// <summary>
        /// Creates a bitspan from 64 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        public static BitSpan bitspan(ulong packed)
        {
            const int blocks = 8;
            var bytes = BitConvert.GetBytes(packed, DataBlocks.single(n64,z8));
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.alloc(n256,blocks,z32);
            return bitspan(bytes, buffer, target);
        }

        [MethodImpl(Inline)]
        static void unpack(int blocks, in byte src, in Block64<byte> buffer, in Block256<uint> target)
        {
            for(var block=0; block < blocks; block++)
            {
                unpackbits(skip(in src, block), buffer); 
                dinx.vloadblock(buffer,n256).StoreTo(ref target.BlockRef(block));
            }
        }

        [MethodImpl(Inline)]
        static void unpack(int blocks, in byte src, in Block64<byte> buffer, in Block256<bit> target)
        {
            for(var block=0; block < blocks; block++)
            {
                unpackbits(skip(in src, block), buffer); 
                dinx.vloadblock(buffer,n256).StoreTo(ref target.As<uint>().BlockRef(block));
            }
        }
    }
}
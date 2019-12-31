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
    using static AsIn;
    using static dinx;

    partial class BitPack
    {
        [MethodImpl(Inline)]
        public static T pack<T>(in BitSpan src, int offset = 0, int? count = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(pack(src, n8, offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack(src, n16, offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack(src, n32, offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack(src, n64, offset));
            else
                throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static T pack<T>(Span<bit> src)
            where T : unmanaged
        {
            if(bitsize<T>() == 8)
                return convert<T>(pack(src, n8));
            else if(bitsize<T>() == 16)
                return convert<T>(pack(src, n16));
            else if(bitsize<T>() == 32)
                return convert<T>(pack(src, n32));
            else if(bitsize<T>() == 64)
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
        public static byte pack(Span<bit> src, N8 n, int offset = 0)
        {
            var v0 = CpuVector.vload(n256, head(convert(src, offset, bitsize<byte>())));
            return (byte)lsbpack(dinx.vcompact(v0,n128,z8));
        }

        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        public static byte pack(in BitSpan src, N8 n, int offset = 0)
        {
            var v0 = CpuVector.vload(n256, head(extract(src, offset, bitsize<byte>())));
            return (byte)lsbpack(dinx.vcompact(v0,n128,z8));
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        public static ushort pack(in BitSpan src, N16 n, int offset = 0)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ushort>())); 
            return pack(unpacked, n, offset);
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        public static ushort pack(Span<bit> src, N16 n, int offset = 0)
        {
            ref readonly var unpacked = ref head(convert(src, offset, bitsize<ushort>())); 
            return pack(unpacked, n, offset);
        }

        /// <summary>
        /// Packs the 32 source bits that follow a specified offset
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        public static uint pack(in BitSpan src, N32 n, int offset = 0)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<uint>()));            
            return pack(unpacked,n,offset);            
        }

        /// <summary>
        /// Packs the 32 source bits that follow a specified offset
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline)]
        public static uint pack(Span<bit> src, N32 n, int offset = 0)
        {
            ref readonly var unpacked = ref head(convert(src, offset, bitsize<uint>()));
            return pack(unpacked,n,offset);            
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        /// <remarks>The silly loop is required to prvent an order of magnitude increase in the size of the generated assembly (3mb + !)</remarks>
        [MethodImpl(Inline)]
        public static ulong pack(in BitSpan src, N64 n, int offset = 0)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ulong>()));
            return pack(unpacked,n,offset);
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        /// <remarks>The silly loop is required to prvent an order of magnitude increase in the size of the generated assembly (3mb + !)</remarks>
        [MethodImpl(Inline)]
        public static ulong pack(Span<bit> src, N64 n, int offset = 0)
        {
            ref readonly var unpacked = ref head(convert(src, offset, bitsize<ulong>()));
            return pack(unpacked,n,offset);
        }

        [MethodImpl(Inline)]
        public static ushort pack(in uint unpacked, N16 n, int offset = 0)
        {
            var v0 = CpuVector.vload(n256, skip(unpacked,0*8));
            var v1 = CpuVector.vload(n256, skip(unpacked,1*8));
            return lsbpack(dinx.vcompact(v0, v1, n128, z8));
        }

        [MethodImpl(Inline)]
        public static uint pack(in uint unpacked, N32 n, int offset = 0)
        {            
            var v0 = CpuVector.vload(n256, skip(unpacked,0*8));
            var v1 = CpuVector.vload(n256, skip(unpacked,1*8));
            var x = dinx.vcompact(v0,v1,n256,z16);

            v0 = CpuVector.vload(n256, skip(unpacked,2*8));
            v1 = CpuVector.vload(n256, skip(unpacked,3*8));
            var y = dinx.vcompact(v0,v1,n256,z16);

            return lsbpack(dinx.vcompact(x,y,n256,z8));
        }

        [MethodImpl(Inline)]
        static ulong pack(in uint unpacked, N64 n, int offset = 0)
        {
            var v0 = CpuVector.vload(n256, skip(unpacked,0*8));
            var v1 = CpuVector.vload(n256, skip(unpacked,1*8));
            var x = dinx.vcompact(v0,v1,n256,z16);

            v0 = CpuVector.vload(n256, skip(unpacked,2*8));
            v1 = CpuVector.vload(n256, skip(unpacked,3*8));
            var y = dinx.vcompact(v0,v1,n256,z16);

            var packed = (ulong)lsbpack(dinx.vcompact(x,y,n256,z8));

            v0 = CpuVector.vload(n256, skip(unpacked,4*8));
            v1 = CpuVector.vload(n256, skip(unpacked,5*8));
            x = dinx.vcompact(v0,v1,n256,z16);

            v0 = CpuVector.vload(n256, skip(unpacked,6*8));
            v1 = CpuVector.vload(n256, skip(unpacked,7*8));
            y = dinx.vcompact(v0,v1,n256,z16);

            packed |= (ulong)lsbpack(dinx.vcompact(x,y,n256,z8)) << 32;

            return packed;
        }

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort lsbpack(Vector128<byte> src)
            => pack(src,0);

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint lsbpack(Vector256<byte> src)
            => pack(src,0);

        /// <summary>
        /// Packs 16 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort msbpack(Vector128<byte> src)
            => dinx.vtakemask(src);

        /// <summary>
        /// Packs 32 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong msbpack(Vector256<byte> src)
            => dinx.vtakemask(src);

        /// <summary>
        /// Packs 16 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7][</param>
        [MethodImpl(Inline)]
        public static ushort pack(Vector128<byte> src, byte index)
            => dinx.vtakemask(src,index);

        /// <summary>
        /// Packs 32 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7][</param>
        [MethodImpl(Inline)]
        public static uint pack(Vector256<byte> src, byte index)
            => dinx.vtakemask(src,index);

        /// <summary>
        /// Packs 4 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static byte pack<T>(in Block32<T> src)
            where T : unmanaged
                => (byte) Bits.gather(uint32(in src.Head), BitMasks.Lsb32x8x1);

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static byte pack<T>(in Block64<T> src, int block = 0)
            where T : unmanaged
                => pack8(convert<T,ulong>(src.BlockRef(block)));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort pack<T>(in Block128<T> src, int block = 0)
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
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack<T>(in Block512<T> src, int block = 0)
            where T : unmanaged
                => pack64(in src.BlockRef(block));

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8(ulong src)
            => (byte)Bits.gather(src, BitMasks.Lsb64x8x1);

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8<T>(in T src)
            where T : unmanaged
                => (byte)Bits.gather(convert<T,ulong>(src), BitMasks.Lsb64x8x1);

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static ushort pack16<T>(in T src)
            where T : unmanaged
                => vtakemask(ginx.vsll(CpuVector.vload(n128, const64(src)),7));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static uint pack32<T>(in T src)
            where T : unmanaged
                => vtakemask(ginx.vsll(CpuVector.vload(n256, const64(src)),7));

        [MethodImpl(Inline)]
        static ulong pack64<T>(in T src)
            where T : unmanaged
        {
            var dst = 0ul;
            dst = (ulong)pack32(in src);
            dst |=(ulong)pack32(in skip(in src, 32)) << 32;
            return dst;
        }        

        [MethodImpl(Inline)]
        static Span<uint> extract(in BitSpan src, int offset, int count)
           => src.Bits.Slice(offset, count).As<bit,uint>();

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<bit> src, int offset, int count)
           => src.Slice(offset, count).As<bit,uint>();

    }
}
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

    partial struct BitSpan
    {
        /// <summary>
        /// Creates a bitspan from a primal source
        /// </summary>
        /// <param name="src">The packed source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan load<T>(T src)
            where T : unmanaged
        {
            if(bitsize<T>() == 8)
                return load(convert<T,byte>(src));
            else if(bitsize<T>() == 16)
                return load(convert<T,ushort>(src));
            else if(bitsize<T>() == 32)
                return load(convert<T,uint>(src));
            else if(bitsize<T>() == 64)
                return load(convert<T,ulong>(src));
            else
                throw unsupported<T>();            
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan load<T>(Span<T> packed)
            where T : unmanaged
                => load(packed.AsBytes());

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan load<T>(ReadOnlySpan<T> packed)
            where T : unmanaged
                => load(packed.AsBytes());

        /// <summary>
        /// Creates a bitspan from 8 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        [MethodImpl(Inline)]
        static BitSpan load(byte packed)
        {
            var target = DataBlocks.single(n256,z32);
            return load(packed, DataBlocks.single(n256,z32));
        }

        /// <summary>
        /// Creates a bitspan from 16 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        [MethodImpl(Inline)]
        static BitSpan load(ushort packed)
        {
            const int blocks = 2;
            var bytes = BitConvert.GetBytes(packed, DataBlocks.single(n16,z8));
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.alloc(n256,blocks,z32);
            return load(bytes, target);
        }

        /// <summary>
        /// Creates a bitspan from 32 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        [MethodImpl(Inline)]
        static BitSpan load(uint packed)
        {
            const int blocks = 4;
            var bytes = BitConvert.GetBytes(packed, DataBlocks.single(n32,z8));
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.alloc(n256,blocks,z32);
            return load(bytes,  target);
        }

        /// <summary>
        /// Creates a bitspan from 64 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        [MethodImpl(Inline)]
        static BitSpan load(ulong packed)
        {
            const int blocks = 8;

            var bytes = BitConvert.GetBytes(packed, DataBlocks.single(n64,z8));
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.alloc(n256,blocks,z32);
            return load(bytes, target);
        }        
         
        /// <summary>
        /// Creates a bitspan from 8 packed bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The bitspan content receiver</param>
        [MethodImpl(Inline)]
        static BitSpan load(byte packed, in Block256<uint> unpacked)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);

            BitPack.unpack8x8(packed, ref tmp); 
            dinx.vconvert(n64, in tmp, n256, n32).StoreTo(unpacked);
            return load(unpacked.As<bit>());
        }

        /// <summary>
        /// Creates a bitspan from 16 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 2 blocks</param>
        [MethodImpl(Inline)]
        static BitSpan load(in Block16<byte> packed, in Block256<uint> unpacked)
        {
            BitPack.unpack8x32(2, in packed.Head, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 32 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 4 blocks</param>
        [MethodImpl(Inline)]
        static BitSpan load(in Block32<byte> packed, in Block256<uint> unpacked)
        {
            BitPack.unpack8x32(4, in packed.Head, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 64 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 8 blocks</param>
        [MethodImpl(Inline)]
        static BitSpan load(in Block64<byte> packed, in Block256<uint> unpacked)
        {
            BitPack.unpack8x32(8, in packed.Head, unpacked);                        
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        static BitSpan load(ReadOnlySpan<byte> packed)
        {            
            const int blocklen = 8;

            var blockcount = packed.Length;
            var unpacked = DataBlocks.alloc(n256, blockcount, z32);
            for(var block=0; block < blockcount; block++)
                BitPack.unpack32(packed, unpacked,block);
            return BitSpan.load(unpacked.As<bit>());
        }

        [MethodImpl(Inline)]
        static BitSpan load(ulong packed, ref byte unpacked)
        {
            BitPack.unpack64x8(packed, ref unpacked);
            return BitSpan.load(ref Unsafe.As<byte,bit>(ref unpacked), 64);
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        static BitSpan load(Span<byte> packed)
            => load(packed.ReadOnly());
                    

        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan load(Span<bit> src)
            => new BitSpan(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitSpan load(bit[] src)
            => new BitSpan(src);
        
        /// <summary>
        /// Loads a bitspan from a reference
        /// </summary>
        /// <param name="bits">The bit source</param>
        /// <param name="count">The number of bits to load</param>
        [MethodImpl(Inline)]
        public static BitSpan load(ref bit bits, int count)        
            => new BitSpan(MemoryMarshal.CreateSpan(ref bits,count));         
    }
}
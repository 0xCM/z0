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

    public static partial class BitPack
    {
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
         
        /// <summary>
        /// Creates a bitspan from 8 packed bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content receiver</param>
        /// <param name="block">The receiving block index</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(byte packed, in Block64<byte> buffer, in Block256<uint> unpacked, int block = 0)
        {
            unpack(packed,buffer,block); 
            dinx.vloadblock(buffer,n256).StoreTo(unpacked);
            return BitSpan.load(unpacked.As<bit>());
        }

        /// <summary>
        /// Creates a bitspan from 16 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 2 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in ConstBlock16<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpackblocks(2, in packed.Head, buffer, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 16 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 2 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in Block16<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpackblocks(2, in packed.Head, buffer, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 32 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 4 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in ConstBlock32<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpackblocks(4, in packed.Head, buffer, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 32 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 4 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in Block32<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpackblocks(4, in packed.Head, buffer, unpacked);            
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 64 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 8 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in ConstBlock64<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpackblocks(8, in packed.Head, buffer, unpacked);                        
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from 64 packed source bits
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="buffer">The staging buffer</param>
        /// <param name="unpacked">The bitspan content buffer which must cover at least 8 blocks</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(in Block64<byte> packed, in Block64<byte> buffer, in Block256<uint> unpacked)
        {
            unpackblocks(8, in packed.Head, buffer, unpacked);                        
            return BitSpan.load(unpacked.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        public static BitSpan bitspan(ReadOnlySpan<byte> packed)
        {            
            const int blocklen = 8;

            var blockcount = packed.Length;
            var buffer = DataBlocks.single(n64,z8);
            var unpacked = DataBlocks.alloc(n256, blockcount, z32);
            for(var block=0; block < blockcount; block++)
                unpacksingle(packed, buffer, unpacked,block);
            return BitSpan.load(unpacked.As<bit>());
        }
                
        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(ReadOnlySpan<ushort> packed)
            => bitspan(packed.AsBytes());

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(ReadOnlySpan<uint> packed)
            => bitspan(packed.AsBytes());

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan(ReadOnlySpan<ulong> packed)
            => bitspan(packed.AsBytes());

   }
}
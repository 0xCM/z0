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

    public static partial class BitPack
    {
         [MethodImpl(Inline)]
         public static T scalar<T>(in BitSpan src, int offset = 0, int? count = null)
            where T : unmanaged
         {
             var n = bitsize<T>();
             Span<bit> bits = stackalloc bit[n];
             src.Bits.Slice(offset, count ?? n).CopyTo(bits);
             return BitPack.pack<T>(bits);             
         }

         [MethodImpl(Inline)]
         public static T scalar<T>(in BitSpan src)
            where T : unmanaged
                => BitPack.pack<T>(src.Bits.Slice(0, bitsize<T>()));             

        [MethodImpl(Inline)]
        public static BitSpan bitspan<T>(T packed)        
            where T : unmanaged
        {
            if(bitsize<T>() == 8)
                return bitspan(convert<T,byte>(packed));
            else if(bitsize<T>() == 16)
                return bitspan(convert<T,ushort>(packed));
            else if(bitsize<T>() == 32)
                return bitspan(convert<T,uint>(packed));
            else    
                return bitspan(convert<T,ulong>(packed));
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
            ref var _bytes = ref ref8(ref packed);
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
            dinx.vconvert(buffer,n256).StoreTo(unpacked);
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

        [MethodImpl(Inline)]
        public static BitSpan bitspan(ulong packed, ref byte unpacked)
        {
            unpack(packed, ref unpacked);
            return BitSpan.load(ref Unsafe.As<byte,bit>(ref unpacked), 64);
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        public static BitSpan bitspan(Span<byte> packed)
            => bitspan(packed.ReadOnly());
                    
        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan<T>(Span<T> packed)
            where T : unmanaged
                => bitspan(packed.AsBytes());

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan bitspan<T>(ReadOnlySpan<T> packed)
            where T : unmanaged
                => bitspan(packed.AsBytes());

   }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;
    using static Memories;

    partial class BitPack
    {
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 8 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">A reference to the target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            refs.seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 16 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            refs.seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
            refs.seek64(ref unpacked, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 32 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            refs.seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
            refs.seek64(ref unpacked, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
            refs.seek64(ref unpacked, 2) = Bits.scatter((ulong)((byte)(packed >> 16)), m);
            refs.seek64(ref unpacked, 3) = Bits.scatter((ulong)((byte)(packed >> 24)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 64 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ulong packed, ref byte unpacked)        
        {
            unpack((uint)packed, ref unpacked);
            unpack((uint)(packed >> 32), ref seek(ref unpacked, 32));
        }

        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bytes to pack</param>
        /// <param name="dst">The target reference, of size at least 256*count bits</param>
        [MethodImpl(Inline), Op]
        public static void unpack(in byte src, int count, ref uint dst)        
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);

            for(var i = 0; i < count; i++)
            {
                unpack(skip(in src, i), ref tmp); 
                dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref seek(ref dst, i*8));
            }
        }

        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 256-bit blocks comprising 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="blocks">The number of bytes to pack</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(in byte src, int blocks, in Block256<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            
            for(var block=0; block < blocks; block++)
            {
                unpack(skip(in src, block), ref tmp); 
                dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref dst.BlockRef(block));
            }
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
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
        [MethodImpl(Inline), Op]
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
        [MethodImpl(Inline), Op]
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
        [MethodImpl(Inline), Op]
        public static ref readonly Block512<byte> unpack(ulong packed, in Block512<byte> unpacked, int block = 0)        
        {
            unpack(packed, unpacked.Block(block));
            return ref unpacked;
        } 
 
        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref head(dst);

            unpack(src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
        }

        /// <summary>
        /// Unpacks 8 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref head(dst);

            unpack((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);     
        }

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref head(dst);

            unpack((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);     
            unpack((byte)(src >> 16), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);     
            unpack((byte)(src >> 24), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);     
        }

        /// <summary>
        /// Unpacks 64 source bits over 64 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ulong src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref head(dst);
            
            unpack((byte)src, ref tmp);             
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack((byte)(src >> 8), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);     
            unpack((byte)(src >> 16), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);     
            unpack((byte)(src >> 24), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);     
            unpack((byte)(src >> 32), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 32);     
            unpack((byte)(src >> 40), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 40);     
            unpack((byte)(src >> 48), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 48);                 
            unpack((byte)(src >> 56), ref tmp);        
            dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 56);     
        }   


        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            refs.seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            refs.seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
            refs.seek64(ref dst, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);

            refs.seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
            refs.seek64(ref dst, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
            refs.seek64(ref dst, 2) = Bits.scatter((ulong)((byte)(packed >> 16)), m);
            refs.seek64(ref dst, 3) = Bits.scatter((ulong)((byte)(packed >> 24)), m);
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
 
    }
}
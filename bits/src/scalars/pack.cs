//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {         
        /// <summary>
        /// Condenses two uint8 values into a single uint16 value
        /// </summary>
        /// <param name="x0">The value to be mapped to the lo 8 bits of the output</param>
        /// <param name="x1">The value to be mapped to the hi 8 bits of the output</param>
        [MethodImpl(Inline)]
        public static ushort pack(byte x0, byte x1)
            => (ushort)((ushort)x0 << 0 * 8 | (ushort)x1 << 1 * 8);

        /// <summary>
        /// Condenses two uint16 values into a single uint32 value
        /// </summary>
        /// <param name="x0">The value to be mapped to the lo 8 bits of the output</param>
        /// <param name="x1">The value to be mapped to the hi 8 bits of the output</param>
        [MethodImpl(Inline)]
        public static uint pack(ushort x0, ushort x1)
              => (uint)x0 << 0 * 16 | (uint)x1 << 1 * 16;

        /// <summary>
        /// Condenses two uint32 values into a single uint64 value
        /// </summary>
        /// <param name="x0">The value to be mapped to the lo 32 bits of the output</param>
        /// <param name="x1">The value to be mapped to the hi 32 bits of the output</param>
        [MethodImpl(Inline)]
        public static ulong pack(in uint x0, in uint x1)
              => (ulong)x0 | (ulong)x1 << 32;

        
        [MethodImpl(Inline)]
        public static uint pack(byte x0, byte x1, byte x2, byte x3)
              =>  (uint)x0 << 0 * 8 | (uint)x1 << 1 * 8 | (uint)x2 << 2 * 8 | (uint)x3 << 3 * 8;

        [MethodImpl(Inline)]
        public static ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)        
            => (ulong)x0 << 0 * 16
            |  (ulong)x1 << 1 * 16
            |  (ulong)x1 << 2 * 16
            |  (ulong)x1 << 3 * 16;

        
        /// <summary>
        /// Packs 8 bytes into an unsigned 64-bit integer, ordered from least significant to most significant
        /// </summary>
        /// <param name="x0">Specifies the bit range [7:0]</param>
        /// <param name="x1">Specifies the bit range [15:8]</param>
        /// <param name="x2">Specifies the bit range [23:6]</param>
        /// <param name="x3">Specifies the bit range [31:24]</param>
        /// <param name="x4"></param>
        /// <param name="x5"></param>
        /// <param name="x6"></param>
        /// <param name="x7"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {            
            return 
              (ulong)x0 << 0 * 8
            | (ulong)x1 << 1 * 8
            | (ulong)x2 << 2 * 8
            | (ulong)x3 << 3 * 8
            | (ulong)x4 << 4 * 8
            | (ulong)x5 << 5 * 8
            | (ulong)x6 << 6 * 8
            | (ulong)x7 << 7 * 8
            ;
        }        

        /// <summary>
        /// Selects a bit from each byte at a specified position packs these 8 bits into a single byte
        /// </summary>
        /// <param name="x00">The value to be packed into the least significant bit</param>
        /// <param name="x01">The second value</param>
        /// <param name="x02">The third value</param>
        /// <param name="x03">The fourth value</param>
        /// <param name="x04">The fifth value</param>
        /// <param name="x05">The sixth value</param>
        /// <param name="x06">The seventh value</param>
        /// <param name="x00">The value to be packed into the most significant bit</param>
        [MethodImpl(Inline)]
        public static ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
        {
          if(BitMask.test(x0, pos)) 
            BitMask.enable(ref dst, 0);
          if(BitMask.test(x1, pos)) 
            BitMask.enable(ref dst, 1);
          if(BitMask.test(x2, pos)) 
            BitMask.enable(ref dst, 2);
          if(BitMask.test(x3, pos)) 
            BitMask.enable(ref dst, 3);
          if(BitMask.test(x4, pos)) 
            BitMask.enable(ref dst, 4);
          if(BitMask.test(x5, pos)) 
            BitMask.enable(ref dst, 5);
          if(BitMask.test(x6, pos)) 
            BitMask.enable(ref dst, 6);
          if(BitMask.test(x7, pos)) 
            BitMask.enable(ref dst, 7);
          return ref dst;
        }

        /// <summary>
        /// Packs two bits into the first two bits of a byte
        /// </summary>
        /// <param name="b0">The bit value at index 0</param>
        /// <param name="b1">The bit value at index 1</param>
        [MethodImpl(Inline)]
        public static byte pack2(bool b0, bool b1)
        {
            byte dst = 0;
            if(b0)
              BitMask.enable(ref dst, 0);
            
            if(b1)
              BitMask.enable(ref dst, 1);
          
            return dst;
        }

        /// <summary>
        /// Packs three bits into the the first three bits of a byte
        /// </summary>
        /// <param name="b0">The bit value at index 0</param>
        /// <param name="b1">The bit value at index 1</param>
        /// <param name="b2">The bit value at index 2</param>
        [MethodImpl(Inline)]
        public static byte pack3(bool b0, bool b1, bool b2)
        {
            var dst = pack2(b0,b1);

            if(b2)
              BitMask.enable(ref dst, 2);
          
            return dst;
        }

        /// <summary>
        /// Packs four bits into the the first four bits of a byte
        /// </summary>
        /// <param name="b0">The bit value at index 0</param>
        /// <param name="b1">The bit value at index 1</param>
        /// <param name="b2">The bit value at index 2</param>
        /// <param name="b3">The bit value at index 3</param>
        [MethodImpl(Inline)]
        public static byte pack4(bool b0, bool b1, bool b2, bool b3)
        {
            var dst = pack3(b0,b1,b2);

            if(b3)
              BitMask.enable(ref dst, 3);
          
            return dst;
        }

        /// <summary>
        /// Packs five bits into the the first five bits of a byte
        /// </summary>
        /// <param name="b0">The bit value at index 0</param>
        /// <param name="b1">The bit value at index 1</param>
        /// <param name="b2">The bit value at index 2</param>
        /// <param name="b3">The bit value at index 3</param>
        /// <param name="b4">The bit value at index 4</param>
        [MethodImpl(Inline)]
        public static byte pack5(bool b0, bool b1, bool b2, bool b3, bool b4)
        {
            var dst = pack4(b0,b1,b2,b3);

            if(b4)
              BitMask.enable(ref dst, 4);            

            return dst;
        }

        /// <summary>
        /// Packs six bits into the the first six bits of a byte
        /// </summary>
        /// <param name="b0">The bit value at index 0</param>
        /// <param name="b1">The bit value at index 1</param>
        /// <param name="b2">The bit value at index 2</param>
        /// <param name="b3">The bit value at index 3</param>
        /// <param name="b4">The bit value at index 4</param>
        /// <param name="b5">The bit value at index 5</param>
        [MethodImpl(Inline)]
        public static byte pack6(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5)
        {
            var dst = pack5(b0,b1,b2,b3,b4);
            
            if(b5)
              BitMask.enable(ref dst, 5);

            return dst;
        }

        [MethodImpl(Inline)]
        public static byte pack7(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6)
        {
            var dst = pack6(b0,b0,b2,b3,b4,b5);

            if(b6)
              BitMask.enable(ref dst, 6);

            return dst;
        }

        [MethodImpl(Inline)]
        public static byte pack8(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7)
        {
            var dst = pack7(b0,b0,b2,b3,b4,b5,b6);
            
            if(b7)
              BitMask.enable(ref dst, 7);
            
            return dst;
        }

        /// <summary>
        /// Packs bits into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        [MethodImpl(Inline)]
        public static Span<byte> pack(ReadOnlySpan<Bit> src)
        {
            int srcLen = src.Length;
            int dstLen = srcLen >> 3;
            
            if ((srcLen & 0x07) != 0) 
                ++dstLen;

            return pack(src, new byte[dstLen]);            
        }

        /// <summary>
        /// Packs bits into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        public static Span<byte> pack(ReadOnlySpan<Bit> src, Span<byte> dst)
        {
            int srcLen = src.Length;
            for (int i = 0; i < srcLen; i++)
                if (src[i])
                    dst[i >> 3] |= (byte)((byte)1 << (i & 0x07));
            return dst;
        }

        public static Span<byte> pack(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            int srcLen = src.Length;
            for (int i = 0; i < srcLen; i++)
                if (src[i] == 1)
                    dst[i >> 3] |= (byte)((byte)1 << (i & 0x07));
            return dst;
        }

        /// <summary>
        /// Packs bools into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        public static Span<byte> pack(params bool[] src)
        {
            int srcLen = src.Length;
            int dstLen = srcLen >> 3;
            
            if ((srcLen & 0x07) != 0) 
                ++dstLen;

            Span<byte> dst = new byte[dstLen];
            for (int i = 0; i < srcLen; i++)
                if (src[i])
                    dst[i >> 3] |= (byte)((byte)1 << (i & 0x07));
            
            return dst;
        } 
    }
}
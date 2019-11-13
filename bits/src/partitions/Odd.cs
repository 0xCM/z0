//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {        
        /// <summary>
        /// Replicates identified odd bits of an 8-bit source to the low bits of an 8-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="parts">The bit selection</param>
        [MethodImpl(Inline)]
        public static byte select(byte src, Odd8 parts)
            => select(src, (byte)parts);

        /// <summary>
        /// Replicates identified odd bits of a 16-bit source to the low bits of a 16-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="parts">The bit selection</param>
        [MethodImpl(Inline)]
        public static ushort select(ushort src, Odd16 parts)
            => select(src, (ushort)parts);

        /// <summary>
        /// Replicates identified odd bits of a 32-bit source to the low bits of a 32-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="parts">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Odd32 parts)
            => select(src, (uint)parts);

        /// <summary>
        /// Replicates identified odd bits of a 64-bit source to the low bits of a 64-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="parts">The bit selection</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Odd64 parts)
            => select(src, (ulong)parts);

        /// <summary>
        /// Identifies the odd bits in a 4-bit sgement
        /// </summary>
        [Flags]
        public enum Odd4 : byte
        {
            /// <summary>
            /// Identifies the bit at position 1
            /// </summary>
            Bit1 = 0b10,
            
            /// <summary>
            /// Identifies the bit at position 3
            /// </summary>
            Bit3 = Bit1 << 2,
                                                
            /// <summary>
            /// Selects all odd bits from the segment
            /// </summary>
            Select = Bit1 |  Bit3
        }

        /// <summary>
        /// Identifies the odd bits in an 8-bit segment at bit-level granularity
        /// </summary>
        [Flags]
        public enum Odd8 : byte
        {
            /// <summary>
            /// Identifies the bit at position 1
            /// </summary>
            Bit1 = 0b10,
            
            /// <summary>
            /// Identifies the bit at position 3
            /// </summary>
            Bit3 = Bit1 << 2,            
            
            /// <summary>
            /// Identifies the bit at position 5
            /// </summary>
            Bit5 = Bit3 << 2,            
            
            /// <summary>
            /// Identifies the bit at position 7
            /// </summary>
            Bit7 = Bit5 << 2,
            
            /// <summary>
            /// Selects all odd bits from the segment
            /// </summary>
            Select = Bit1 |  Bit3 |  Bit5 |  Bit7

        }

        /// <summary>
        /// Identifies odd bits in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Odd16 : ushort
        {
            /// <summary>
            /// Identifies the odd bits in the first byte
            /// </summary>
            Byte0 = Odd8.Select,
            
            /// <summary>
            /// Identifies the odd bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Selects the odd bits in a 16-bit segment
            /// </summary>
            Select = Byte0 | Byte1
        }

        /// <summary>
        /// Identifies odd bits in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Odd32 : uint
        {
            /// <summary>
            /// Identifies the odd bits in the first byte
            /// </summary>
            Byte0 = Odd8.Select,
            
            /// <summary>
            /// Identifies the odd bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the odd bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the odd bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Selects the odd bits in a 32-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3
        }

        /// <summary>
        /// Identifies odd bits in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Odd64 : ulong
        {
            /// <summary>
            /// Identifies the odd bits in the first byte
            /// </summary>
            Byte0 = Odd8.Select,
            
            /// <summary>
            /// Identifies the odd bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the odd bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the odd bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Identifies the odd bits in the fifth byte
            /// </summary>
            Byte4 = Byte3 << 8,

            /// <summary>
            /// Identifies the odd bits in the sixth byte
            /// </summary>
            Byte5 = Byte4 << 8,

            /// <summary>
            /// Identifies the odd bits in the seventh byte
            /// </summary>
            Byte6 = Byte5 << 8,

            /// <summary>
            /// Identifies the odd bits in the eight byte
            /// </summary>
            Byte7 = Byte6 << 8,

            /// <summary>
            /// Selects the odd bits in a 64-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }

    }
}
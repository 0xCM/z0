//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    using static zfunc;

    /// <summary>
    /// Defines the signature of an operator that accepts a primal value and 
    /// partitions the value, or portion thereof, into segments of common length 
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span of sufficent length to receive the partition segments</param>
    /// <typeparam name="S">The primal source type</typeparam>
    /// <typeparam name="T">The primal target type</typeparam>
    public delegate void Partitioner<S,T>(S src, Span<T> dst)
        where T : unmanaged;

    /// <summary>
    /// Defines bitwise partition structures and functions
    /// </summary>
    public static partial class BitParts
    {            
        /// <summary>
        /// Identifies the least significant bit in a byte
        /// </summary>
        [Flags]
        public enum Lsb8x1 : byte
        {            
            Select = Pow2.T00,
        }

        /// <summary>
        /// Identifies the least significant bit of each byte of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Lsb16x8 : ushort
        {                        
            /// <summary>
            /// Identifies the least significant bit of the first byte
            /// </summary>
            Bit0 = Pow2.T00,
            
            /// <summary>
            /// Identifies the least significant bit of the second byte
            /// </summary>
            Bit8 = Bit0 << 8,            

            /// <summary>
            /// Selects the least significant bits of two 1-byte segments
            /// </summary>
            Select = Bit0 | Bit8
        }

        /// <summary>
        /// Identifies the least significant bit of each nibble of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Lsb16x4 : ushort
        {            
            /// <summary>
            /// Identifies the least significant bit of the first 4-bit segment
            /// </summary>
            Bit0 = Pow2.T00,
            
            /// <summary>
            /// Identifies the least significant bit of the second 4-bit segment
            /// </summary>
            Bit4 = Bit0 << 4,            

            /// <summary>
            /// Identifies the least significant bit of the third 4-bit segment
            /// </summary>
            Bit8 = Bit4 << 4,

            /// <summary>
            /// Identifies the least significant bit of the fourth 4-bit segment
            /// </summary>
            Bit12 = Bit8 << 4,
            
            /// <summary>
            /// Identifies the least significant bit of each 4-bit segment
            /// </summary>
            Select = Bit0 | Bit4 | Bit8 | Bit12
        }


        /// <summary>
        /// Identifies least significant bits of bytes in a 24-bit segment
        /// </summary>
        [Flags]
        public enum Lsb24x8 : uint
        {                        
            /// <summary>
            /// Identifies the least significant bit in the first byte
            /// </summary>
            Bit0 = Pow2.T00,
            
            /// <summary>
            /// Identifies the least significant bit in the second byte
            /// </summary>
            Bit8 = Bit0 << 8,

            /// <summary>
            /// Identifies the least significant bit in the third byte
            /// </summary>
            Bit16 = Bit8 << 8,

            /// <summary>
            /// Selects the least significant bit from each byte in a 24-bit segment
            /// </summary>
            Select = Bit0 | Bit8 | Bit16
        }

        /// <summary>
        /// Identifies least significant bits of bytes in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Lsb32x8 : uint
        {            
            /// <summary>
            /// Identifies the least significant bit in the first byte
            /// </summary>
            Bit0 = Pow2.T00,

            /// <summary>
            /// Identifies the least significant bit in the second byte
            /// </summary>
            Bit8 = Bit0 << 8,

            /// <summary>
            /// Identifies the least significant bit in the third byte
            /// </summary>
            Bit16 = Bit8 << 8,

            /// <summary>
            /// Identifies the least significant bit in the fourth byte
            /// </summary>
            Bit24 = Bit16 << 8,

            /// <summary>
            /// Selects the least significant bit from each byte in a 32-bit segment
            /// </summary>
            Select = Bit0 | Bit8 | Bit16 | Bit24
        }

        /// <summary>
        /// Identifies least significant bits of bytes in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Lsb64x8 : ulong
        {            
            /// <summary>
            /// Identifies the least significant bit in the first byte
            /// </summary>
            Bit0 = Pow2.T00,

            /// <summary>
            /// Identifies the least significant bit in the second byte
            /// </summary>
            Bit8 = Bit0 << 8,

            /// <summary>
            /// Identifies the least significant bit in the third byte
            /// </summary>
            Part16 = Bit8 << 8,

            /// <summary>
            /// Identifies the least significant bit in the fourth byte
            /// </summary>
            Bit24 = Part16 << 8,

            /// <summary>
            /// Identifies the least significant bit in the fifth byte
            /// </summary>
            Bit32 = Bit24 << 8,

            /// <summary>
            /// Identifies the least significant bit in the sixth byte
            /// </summary>
            Bit40 = Bit32 << 8,

            /// <summary>
            /// Identifies the least significant bit in the seventh byte
            /// </summary>
            Bit48 = Bit40 << 8,

            /// <summary>
            /// Identifies the least significant bit in the eighth byte
            /// </summary>
            Bit56 = Bit48 << 8,

            /// <summary>
            /// Identifies the least significant bit in each byte of a 64-bit segment
            /// </summary>
            Select = Bit0 | Bit8 | Part16 | Bit24 | Bit32 | Bit40 | Bit48 | Bit56
        }
 
         /// <summary>
        /// Identifies the most significant bit in an 8-bit segment
        /// </summary>
        [Flags]
        public enum Msb8x1 : byte
        {                        
            Bit7 = Pow2.T07
        }

        /// <summary>
        /// Identifies the most significant bit of each byte of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Msb16x8 : ushort
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Bit7 = Pow2.T07,
            
            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Bit15 = Bit7 << 8,            

            /// <summary>
            /// Selects the most significant bits of each byte in a 16-bit segment
            /// </summary>
            Select = Bit7 | Bit15
        }

        /// <summary>
        /// Identifies most significant bits of nibbles in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Msb16x4 : ushort
        {            
            /// <summary>
            /// Identifies the most significant bit of the first 4-bit segment
            /// </summary>
            Bit3 = Pow2.T03,
            
            /// <summary>
            /// Identifies the most significant bit in the second 4-bit segment
            /// </summary>
            Bit7 = Bit3 << 4,            

            /// <summary>
            /// Identifies the most significant bit in the third 4-bit segment
            /// </summary>
            Bit11 = Bit7 << 4,

            /// <summary>
            /// Identifies the most significant bit in the fourth 4-bit segment
            /// </summary>
            Bit15 = Bit11 << 4,

            /// <summary>
            /// Selects the most significant bits of each nibble in a 16-bit segment
            /// </summary>
            Select = Bit3 | Bit7 | Bit11 | Bit15
        }

        /// <summary>
        /// Identifies most significant bits of bytes in a 24-bit segment
        /// </summary>
        [Flags]
        public enum Msb24x8 : uint
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Bit7 = Pow2.T07,
            
            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Bit15 = Bit7 << 8,

            /// <summary>
            /// Identifies the most significant bit in the third byte
            /// </summary>
            Bit23 = Bit15 << 8,

            /// <summary>
            /// Selects the most significant bit from each byte in a 24-bit segment
            /// </summary>
            Select = Bit7 | Bit15 | Bit23
        }

        /// <summary>
        /// Identifies most significant bits of bytes in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Msb32x8 : uint
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Bit7 = Pow2.T07,

            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Bit15 = Bit7 << 8,

            /// <summary>
            /// Identifies the most significant bit in the third byte
            /// </summary>
            Bit23 = Bit15 << 8,

            /// <summary>
            /// Identifies the most significant bit in the fourth byte
            /// </summary>
            Bit31 = Bit23 << 8,

            /// <summary>
            /// Selects the most significant bit from each byte in a 32-bit segment
            /// </summary>
            Select = Bit7 | Bit15 | Bit23 | Bit31

        }

        /// <summary>
        /// Identifies most significant bits of bytes in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Msb64x8 : ulong
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Bit7 = Pow2.T07,

            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Bit15 = Bit7 << 8,

            /// <summary>
            /// Identifies the most significant bit in the third byte
            /// </summary>
            Bit23 = Bit15 << 8,

            /// <summary>
            /// Identifies the most significant bit in the fourth byte
            /// </summary>
            Bit31 = Bit23 << 8,

            /// <summary>
            /// Identifies the most significant bit in the fifth byte
            /// </summary>
            Byte39 = Bit31 << 8,

            /// <summary>
            /// Identifies the most significant bit in the sixth byte
            /// </summary>
            Byte47 = Byte39 << 8,

            /// <summary>
            /// Identifies the most significant bit in the seventh byte
            /// </summary>
            Bit55 = Byte47 << 8,

            /// <summary>
            /// Identifies the most significant bit in the eighth byte
            /// </summary>
            Bit63 = Bit55 << 8,
            
            /// <summary>
            /// Identifies the most significant bit in each byte of a 64-bit segment
            /// </summary>
            Select = Bit7 | Bit15 | Bit23 | Bit31 | Byte39 | Byte47 | Bit55 | Bit63
        }
 

    }
}
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
        /// Replicates identified even bits of an 8-bit source to the low bits of an 8-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Even8 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Replicates identified even bits of a 16-bit source to the low bits of a 16-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Even16 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Replicates identified even bits of a 32-bit source to the low bits of a 32-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Even32 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Replicates identified even bits of a 64-bit source to the low bits of a 64-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Even64 spec)
            => select(src, (ulong)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Even8 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Even16 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Even32 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Even64 spec)
            => project(src, (ulong)spec);


        /// <summary>
        /// Identifies the even bits in a 4-bit segment
        /// </summary>
        [Flags]
        public enum Even4 : byte
        {
            /// <summary>
            /// Identifies the bit at position 0
            /// </summary>
            Bit0 = Pow2.T00,
            
            /// <summary>
            /// Identifies the bit at position 2
            /// </summary>
            Bit2 = Bit0 << 2,
                                                
            /// <summary>
            /// Selects the even bits in a 4-bit segment
            /// </summary>
            Select = Bit0 |  Bit2 
        }

        /// <summary>
        /// Identifies the even bits in an 8-bit segment
        /// </summary>
        [Flags]
        public enum Even8 : byte
        {
            /// <summary>
            /// Identifies the bit at position 0
            /// </summary>
            Bit0 = Pow2.T00,
            
            /// <summary>
            /// Identifies the bit at position 2
            /// </summary>
            Bit2 = Bit0 << 2,
                        
            /// <summary>
            /// Identifies the bit at position 4
            /// </summary>
            Bit4 = Bit2 << 2,
                        
            /// <summary>
            /// Identifies the bit at position 6
            /// </summary>
            Bit6 = Bit4 << 2,
                        
            /// <summary>
            /// Selects the even bits in a byte
            /// </summary>
            Select = Bit0 |  Bit2 |  Bit4 | Bit6 

        }

        /// <summary>
        /// Identifies the even bits in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Even16 : ushort
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Selects the even bits in a 16-bit segment
            /// </summary>
            Select = Byte0 | Byte1
        }

        /// <summary>
        /// Identifies even bits in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Even32 : uint
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the even bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the even bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Selects the even bits in a 32-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3
        }
 
        /// <summary>
        /// Identifies even bits in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Even64 : ulong
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the even bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the even bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Identifies the even bits in the fifth byte
            /// </summary>
            Byte4 = Byte3 << 8,

            /// <summary>
            /// Identifies the even bits in the sixth byte
            /// </summary>
            Byte5 = Byte4 << 8,

            /// <summary>
            /// Identifies the even bits in the seventh byte
            /// </summary>
            Byte6 = Byte5 << 8,

            /// <summary>
            /// Identifies the even bits in the eighth byte
            /// </summary>
            Byte7 = Byte6 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }

    }

}
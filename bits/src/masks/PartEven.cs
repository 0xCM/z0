//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    using static zfunc;

    partial class BitParts
    {        
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
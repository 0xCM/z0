//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    partial class BitMasks
    {        
        /// <summary>
        /// [11100000]
        /// </summary>
        public const byte Msb8x3 = 0b11100000;

        /// <summary>
        /// [11100000 11100000]
        /// </summary>
        public const ushort Msb16x8x3 = (ushort)Msb16x8x3Seg.Select;

        /// <summary>
        /// [11100000 11100000 11100000 11100000]
        /// </summary>
        public const uint Msb32x8x3 = (uint)Msb32x8x3Seg.Select;

        /// <summary>
        /// [11100000 11100000 11100000 11100000 11100000 11100000 11100000 11100000]
        /// </summary>
        public const ulong Msb64x8x3 = (ulong)Msb64x8x3Seg.Select;

       /// <summary>
       /// Defines segments of a 16-bit mask that select the upper 3 bits of each 8-bit segment
       /// </summary>
        [Flags]
        public enum Msb16x8x3Seg : ushort
        {            
            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 8,

            /// <summary>
            /// Identifies segment 0
            /// </summary>
            Seg0 = Msb8x3,

            /// <summary>
            /// Identifies segment 1
            /// </summary>
            Seg1 = Seg0 << (int)Width,

            /// <summary>
            /// Selects all mask segments
            /// </summary>
            Select = Seg0 | Seg1 

        }

       /// <summary>
       /// Defines segments of a 32-bit mask that select the upper 3 bits of each 8-bit segment
       /// </summary>
        [Flags]
        public enum Msb32x8x3Seg : uint
        {            
            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 8,

            /// <summary>
            /// Identifies segment 0
            /// </summary>
            Seg0 = Msb8x3,

            /// <summary>
            /// Identifies segment 1
            /// </summary>
            Seg1 = Seg0 << (int)Width,

            /// <summary>
            /// Identifies segment 2
            /// </summary>
            Seg2 = Seg1 << (int)Width,

            /// <summary>
            /// Identifies segment 3
            /// </summary>
            Seg3 = Seg2 << (int)Width,

            /// <summary>
            /// Selects all mask segments
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 
        }
 
       /// <summary>
       /// Defines segments of a 64-bit mask that select the upper 3 bits of each 8-bit segment
       /// </summary>
        [Flags]
        public enum Msb64x8x3Seg : ulong
        {            
            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 8,

            /// <summary>
            /// Identifies segment 0
            /// </summary>
            Seg0 = Msb8x3,

            /// <summary>
            /// Identifies segment 1
            /// </summary>
            Seg1 = Seg0 << (int)Width,

            /// <summary>
            /// Identifies segment 2
            /// </summary>
            Seg2 = Seg1 << (int)Width,

            /// <summary>
            /// Identifies segment 3
            /// </summary>
            Seg3 = Seg2 << (int)Width,

            /// <summary>
            /// Identifies segment 4
            /// </summary>
            Seg4 = Seg3 << (int)Width,

            /// <summary>
            /// Identifies segment 5
            /// </summary>
            Seg5 = Seg4 << (int)Width,

            /// <summary>
            /// Identifies segment 6
            /// </summary>
            Seg6 = Seg5 << (int)Width,

            /// <summary>
            /// Identifies segment 7
            /// </summary>
            Seg7 = Seg6 << (int)Width,

            /// <summary>
            /// Selects all mask segments
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4 | Seg5 | Seg6 | Seg7
        }
    }

}
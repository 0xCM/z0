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
        /// [10000000_00000000_00000000_0000000]
        /// </summary>
        public const uint Msb32x1 = 0b10000000_00000000_00000000_0000000;

        /// <summary>
        /// [10000000 00000000 00000000 0000000 10000000 00000000 00000000 0000000]
        /// </summary>
        public const ulong Msb64x32x1 = (ulong)Msb64x32x1Seg.Select;

       /// <summary>
       /// Defines segments of a 64-bit mask that select the least bit of 2 32-bit segments
       /// </summary>
        [Flags]
        public enum Msb64x32x1Seg : ulong
        {            
            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 32,

            /// <summary>
            /// Identifies segment 0
            /// </summary>
            Seg0 = Msb32x1,

            /// <summary>
            /// Identifies segment 1
            /// </summary>
            Seg1 = Seg0 << (int)Width,

            /// <summary>
            /// Selects all mask segments
            /// </summary>
            Select = Seg0 | Seg1
        }
    }

}
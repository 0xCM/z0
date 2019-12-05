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
        /// [00000000 00000000 00000000 0000001]
        /// </summary>
        public const uint Lsb32x1 = 1;

        /// <summary>
        /// [00000000 00000000 00000000 0000001 00000000 00000000 00000000 0000001]
        /// </summary>
        public const ulong Lsb64x32x1 = (ulong)Lsb64x32x1Seg.Select;

       /// <summary>
       /// Defines segments of a 64-bit mask that select the least bit of 2 32-bit segments
       /// </summary>
        [Flags]
        public enum Lsb64x32x1Seg : ulong
        {            
            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 32,

            /// <summary>
            /// Identifies segment 0
            /// </summary>
            Seg0 = Lsb32x1,

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
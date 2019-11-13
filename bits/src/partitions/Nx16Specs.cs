//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static BitMasks;

    
    partial class BitParts
    {        
        /// <summary>
        /// Partitions a 32-bit container into 16-bit segments
        /// </summary>
        [Flags]
        public enum Part32x16 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 16,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/1
            /// </summary>
            Part0 = Part16x1.Select,

            /// <summary>
            /// Identifies partition 1/1
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1
        }
        /// <summary>
        /// Partitions a 48-bit container into 16-bit segments
        /// </summary>
        [Flags]
        public enum Part48x16 : ulong
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 48,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 16,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/2
            /// </summary>
            Part0 = Part16x1.Select,

            /// <summary>
            /// Identifies partition 1/2
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2/2
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2
        }
 
        /// <summary>
        /// Partitions a 64-bit container into 16-bit segments
        /// </summary>
        [Flags]
        public enum Part64x16 : ulong
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 64,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 16,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/3
            /// </summary>
            Part0 = Part16x1.Select,

            /// <summary>
            /// Identifies partition 1/3
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2/3
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3/3
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3
        }
 
    }
}
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
        /// Partitions a 24-bit container into 12-bit segments
        /// </summary>
        [Flags]
        public enum Part24x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/1
            /// </summary>
            Part0 = Part12x1.Select,

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
        /// Partitions a 36-bit container into 12-bit segments
        /// </summary>
        [Flags]
        public enum Part36x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 36,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/2
            /// </summary>
            Part0 = Part12x1.Select,

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
        /// Partitions a 48-bit container into 12-bit segments
        /// </summary>
        [Flags]
        public enum Part48x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 48,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/3
            /// </summary>
            Part0 = Part12x1.Select,

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

        /// <summary>
        /// Partitions a 60-bit container into segments of width 12
        /// </summary>
        [Flags]
        public enum Part60x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 60,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/4
            /// </summary>
            Part0 = Part12x1.Select,

            /// <summary>
            /// Identifies partition 1/4
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2/4
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3/4
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 4/4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4
        }
    }
}
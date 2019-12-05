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
        /// Partitions a 10-bit container into 5-bit segments
        /// </summary>
        [Flags]
        public enum Part10x5 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 10,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 5,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/1
            /// </summary>
            Part0 = Part5x1.Select,

            /// <summary>
            /// Identifies partition 1/2
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 
        }

        /// <summary>
        /// Partitions a 15-bit container into 5-bit segments
        /// </summary>
        [Flags]
        public enum Part15x5 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 15,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 5,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/2
            /// </summary>
            Part0 = Part5x1.Select,

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
        /// Partitions a 20-bit container into 5-bit segments
        /// </summary>
        [Flags]
        public enum Part20x5 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 20,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 5,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/3
            /// </summary>
            Part0 = Part5x1.Select,

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
        /// Partitions a 25-bit container into 5-bit segments
        /// </summary>
        [Flags]
        public enum Part25x5 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 20,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 5,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/4
            /// </summary>
            Part0 = Part5x1.Select,

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

        /// <summary>
        /// Partitions a 30-bit container into 5-bit segments
        /// </summary>
        [Flags]
        public enum Part30x5 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 30,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 5,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/5
            /// </summary>
            Part0 = Part5x1.Select,

            /// <summary>
            /// Identifies partition 1/5
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2/5
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3/5
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 4/5
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies partition 5/5
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5
        }

        /// <summary>
        /// Partitions a 60-bit container into 5-bit segments
        /// </summary>
        [Flags]
        public enum Part60x5 : ulong
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 60,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 5,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/11
            /// </summary>
            Part0 = Part5x1.Select,

            /// <summary>
            /// Identifies partition 1/11
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2/11
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3/11
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 4/11
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies partition 5/11
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies partition 6/11
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies partition 7/11
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies partition 8/11
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies partition 9/11
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies partition 10/11
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Identifies partition 10/11
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10
        }

    }

}
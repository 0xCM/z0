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

    partial class BitParts
    {        

        /// <summary>
        /// Partitions a 6-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part6x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 6,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/1
            /// </summary>
            Part0 = Part3x1.Select,

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
        /// Partitions a 9-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part9x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 9,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/2
            /// </summary>
            Part0 = Part3x1.Select,

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
            Select = Part0 |  Part1 |  Part2

        }

        /// <summary>
        /// Partitions a 12-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part12x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/3
            /// </summary>
            Part0 = Part3x1.Select,

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
        /// Partitions a 15-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part15x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 15,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/4
            /// </summary>
            Part0 = Part3x1.Select,

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
        /// Partitions an 18-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part18x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 18,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/5
            /// </summary>
            Part0 = Part3x1.Select,

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
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5,
        }

        /// <summary>
        /// Partitions a 21-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part21x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 21,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/6
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies partition 1/6
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2/6
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3/6
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 4/6
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies partition 5/6
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies partition 6/6
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6,
        }

        /// <summary>
        /// Partitions a 24-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part24x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0/7
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies partition 1/7
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2/7
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3/7
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 4/7
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies partition 5/7
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies partition 6/7
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies partition 7/7
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7,

        }

        /// <summary>
        /// Partitions a 27-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part27x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 27,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the eighth 3-bit group
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the ninth 3-bit group
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8,
        }

       /// <summary>
       /// Partitions a 30-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part30x3 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 30,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies partition 1
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies partition 5
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies partition 6
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies partition 7
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies partition 8
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies partition 9
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9,
        }


       /// <summary>
       /// Partitions a 33-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part33x3 : ulong
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 33,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies partition 2
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 3
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 4
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 5
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies partition 6
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies partition 7
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies partition 8
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies partition 9
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies partition 10
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies partition 11
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10,
        }

       /// <summary>
       /// Partitions a 36-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part36x3 : ulong
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 33,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies partition 1
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies partition 2
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies partition 3
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies partition 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies partition 5
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies partition 6
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies partition 7
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies partition 8
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies partition 9
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies partition 10
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Identifies partition 11
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10 | Part11,
        }

 
    }

}
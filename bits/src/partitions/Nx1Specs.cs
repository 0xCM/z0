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

    partial class BitParts
    {        
        /// <summary>
        /// Identifies the single bit in a segment with 1 bit
        /// </summary>
        [Flags]
        public enum Part1x1 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 1,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,
            
            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Bit0 = 0b1,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0,
        }

        /// <summary>
        /// Partitions a 2-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part2x1 : uint
        {                    
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 2,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1
        }

        /// <summary>
        /// Partitions a 3 bit containter into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part3x1 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 3,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2
        }

        /// <summary>
        /// Partitions a 4-bit containter into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part4x1 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 4,
            
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit3
        }

        /// <summary>
        /// Partitions a 5-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part5x1 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 5,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << (int)Width,

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit3 | Bit4
        }

        /// <summary>
        /// Partitions a 6-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part6x1 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 6,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << (int)Width,

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Bit5 = Bit4 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2  | Bit3 | Bit4  | Bit5
        }

        /// <summary>
        /// Partitions a 7-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part7x1 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 7,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 0
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies partition 1
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies partition 2
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies partition 3
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies partition 4
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies partition 5
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies partition 6
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2  | Bit3  | Bit4  | Bit5  | Bit6
        }

        /// <summary>
        /// Partitions an 8-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part8x1 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 8,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies partition 1
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies partition 2
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies partition 3
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies partition 4
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies partition 5
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies partition 6
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies partition 7
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies partition 8
            /// </summary>
            Bit7 = Bit6 << (int)Width,
            
            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit3 | Bit4 | Bit5 | Bit6 | Bit7 
        }

        /// <summary>
        /// Partitions a 9-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part9x1 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 9,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies the ninth bit
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit3 | Bit4 | Bit5 | Bit6 | Bit7 
                   | Bit8

        }

        /// <summary>
        /// Partitions an 10-bit container into 1-bit segments
       /// </summary>
        [Flags]
        public enum Part10x1 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 10,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies the ninth bit
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Identifies the tenth bit
            /// </summary>
            Bit9 = Bit8 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2  | Bit3  | Bit4  | Bit5  | Bit6  | Bit7 
                   | Bit8 | Bit9
        }
        

        /// <summary>
        /// Partitions an 11-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part11x1 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 11,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies the ninth bit
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Identifies the tenth bit
            /// </summary>
            Bit9 = Bit8 << (int)Width,

            /// <summary>
            /// Identifies the eleventh bit
            /// </summary>
            Bit10 = Bit9 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2  | Bit3  | Bit4  | Bit5  | Bit6  | Bit7 
                   | Bit8 | Bit9 | Bit10 
        }

        /// <summary>
        /// Partitions a 12-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part12x1 : uint
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies bit 4
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Bit9 = Bit8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Bit10 = Bit9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Bit11 = Bit10 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2  | Bit3 | Bit4 | Bit5 | Bit6 | Bit7 
                   | Bit8 | Bit9 | Bit10 | Bit11
        }

        /// <summary>
        /// Partitions a 13-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part13x1 : uint
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 13,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies bit 4
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Bit9 = Bit8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Bit10 = Bit9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Bit11 = Bit10 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Bit12 = Bit11 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2  | Bit3  | Bit4  | Bit5  | Bit6  | Bit7 
                   | Bit8 | Bit9 | Bit10 | Bit11 | Bit12
        }


        /// <summary>
        /// Partitions a 16-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part16x1 : uint
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 16,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies bit 4
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Bit9 = Bit8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Bit10 = Bit9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Bit11 = Bit10 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Bit12 = Bit11 << (int)Width,

            /// <summary>
            /// Identifies bit 13
            /// </summary>
            Bit13 = Bit12 << (int)Width,

            /// <summary>
            /// Identifies bit 14
            /// </summary>
            Bit14 = Bit13 << (int)Width,

            /// <summary>
            /// Identifies bit 15
            /// </summary>
            Bit15 = Bit14 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0 | Bit1 | Bit2  | Bit3  | Bit4  | Bit5  | Bit6  | Bit7 
                   | Bit8 | Bit9 | Bit10 | Bit11 | Bit12 | Bit13 | Bit14 | Bit15
        }

        /// <summary>
        /// Partitions a 32-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part32x1 : uint
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Bit0 = Part1x1.Bit0,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies bit 4
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Bit9 = Bit8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Bit10 = Bit9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Bit11 = Bit10 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Bit12 = Bit11 << (int)Width,

            /// <summary>
            /// Identifies bit 13
            /// </summary>
            Bit13 = Bit12 << (int)Width,

            /// <summary>
            /// Identifies bit 14
            /// </summary>
            Bit14 = Bit13 << (int)Width,

            /// <summary>
            /// Identifies bit 15
            /// </summary>
            Bit15 = Bit14 << (int)Width,

            /// <summary>
            /// Identifies bit 16
            /// </summary>
            Bit16 = Bit15 << (int)Width,

            /// <summary>
            /// Identifies bit 17
            /// </summary>
            Bit17 = Bit16 << (int)Width,

            /// <summary>
            /// Identifies bit 18
            /// </summary>
            Bit18 = Bit17 << (int)Width,

            /// <summary>
            /// Identifies bit 19
            /// </summary>
            Bit19 = Bit18 << (int)Width,            

            /// <summary>
            /// Identifies bit 20
            /// </summary>
            Bit20 = Bit19 << (int)Width,

            /// <summary>
            /// Identifies bit 21
            /// </summary>
            Bit21 = Bit20 << (int)Width,            

            /// <summary>
            /// Identifies bit 22
            /// </summary>
            Bit22 = Bit21 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 23
            /// </summary>
            Bit23 = Bit22 << (int)Width,

            /// <summary>
            /// Identifies bit 24
            /// </summary>
            Bit24 = Bit23 << (int)Width,

            /// <summary>
            /// Identifies bit 25
            /// </summary>
            Bit25 = Bit24 << (int)Width,

            /// <summary>
            /// Identifies bit 26
            /// </summary>
            Bit26 = Bit25 << (int)Width,

            /// <summary>
            /// Identifies bit 27
            /// </summary>
            Bit27 = Bit26 << (int)Width,

            /// <summary>
            /// Identifies bit 28
            /// </summary>
            Bit28 = Bit27 << (int)Width,

            /// <summary>
            /// Identifies bit 29
            /// </summary>
            Bit29 = Bit28 << (int)Width,

            /// <summary>
            /// Identifies bit 30
            /// </summary>
            Bit30 = Bit29 << (int)Width,

            /// <summary>
            /// Identifies bit 31
            /// </summary>
            Bit31 = Bit30 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0  | Bit1  | Bit2  | Bit3  | Bit4  | Bit5  | Bit6  | Bit7 
                   | Bit8  | Bit9  | Bit10 | Bit11 | Bit12 | Bit13 | Bit14 | Bit15
                   | Bit16 | Bit17 | Bit18 | Bit19 | Bit20 | Bit21 | Bit22 | Bit23
                   | Bit24 | Bit25 | Bit16 | Bit27 | Bit28 | Bit29 | Bit30 | Bit31
        }

        /// <summary>
        /// Partitions a 64-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part64x1 : ulong
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 64,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Bit0 = Pow2.T00,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Bit1 = Bit0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Bit2 = Bit1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Bit3 = Bit2 << (int)Width,            

            /// <summary>
            /// Identifies bit 4
            /// </summary>
            Bit4 = Bit3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Bit5 = Bit4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Bit6 = Bit5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Bit7 = Bit6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Bit8 = Bit7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Bit9 = Bit8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Bit10 = Bit9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Bit11 = Bit10 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Bit12 = Bit11 << (int)Width,

            /// <summary>
            /// Identifies bit 13
            /// </summary>
            Bit13 = Bit12 << (int)Width,

            /// <summary>
            /// Identifies bit 14
            /// </summary>
            Bit14 = Bit13 << (int)Width,

            /// <summary>
            /// Identifies bit 15
            /// </summary>
            Bit15 = Bit14 << (int)Width,

            /// <summary>
            /// Identifies bit 16
            /// </summary>
            Bit16 = Bit15 << (int)Width,

            /// <summary>
            /// Identifies bit 17
            /// </summary>
            Bit17 = Bit16 << (int)Width,

            /// <summary>
            /// Identifies bit 18
            /// </summary>
            Bit18 = Bit17 << (int)Width,

            /// <summary>
            /// Identifies bit 19
            /// </summary>
            Bit19 = Bit18 << (int)Width,            

            /// <summary>
            /// Identifies bit 20
            /// </summary>
            Bit20 = Bit19 << (int)Width,

            /// <summary>
            /// Identifies bit 21
            /// </summary>
            Bit21 = Bit20 << (int)Width,            

            /// <summary>
            /// Identifies bit 22
            /// </summary>
            Bit22 = Bit21 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 23
            /// </summary>
            Bit23 = Bit22 << (int)Width,

            /// <summary>
            /// Identifies bit 24
            /// </summary>
            Bit24 = Bit23 << (int)Width,

            /// <summary>
            /// Identifies bit 25
            /// </summary>
            Bit25 = Bit24 << (int)Width,

            /// <summary>
            /// Identifies bit 26
            /// </summary>
            Bit26 = Bit25 << (int)Width,

            /// <summary>
            /// Identifies bit 27
            /// </summary>
            Bit27 = Bit26 << (int)Width,

            /// <summary>
            /// Identifies bit 28
            /// </summary>
            Bit28 = Bit27 << (int)Width,

            /// <summary>
            /// Identifies bit 29
            /// </summary>
            Bit29 = Bit28 << (int)Width,

            /// <summary>
            /// Identifies bit 30
            /// </summary>
            Bit30 = Bit29 << (int)Width,

            /// <summary>
            /// Identifies bit 31
            /// </summary>
            Bit31 = Bit30 << (int)Width,

            /// <summary>
            /// Identifies bit 32
            /// </summary>
            Bit32 = Bit31 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 33
            /// </summary>
            Bit33 = Bit32 << (int)Width,

            /// <summary>
            /// Identifies bit 34
            /// </summary>
            Bit34 = Bit33 << (int)Width,

            /// <summary>
            /// Identifies bit 35
            /// </summary>
            Bit35 = Bit34 << (int)Width,

            /// <summary>
            /// Identifies bit 36
            /// </summary>
            Bit36 = Bit35 << (int)Width,

            /// <summary>
            /// Identifies bit 37
            /// </summary>
            Bit37 = Bit36 << (int)Width,

            /// <summary>
            /// Identifies bit 38
            /// </summary>
            Bit38 = Bit37 << (int)Width,

            /// <summary>
            /// Identifies bit 39
            /// </summary>
            Bit39 = Bit38 << (int)Width,

            /// <summary>
            /// Identifies bit 40
            /// </summary>
            Bit40 = Bit39 << (int)Width,

            /// <summary>
            /// Identifies bit 41
            /// </summary>
            Bit41 = Bit40 << (int)Width,

            /// <summary>
            /// Identifies bit 42
            /// </summary>
            Bit42 = Bit41 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 43
            /// </summary>
            Bit43 = Bit42 << (int)Width,

            /// <summary>
            /// Identifies bit 44
            /// </summary>
            Bit44 = Bit43 << (int)Width,

            /// <summary>
            /// Identifies bit 45
            /// </summary>
            Bit45 = Bit44 << (int)Width,

            /// <summary>
            /// Identifies bit 46
            /// </summary>
            Bit46 = Bit45 << (int)Width,

            /// <summary>
            /// Identifies bit 47
            /// </summary>
            Bit47 = Bit46 << (int)Width,

            /// <summary>
            /// Identifies bit 48
            /// </summary>
            Bit48 = Bit47 << (int)Width,

            /// <summary>
            /// Identifies bit 49
            /// </summary>
            Bit49 = Bit48 << (int)Width,

            /// <summary>
            /// Identifies bit 50
            /// </summary>
            Bit50 = Bit49 << (int)Width,

            /// <summary>
            /// Identifies bit 51
            /// </summary>
            Bit51 = Bit50 << (int)Width,

            /// <summary>
            /// Identifies bit 52
            /// </summary>
            Bit52 = Bit51 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 53
            /// </summary>
            Bit53 = Bit52 << (int)Width,

            /// <summary>
            /// Identifies bit 54
            /// </summary>
            Bit54 = Bit53 << (int)Width,

            /// <summary>
            /// Identifies bit 55
            /// </summary>
            Bit55 = Bit54 << (int)Width,

            /// <summary>
            /// Identifies bit 56
            /// </summary>
            Bit56 = Bit55 << (int)Width,

            /// <summary>
            /// Identifies bit 57
            /// </summary>
            Bit57 = Bit56 << (int)Width,

            /// <summary>
            /// Identifies bit 58
            /// </summary>
            Bit58 = Bit57 << (int)Width,

            /// <summary>
            /// Identifies bit 59
            /// </summary>
            Bit59 = Bit58 << (int)Width,

            /// <summary>
            /// Identifies bit 60
            /// </summary>
            Bit60 = Bit59 << (int)Width,

            /// <summary>
            /// Identifies bit 61
            /// </summary>
            Bit61 = Bit60 << (int)Width,

            /// <summary>
            /// Identifies bit 62
            /// </summary>
            Bit62 = Bit61 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 63
            /// </summary>
            Bit63 = Bit62 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Bit0  | Bit1  | Bit2  | Bit3  | Bit4  | Bit5  | Bit6  | Bit7  | Bit8  | Bit9  
                   | Bit10 | Bit11 | Bit12 | Bit13 | Bit14 | Bit15 | Bit16 | Bit17 | Bit18 | Bit19 
                   | Bit20 | Bit21 | Bit22 | Bit23 | Bit24 | Bit25 | Bit16 | Bit27 | Bit28 | Bit29 
                   | Bit30 | Bit31 | Bit32 | Bit33 | Bit34 | Bit35 | Bit36 | Bit37 | Bit38 | Bit39 
                   | Bit40 | Bit41 | Bit42 | Bit43 | Bit44 | Bit45 | Bit46 | Bit47 | Bit48 | Bit49 
                   | Bit50 | Bit51 | Bit52 | Bit53 | Bit54 | Bit55 | Bit56 | Bit57 | Bit58 | Bit59 
                   | Bit60 | Bit61 | Bit62 | Bit63
        }
    }
}
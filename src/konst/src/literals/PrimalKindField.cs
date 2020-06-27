//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct PrimalKindField
    {
        /// <summary>
        /// Defines indexed bitfield identifers
        /// </summary>
        public enum SegField : byte
        {            
            /// <summary>
            /// Identifies the bitfield segment that specifies a primitive width
            /// </summary>
            Width = 0,

            /// <summary>
            /// Identifies the bitfield segment that specifies a primtive kind identifier
            /// </summary>
            KindId = 1,

            /// <summary>
            /// Identifies the bitfield segment that specifies a primtive sign classifier
            /// </summary>
            Sign = 2,
        }

        /// <summary>
        /// Defines the widths of the primal kind bitfield segments
        /// </summary>
        public enum SegWidth : byte
        {
            /// <summary>
            /// The width of the Width segment (yes, contorted, but accurate)
            /// </summary>
            Width = 3,

            /// <summary>
            /// The width of the KindId segment
            /// </summary>
            KindId = 4,

            /// <summary>
            /// The width of the Sign segment
            /// </summary>
            Sign = 1,        
        }    

        public enum SegMask : byte
        {
            /// <summary>
            /// The Width field mask
            /// </summary>
            [BinaryLiteral("0b0_0000_111")]
            Width = 0b0_0000_111,

            /// <summary>
            /// The KindId field mask
            /// </summary>
            [BinaryLiteral("0b0_1111_000")]
            KindId = 0b0_1111_000,

            /// <summary>
            /// The Sign field mask
            /// </summary>
            [BinaryLiteral("0b1_0000_000")]
            Sign = 0b1_0000_000,
        }    

        /// <summary>
        /// Defines integers that correspond to the position of the first bit of each bitfield segment
        /// </summary>
        public enum SegIndex : byte
        {
            /// <summary>
            /// The starting index of the width field
            /// </summary>
            Width = 0,

            /// <summary>
            /// The starting index of the id field
            /// </summary>
            KindId = 3,

            /// <summary>
            /// The index of the sign flag
            /// </summary>
            Sign= 7,
        }        
    }
}
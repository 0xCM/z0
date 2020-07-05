//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using static Quartet;        

    using L = CreditTypes.ContentLevel;
    
    partial class CreditTypes
    {
        /// <summary>
        /// Defines literals that isolate content reference components
        /// </summary>
        [BitField(0,15)]
        public enum ContentField : ushort
        {                
            /// <summary>
            /// Defines the (uniform) bitfield segment width
            /// </summary>
            [FieldSeg("[1111]")]
            SegWidth = b1111,

            /// <summary>
            /// Defines the L0 bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00001111]")]
            L0 = SegWidth << L.L0,

            /// <summary>
            /// Defines the L1 bitfield segment
            /// </summary>
            [FieldSeg("[00000000 11110000]")]
            L1 = SegWidth << L.L1,

            /// <summary>
            /// Defines the L2 bitfield segment
            /// </summary>
            [FieldSeg("[00001111 00000000]")]
            L2 = SegWidth << L.L2,

            /// <summary>
            /// Defines the Type bitfield segment
            /// </summary>
            [FieldSeg("[11110000 00000000]")]
            Type = SegWidth << L.Type,
        }
    }
}
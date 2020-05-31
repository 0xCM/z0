//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
 
    using P = CreditTypes.DocFieldDelimiter;

    using static Octet;
 
    partial class CreditTypes
    {
        /// <summary>
        /// Defines literals that isolate reference components
        /// </summary>
        [BitField(0,47)]
        public enum DocField : ulong
        {                
            /// <summary>
            /// Defines the (uniform) bitfield segment width
            /// </summary>
            [SegWidth("[11111111]")]
            SegWidth = Max8,

            /// <summary>
            /// Defines the Vendor bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00000000 00000000 00000000 00000000 00000000 11111111]")]
            Vendor = SegWidth << P.Vendor,

            /// <summary>
            /// Defines the Volume bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00000000 00000000 00000000 00000000 11111111 00000000]")]
            Volume = SegWidth << P.Volume,

            /// <summary>
            /// Defines the Division bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00000000 00000000 00000000 11111111 00000000 00000000]")]
            Division = SegWidth << P.Division,

            /// <summary>
            /// Defines the Chapter bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00000000 00000000 00000000 11111111 00000000 00000000]")]
            Chapter = Division,

            /// <summary>
            /// Defines the Appendix bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00000000 00000000 00000000 11111111 00000000 00000000]")]
            Appendix = Division,

            /// <summary>
            /// Defines the Section bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00000000 00000000 11111111 00000000 00000000 00000000]")]
            Section = SegWidth << P.Section,

            /// <summary>
            /// Defines the Topic bitfield segment
            /// </summary>
            [FieldSeg("[00000000 00000000 11111111 00000000 00000000 00000000 00000000]")]
            Topic = SegWidth << P.Topic,

            [SegWidth("[11111111 11111111]")]
            ContentWidth = ushort.MaxValue,

            /// <summary>
            /// Defines the Content bitfield segment
            /// </summary>
            [FieldSeg("[11111111 11111111 00000000 00000000 00000000 00000000 00000000]")]
            Content = ContentWidth << P.Content,
        }

    }

}
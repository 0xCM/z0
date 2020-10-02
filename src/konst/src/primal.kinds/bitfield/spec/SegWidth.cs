//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct PrimalBitFieldSpec
    {
        /// <summary>
        /// Defines the widths of the primal kind bitfield segments
        /// </summary>
        public enum SegWidth : byte
        {
            /// <summary>
            /// The bit-width of the Size segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The bit-width of the KindId segment
            /// </summary>
            KindId = 4,

            /// <summary>
            /// The bit-width of the Sign segment
            /// </summary>
            Sign = 1,
        }
    }
}
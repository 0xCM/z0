//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct PrimalKindBitField
    {
        /// <summary>
        /// Defines positional identifiers for each bitfield segment
        /// </summary>
        public enum Field : byte
        {
            /// <summary>
            /// Identifies the bitfield segment that specifies a primitive width
            /// </summary>
            Width = 0,

            /// <summary>
            /// Identifies the bitfield segment that specifies a primitive kind identifier
            /// </summary>
            KindId = 1,

            /// <summary>
            /// Identifies the bitfield segment that specifies a primitive sign classifier
            /// </summary>
            Sign = 2,
        }
    }
}
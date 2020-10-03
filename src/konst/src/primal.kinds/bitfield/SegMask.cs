//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct PrimalKindBitField
    {
        public enum SegMask : byte
        {
            /// <summary>
            /// The Size field mask
            /// </summary>
            Size = 0b0_0000_111,

            /// <summary>
            /// The KindId field mask
            /// </summary>
            KindId = 0b0_1111_000,

            /// <summary>
            /// The Sign field mask
            /// </summary>
            Sign = 0b1_0000_000,
        }
    }
}
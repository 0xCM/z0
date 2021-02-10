//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using RP = RexPrefixCode;

    using static RexPrefixCode;

    public readonly struct RexPrefixFacets
    {
        /// <summary>
        /// The first rex prefix code
        /// </summary>
        public const RP MinRex = Rex40;

        /// <summary>
        /// The last rex prefix code
        /// </summary>
        public const RP MaxRex = RexWRXB;
    }
}
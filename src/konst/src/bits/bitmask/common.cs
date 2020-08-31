//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static BitMaskDescription;

    partial class BitMasks
    {
        /// <summary>
        /// [10000000]
        /// </summary>
        [BinaryLiteral("[10000000]")]
        public const byte SignMask8 = Pow2.T07;

        /// <summary>
        /// [10000000 00000000]
        /// </summary>
        [BinaryLiteral("[10000000 00000000]")]
        public const ushort SignMask16 = Pow2.T15;

        /// <summary>
        /// [10000000 00000000 00000000 00000000]
        /// </summary>
        [BinaryLiteral("[10000000 00000000 00000000 00000000]")]
        public const uint SignMask32 = Pow2.T31;

        /// <summary>
        /// [10000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000]
        /// </summary>
        [BinaryLiteral("[10000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000]")]
        public const ulong SignMask64 = Pow2.T63;

        public const sbyte Ones8i = -1;

        public const short Ones16i = -1;

        public const int Ones32i = -1;

        public const long Ones64i = -1;
    }
}
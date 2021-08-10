//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitMaskLiterals
    {
        /// <summary>
        /// [11111111]
        /// </summary>
        [BitMask ("[11111111]")]
        public const byte Lo8 = byte.MaxValue;

        /// <summary>
        /// [11111111 11111111]
        /// </summary>
        [BitMask ("[11111111 11111111]")]
        public const ushort Lo16 = ushort.MaxValue;

        /// <summary>
        /// [11111111 11111111 11111111]
        /// </summary>
        [BitMask ("[11111111 11111111 11111111]")]
        public const uint Lo24 = (uint)Lo16 << 8 | Lo8;

        /// <summary>
        /// [11111111 11111111 11111111 11111111]
        /// </summary>
        [BitMask ("[11111111 11111111 11111111 11111111]")]
        public const uint Lo32 = Lo24 << 8 | Lo8;

        /// <summary>
        /// [11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111111]
        /// </summary>
        [BitMask ("[11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111111]")]
        public const ulong Lo64 = ulong.MaxValue;
    }
}
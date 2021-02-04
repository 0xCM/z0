//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class BitMasks
    {
        partial struct Literals
        {
            /// <summary>
            /// [11111111]
            /// </summary>
            [BitMask ("[11111111]")]
            public const byte Lo8u = byte.MaxValue;

            /// <summary>
            /// [11111111 11111111]
            /// </summary>
            [BitMask ("[11111111 11111111]")]
            public const ushort Lo16u = (ushort) Lo8u << 8 | Lo8u;

            /// <summary>
            /// [11111111 11111111 11111111]
            /// </summary>
            [BitMask ("[11111111 11111111 11111111]")]
            public const uint Lo24u = (uint) Lo16u << 8 | Lo8u;

            /// <summary>
            /// [11111111 11111111 11111111 11111111]
            /// </summary>
            [BitMask ("[11111111 11111111 11111111 11111111]")]
            public const uint Lo32u = Lo24u << 8 | Lo8u;

            /// <summary>
            /// [11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111111]
            /// </summary>
            [BitMask ("[11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111111]")]
            public const ulong Lo64u = ulong.MaxValue;
        }
    }
}
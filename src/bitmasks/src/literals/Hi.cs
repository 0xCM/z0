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
            [BitMask("[11111111")]
            public const ushort Hi8x8 = Lo8u;

            [BitMask("[11111111 00000000")]
            public const ushort Hi16x8 = (ushort)Hi8x8 << 8;

            [BitMask("[11111111 00000000 00000000")]
            public const uint Hi24x8 = (uint)Hi16x8 << 8;

            [BitMask("[11111111 00000000 00000000 00000000")]
            public const uint Hi32x8 = (uint)Hi24x8 << 8;
        }
    }
}
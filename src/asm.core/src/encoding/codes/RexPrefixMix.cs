//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using static Hex8Seq;

    partial struct AsmCodes
    {
        public enum RexPrefixMix : byte
        {
            [Symbol("REX.XB", "[0100 0011] => [W:0 | R:0 | X:1 | B:1]")]
            Rex43 = x43,

            [Symbol("REX.RB", "[0100 0101] => [W:0 | R:1 | X:0 | B:1]")]
            Rex45 = x45,

            [Symbol("REX.RX", "[0100 0110] => [W:0 | R:1 | X:1 | B:0]")]
            Rex46 = x46,

            [Symbol("REX.RXB", "[0100 0111] => [W:0 | R:1 | X:1 | B:1]")]
            Rex47 = x47,

            [Symbol("REX.WB", "[0100 1001] => [W:1 | R:0 | X:0 | B:1]")]
            Rex49 = x49,

            [Symbol("REX.WX", "[0100 1010] => [W:1 | R:0 | X:1 | B:0]")]
            Rex4A = x4a,

            [Symbol("REX.WXB", "[0100 1011] => [W:1 | R:0 | X:1 | B:1]")]
            Rex4B = x4b,

            [Symbol("REX.WR", "[0100 1100] => [W:1 | R:1 | X:0 | B:0]")]
            Rex4C = x4c,

            [Symbol("REX.WRB","[0100 1101] => [W:1 | R:1 | X:0 | B:1]")]
            Rex4D = x4d,

            [Symbol("REX.WRX", "[0100 1110] => [W:1 | R:1 | X:1 | B:0]")]
            Rex4E = x4e,

            [Symbol("REX.WRXB", "[0100 1111] => [W:1 | R:1 | X:1 | B:1]")]
            Rex4F = x4f,
        }
    }
}
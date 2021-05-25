//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    /// <summary>
    /// Defines the rex prefix codes
    /// </summary>
    [PrefixCodes]
    public enum RexPrefixCode : byte
    {
        None = 0,

        [Symbol("REX", "40h | [0100 0000] | W:0 | R:0 | X:0 | B:0")]
        Rex40 = x40,

        [Symbol("REX.B", "41h | [0100 0001] | W:0 | R:0 | X:0 | B:1")]
        Rex41 = x41,

        [Symbol("REX.X", "42h | [0100 0010] | W:0 | R:0 | X:1 | B:0")]
        Rex42 = x42,

        [Symbol("REX.XB", "43h | [0100 0011] | W:0 | R:0 | X:1 | B:1")]
        Rex43 = x43,

        [Symbol("REX.R", "44h | [0100 0100] | W:0 | R:1 | X:0 | B:0")]
        Rex44 = x44,

        [Symbol("REX.RB", "45h | [0100 0101] | W:0 | R:1 | X:0 | B:1")]
        Rex45 = x45,

        [Symbol("REX.RX", "46h | [0100 0110] | W:0 | R:1 | X:1 | B:0")]
        Rex46 = x46,

        [Symbol("REX.RXB", "47h | [0100 0111] | W:0 | R:1 | X:1 | B:1")]
        Rex47 = x47,

        [Symbol("REX.W", "48h | [0100 1000] | W:1 | R:0 | X:0 | B:0")]
        Rex48 = x48,

        [Symbol("REX.WB", "49h | [0100 1001] | W:1 | R:0 | X:0 | B:1")]
        Rex49 = x49,

        [Symbol("REX.WX", "4ah | [0100 1010] | W:1 | R:0 | X:1 | B:0")]
        Rex4A = x4a,

        [Symbol("REX.WXB", "4bh | [0100 1011] | W:1 | R:0 | X:1 | B:1")]
        Rex4B = x4b,

        [Symbol("REX.WR", "4ch | [0100 1100] | W:1 | R:1 | X:0 | B:0")]
        Rex4C = x4c,

        [Symbol("REX.WRB","4dh | [0100 1101] | W:1 | R:1 | X:0 | B:1")]
        Rex4D = x4d,

        [Symbol("REX.WRX", "4eh | [0100 1110] | W:1 | R:1 | X:1 | B:0")]
        Rex4E = x4e,

        [Symbol("REX.WRXB", "4fh | [0100 1111] | W:1 | R:1 | X:1 | B:1")]
        Rex4F = x4f,
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct RexPrefixDescriptions
    {
        public const string Rex40 = "Rex | 40h | [0100 0000] | W:0 | R:0 | X:0 | B:0";

        public const string Rex41 = "REX.B | 41h | [0100 0001] | W:0 | R:0 | X:0 | B:1";

        public const string Rex42 = "REX.X | 42h | [0100 0010] | W:0 | R:0 | X:1 | B:0";

        public const string Rex43 = "REX.XB | 43h | [0100 0011] | W:0 | R:0 | X:1 | B:1";

        public const string Rex44 = "REX.R | 44h | [0100 0100] | W:0 | R:1 | X:0 | B:0";

        public const string Rex45 = "REX.RB | 45h | [0100 0101] | W:0 | R:1 | X:0 | B:1";

        public const string Rex46 = "REX.RX | 46h | [0100 0110] | W:0 | R:1 | X:1 | B:0";

        public const string Rex47 = "";

        public const string Rex48 = "";

        public const string Rex49 = "";

        public const string Rex4A = "";

        public const string Rex4B = "";

        public const string Rex4C = "";

        public const string Rex4D = "";

        public const string Rex4E = "";

        public const string Rex4F = "";
    }

    /*
    40h | [0100 0000] | W:0 | R:0 | X:0 | B:0 | Rex
    41h | [0100 0001] | W:0 | R:0 | X:0 | B:1 | REX.B
    42h | [0100 0010] | W:0 | R:0 | X:1 | B:0 | REX.X
    43h | [0100 0011] | W:0 | R:0 | X:1 | B:1 | REX.XB
    44h | [0100 0100] | W:0 | R:1 | X:0 | B:0 | REX.R
    45h | [0100 0101] | W:0 | R:1 | X:0 | B:1 | REX.RB
    46h | [0100 0110] | W:0 | R:1 | X:1 | B:0 | REX.RX
    47h | [0100 0111] | W:0 | R:1 | X:1 | B:1 | REX.RXB
    48h | [0100 1000] | W:1 | R:0 | X:0 | B:0 | REX.W
    49h | [0100 1001] | W:1 | R:0 | X:0 | B:1 | REX.WB
    4ah | [0100 1010] | W:1 | R:0 | X:1 | B:0 | REX.WX
    4bh | [0100 1011] | W:1 | R:0 | X:1 | B:1 | REX.WXB
    4ch | [0100 1100] | W:1 | R:1 | X:0 | B:0 | REX.WR
    4dh | [0100 1101] | W:1 | R:1 | X:0 | B:1 | REX.WRB
    4eh | [0100 1110] | W:1 | R:1 | X:1 | B:0 | REX.WRX
    4fh | [0100 1111] | W:1 | R:1 | X:1 | B:1 | REX.WRXB
    */
}
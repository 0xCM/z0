//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [LiteralProvider]
    readonly struct RexPrefixDescriptions
    {
        public const string Rex40 = "40h | [0100 0000] | W:0 | R:0 | X:0 | B:0";

        public const string Rex41 = "41h | [0100 0001] | W:0 | R:0 | X:0 | B:1";

        public const string Rex42 = "42h | [0100 0010] | W:0 | R:0 | X:1 | B:0";

        public const string Rex43 = "43h | [0100 0011] | W:0 | R:0 | X:1 | B:1";

        public const string Rex44 = "44h | [0100 0100] | W:0 | R:1 | X:0 | B:0";

        public const string Rex45 = "45h | [0100 0101] | W:0 | R:1 | X:0 | B:1";

        public const string Rex46 = "46h | [0100 0110] | W:0 | R:1 | X:1 | B:0";

        public const string Rex47 = "47h | [0100 0111] | W:0 | R:1 | X:1 | B:1";

        public const string Rex48 = "48h | [0100 1000] | W:1 | R:0 | X:0 | B:0";

        public const string Rex49 = "49h | [0100 1001] | W:1 | R:0 | X:0 | B:1";

        public const string Rex4A = "4ah | [0100 1010] | W:1 | R:0 | X:1 | B:0";

        public const string Rex4B = "4bh | [0100 1011] | W:1 | R:0 | X:1 | B:1";

        public const string Rex4C = "4ch | [0100 1100] | W:1 | R:1 | X:0 | B:0";

        public const string Rex4D = "4dh | [0100 1101] | W:1 | R:1 | X:0 | B:1";

        public const string Rex4E = "4eh | [0100 1110] | W:1 | R:1 | X:1 | B:0";

        public const string Rex4F = "4fh | [0100 1111] | W:1 | R:1 | X:1 | B:1";
    }
}
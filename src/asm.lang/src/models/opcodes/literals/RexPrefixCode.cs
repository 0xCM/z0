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
    public enum RexPrefixCode : byte
    {
        /// <summary>
        /// Defines the <see cref='x40'/> prefix
        /// </summary>
        Rex40 = x40,

        /// <summary>
        /// Defines the <see cref='x41'/> prefix
        /// </summary>
        RexB = x41,

        /// <summary>
        /// Defines the <see cref='x42'/> prefix
        /// </summary>
        Rex42 = x42,

        /// <summary>
        /// Defines the <see cref='x43'/> prefix
        /// </summary>
        Rex43 = x43,

        /// <summary>
        /// Defines the <see cref='x44'/> prefix
        /// </summary>
        Rex44 = x44,

        /// <summary>
        /// Defines the <see cref='x45'/> prefix
        /// </summary>
        Rex45 = x45,

        /// <summary>
        /// Defines the <see cref='x46'/> prefix
        /// </summary>
        Rex46 = x46,

        /// <summary>
        /// Defines the <see cref='x47'/> prefix
        /// </summary>
        Rex47 = x47,

        /// <summary>
        /// Defines the <see cref='x48'/> prefix
        /// </summary>
        RexW = x48,

        /// <summary>
        /// Defines the <see cref='x49'/> prefix
        /// </summary>
        RexWB = x49,

        /// <summary>
        /// Defines the <see cref='x4a'/> prefix
        /// </summary>
        RexWX = x4a,

        /// <summary>
        /// Defines the <see cref='x4b'/> prefix
        /// </summary>
        RexXB = x4b,

        /// <summary>
        /// Defines the <see cref='x4c'/> prefix
        /// </summary>
        RexWR = x4c,

        /// <summary>
        /// Defines the <see cref='x4d'/> prefix
        /// </summary>
        RexWRB = x4d,

        /// <summary>
        /// Defines the <see cref='x4e'/> prefix
        /// </summary>
        RexWRX = x4e,

        /// <summary>
        /// Defines the <see cref='x4f'/> prefix
        /// </summary>
        RexWRXB = x4f,
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
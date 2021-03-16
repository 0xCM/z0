//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [SymbolSource]
    public enum RexPrefixToken : byte
    {
        None = 0,

        [Symbol("REX")]
        Rex40,

        [Symbol("REX.B")]
        Rex41,

        [Symbol("REX.X")]
        Rex42,

        [Symbol("REX.XB")]
        Rex43,

        [Symbol("REX.R")]
        Rex44,

        [Symbol("REX.RB")]
        Rex45,

        [Symbol("REX.RX")]
        Rex46,

        [Symbol("REX.RXB")]
        Rex47,

        [Symbol("REX.W")]
        Rex48,

        [Symbol("REX.WB")]
        Rex49,

        [Symbol("REX.WX")]
        Rex4A,

        [Symbol("REX.WXB")]
        Rex4B,

        [Symbol("REX.WR")]
        Rex4C,

        [Symbol("REX.WRB")]
        Rex4D,

        [Symbol("REX.WRX")]
        Rex4E,

        [Symbol("REX.WRXB")]
        Rex4F
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmX
    {
        [SymbolSource]
        public enum PrefixToken : byte
        {
            None = 0,

            [Symbol("66")]
            x66,

            [Symbol("F2")]
            F2,

            [Symbol("F3")]
            F3,

            [Symbol("0F")]
            x0F,

            [Symbol("0F38")]
            x0F38,

            [Symbol("VEX")]
            VEX,

            [Symbol("REX.W")]
            RexW,

            [Symbol("LZ")]
            LZ,

            [Symbol("LIG")]
            LIG,

            [Symbol("WIG")]
            WIG,

            [Symbol("W0")]
            W0,

            [Symbol("W1")]
            W1,
        }
    }
}
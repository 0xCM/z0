//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmX
    {
        [SymbolSource]
        public enum Gp8Hi : byte
        {
            [Symbol("ah")]
            AH = r0  | r16,

            [Symbol("ch")]
            CH = r1  | r16,

            [Symbol("dh")]
            DH = r2  | r16,

            [Symbol("bh")]
            BH = r3  | r16,
        }
    }
}
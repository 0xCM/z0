//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    partial struct AsmCodes
    {
        [SymbolSource]
        public enum RepeatPrefix : byte
        {
            None = 0,

            [Symbol("f2")]
            REPNZ = xf2,

            [Symbol("f3")]
            REPZ = xf3,
        }
    }
}
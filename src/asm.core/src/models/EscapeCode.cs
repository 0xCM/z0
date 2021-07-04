//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        [SymSource]
        public enum EscapeCode : ushort
        {
            None = 0,

            [Symbol("0f")]
            x0F = 0x0F,

            [Symbol("0f 38")]
            x0F38 = 0x0F38,

            [Symbol("0f 3a")]
            x0F3A = 0x0F3A,
        }
    }
}
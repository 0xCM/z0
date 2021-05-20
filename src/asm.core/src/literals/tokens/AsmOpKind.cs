//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial struct AsmTokens
    {
        [Flags]
        public enum AsmOpKind : ushort
        {
            None = 0,

            R = AsmOpClass.R,

            M = AsmOpClass.M,

            Imm = AsmOpClass.Imm,
        }
    }
}
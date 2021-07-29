//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public enum EncodingRuleKind : byte
        {
            None = 0,

            ExplicitRegs,

            Imm,

            ModRM,

            Vex,

            Evex,

            Vsib,

            Arithmetic
        }
    }
}
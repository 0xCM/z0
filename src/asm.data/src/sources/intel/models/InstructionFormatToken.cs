//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        [SymbolSource]
        public enum InstructionFormatToken : byte
        {
            [Symbol("register1")]
            Reg1,

            [Symbol("register2")]
            Reg2,

            [Symbol("reg")]
            RegOp,

            [Symbol("reg1")]
            RegOp1,

            [Symbol("reg2")]
            RegOp2,

            [Symbol("qwordreg")]
            QRegOp,

            [Symbol("memory")]
            Mem,

            [Symbol("immediate")]
            Imm,

            [Symbol("imm8")]
            Imm8Op,

            [Symbol("imm32")]
            Imm32Op,
        }
    }
}
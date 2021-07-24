//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        [SymSource]
        public enum ColumnKind : byte
        {
            None = 0,

            [Symbol("Opcode")]
            OpCode,

            [Symbol("Instruction")]
            Signature,

            [Symbol("Op/En")]
            EncodingRef,

            [Symbol("CPUID Feature Flag")]
            Cpuid,

            [Symbol("64-bit Mode")]
            Mode64,

            [Symbol("Compat/Leg Mode")]
            Mode32,

            [Symbol("64/32 bit Mode Support")]
            Mode64x32,

            [Symbol("Description")]
            Description,

            [Symbol("Operand 1")]
            Op1,

            [Symbol("Operand 2")]
            Op2,

            [Symbol("Operand 3")]
            Op3,

            [Symbol("Operand 4")]
            Op4
        }
    }
}
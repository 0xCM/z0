//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    public enum OpCodeOption : byte
    {
        [Literal("A 1-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
        ib,

        [Literal("A 2-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
        iw,

        [Literal("A 4-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
        id,

        [Literal("An 8-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
        io,

        [Literal("Indicates that the ModR/M byte of the instruction contains a register operand and an r/m operand.")]
        ﾉr,

        [Literal("Indicates the use of a REX prefix that affects operand size or instruction semantics; REX prefixes that promote legacy instructions to 64-bit behavior are not listed explicitly in the opcode column.")]
        REXᕀW,

        [Literal("A digit between 0 and 7 indicates that the ModR/M byte of the instruction uses only the r/m (register or memory) operand.")]
        ﾉdigit,

        [Literal("Indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
        ᕀrb,

        [Literal("Indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
        ᕀrw,

        [Literal("Indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
        ᕀrd,

        [Literal("Indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
        ᕀro
    }
}
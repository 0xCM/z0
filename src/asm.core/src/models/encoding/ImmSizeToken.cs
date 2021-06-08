//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Specifies the size of an immediate operand in the context of an opcode specification
    /// </summary>
    [SymbolSource]
    public enum ImmSizeToken : byte
    {
        [Symbol("ib", "Indicates a 1-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
        ib,

        [Symbol("iw", "Indicates a 2-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
        iw,

        [Symbol("id", "Indicates a 4-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
        id,

        [Symbol("io", "Indicates An 8-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes")]
        io,
    }
}
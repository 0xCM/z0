//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmOpCodeTokens
    {
        [SymbolSource]
        public enum Offset : byte
        {
            [Symbol("cb", "Indicates a 1-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cb,

            [Symbol("cw", "Indicates a 2-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cw,

            [Symbol("cd", "Indicates a 4-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cd,

            [Symbol("cp", "Indicates a 6-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cp,

            [Symbol("co", "Indicates an 8-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            co,

            [Symbol("ct", "Indicates a 10-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            ct,
        }

        [SymbolSource]
        public enum Prefix : byte
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

        /// <summary>
        /// Specifies a '/r' token where r = 0..7. A digit between 0 and 7 indicates that the ModR/M byte
        /// of the instruction uses only the r/m (register or memory) operand. The reg field contains the
        /// digit that provides an extension to the instruction's opcode.
        /// </summary>
        [SymbolSource]
        public enum RegDigit : byte
        {
            [Symbol("/0", "Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 0 provides an extension to the instruction's opcode")]
            r0,

            [Symbol("/1", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 1 provides an extension to the instruction's opcode")]
            r1,

            [Symbol("/2", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 2 provides an extension to the instruction's opcode")]
            r2,

            [Symbol("/3", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 3 provides an extension to the instruction's opcode")]
            r3,

            [Symbol("/4", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 4 provides an extension to the instruction's opcode")]
            r4,

            [Symbol("/5", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 5 provides an extension to the instruction's opcode")]
            r5,

            [Symbol("/6", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 6 provides an extension to the instruction's opcode")]
            r6,

            [Symbol("/7", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 7 provides an extension to the instruction's opcode")]
            r7,
        }

        /// <summary>
        /// Specifies symbols that modify the op code value
        /// </summary>
        [SymbolSource]
        public enum OpCodeMod : byte
        {
            None,

            [Symbol("+rb", "For an 8-bit register, indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
            rb,

            [Symbol("+rw", "For a 16-bit register, in non-64-bit mode, a register code is arithmetically added to the value of the opcode byte, and in 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rw,

            [Symbol("+rd", "For a 32-bit register, in non-64-bit mode, a register code is arithmetically added to the value of the opcode byte, and In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rd,

            [Symbol("+ro", "For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            ro,
        }
    }
}